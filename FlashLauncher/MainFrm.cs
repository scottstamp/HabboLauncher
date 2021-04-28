using HabboLauncher.Utilities;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HabboLauncher
{
    public partial class MainFrm : Form
    {
        private readonly Regex tokenRe = new Regex(@"^([\w]+)\.([\w-]+\.V4)$");
        private string server = "", ticket = "";
        private SelfUpdater SelfUpdater;

        public MainFrm(string[] args)
        {
            InitializeComponent();
            
            if (args.Length == 1)
            {
                var uriQuery = HttpUtility.ParseQueryString(new Uri(args[0]).Query);
                server = uriQuery.Get("server");
                ticket = uriQuery.Get("token");

                txtCode.Text = $"{server}.{ticket}";
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 8;  // Turn on WS_EX_TOPMOST
                return cp;
            }
        }

        public void SetVersionText(string text)
        {
            Invoke((MethodInvoker)delegate
            {
                lblVersionLink.Text = $"v{text}";
            });
        }

        public void DisableAutoLaunch()
        {
            chkAutoLaunch.Invoke((MethodInvoker)delegate
            {
                chkAutoLaunch.Checked = false;
            });
        }

        private void HandleAutoLaunch()
        {
            if (Program.Settings.AutoLaunch)
            {
                chkAutoLaunch.Checked = true;
                if (Program.Settings.LastLaunched == "unity")
                {
                    chkAutoLaunch.Text = "Auto: Unity (5s)";

                    Task.Run(() =>
                    {
                        for (var i = 5; i >= 0; i--)
                        {
                            if (!chkAutoLaunch.Checked) return;
                            if (i == 0 && chkAutoLaunch.Checked && btnLaunchUnity.Enabled)
                            {
                                btnLaunchUnity_Click(null, null);
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    chkAutoLaunch.Text = $"Auto: Unity ({i}s)";
                                });

                                Task.Delay(1000).Wait();
                            }
                        }
                    });
                }
                else
                {
                    chkAutoLaunch.Text = "Auto: AIR (5s)";

                    Task.Run(() =>
                    {
                        for (var i = 5; i >= 0; i--)
                        {
                            if (!chkAutoLaunch.Checked) return;
                            if (i == 0 && btnLaunchFlash.Enabled)
                            {
                                btnLaunchFlash_Click(null, null);
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    chkAutoLaunch.Text = $"Auto: AIR ({i}s)";
                                });

                                Task.Delay(1000).Wait();
                            }
                        }
                    });
                }
            }
        }

        private void btnLaunchFlash_Click(object sender, EventArgs e)
        {
            Program.Settings.LastLaunched = "air";
            Program.Settings.SaveSettings();
            Launcher.LaunchFlashClient(server, ticket);

            Invoke((MethodInvoker)delegate
            {
                Close();
            });
        }

        private void btnLaunchUnity_Click(object sender, EventArgs e)
        {
            Program.Settings.LastLaunched = "unity";
            Program.Settings.SaveSettings();
            Launcher.LaunchUnityClient(server, ticket);

            Invoke((MethodInvoker)delegate
            {
                Close();
            });
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            var m = tokenRe.Match(txtCode.Text);
            btnLaunchFlash.Enabled = m.Success;
            btnLaunchUnity.Enabled = m.Success;

            if (m.Success)
            {
                server = m.Groups[1].Value;
                ticket = m.Groups[2].Value;
            }
        }

        private void chkAutoLaunch_CheckedChanged(object sender, EventArgs e)
        {
            chkAutoLaunch.Text = "Auto: Last choice (unset)";
            Program.Settings.AutoLaunch = chkAutoLaunch.Checked;
            Program.Settings.SaveSettings();
        }

        private void lblVersionLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/scottstamp/HabboLauncher/releases/latest");
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SelfUpdater = new SelfUpdater(this);
            HandleAutoLaunch();
        }
    }
}
