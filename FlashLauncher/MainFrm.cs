﻿using HabboLauncher.Utilities;
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
        private bool closing = false;

        public MainFrm(string[] args)
        {
            InitializeComponent();
            FormClosing += (s, e) => closing = true;

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
                    chkAutoLaunch.Text = $"Auto: Unity ({Program.Settings.AutoLaunchDelay}s)";

                    Task.Run(() =>
                    {
                        for (var i = Program.Settings.AutoLaunchDelay; i >= 0; i--)
                        {
                            if (!chkAutoLaunch.Checked || closing) return;
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
                else if (Program.Settings.LastLaunched == "air")
                {
                    chkAutoLaunch.Text = $"Auto: AIR ({Program.Settings.AutoLaunchDelay}s)";

                    Task.Run(() =>
                    {
                        for (var i = Program.Settings.AutoLaunchDelay; i >= 0; i--)
                        {
                            if (!chkAutoLaunch.Checked || closing) return;
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
                else if (Program.Settings.LastLaunched == "habbox")
                {
                    chkAutoLaunch.Text = $"Auto: Habbox ({Program.Settings.AutoLaunchDelay}s)";

                    Task.Run(() =>
                    {
                        for (var i = Program.Settings.AutoLaunchDelay; i >= 0; i--)
                        {
                            if (!chkAutoLaunch.Checked || closing) return;
                            if (i == 0 && btnLaunchFlash.Enabled)
                            {
                                btnLaunchHabbox_Click(null, null);
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    chkAutoLaunch.Text = $"Auto: Habbox ({i}s)";
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

            Task.Run(() =>
            {
                Launcher.LaunchFlashClient(server, ticket, Program.Settings.LaunchGEarth);

                Invoke((MethodInvoker)delegate
                {
                    Close();
                });
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

            if (m.Success)
            {
                server = m.Groups[1].Value;
                ticket = m.Groups[2].Value;

                if (server != null && (server == "hhxd" || server == "hhxp"))
                {
                    btnLaunchFlash.Enabled = false;
                    btnLaunchUnity.Enabled = false;
                    btnLaunchHabbox.Enabled = true;
                }
                else
                {
                    btnLaunchFlash.Enabled = true;
                    btnLaunchUnity.Enabled = true;
                    btnLaunchHabbox.Enabled = false;
                }
            }
            else
            {
                btnLaunchFlash.Enabled = false;
                btnLaunchUnity.Enabled = false;
                btnLaunchHabbox.Enabled = false;
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

        private void btnOptions_Click(object sender, EventArgs e)
        {
            DisableAutoLaunch();
            var frmOptions = new FrmOptions();
            frmOptions.ShowDialog();
        }

        private void btnLaunchHabbox_Click(object sender, EventArgs e)
        {
            Program.Settings.LastLaunched = "habbox";
            Program.Settings.SaveSettings();
            Launcher.LaunchHabboxClient(server, ticket);

            Invoke((MethodInvoker)delegate
            {
                Close();
            });
        }

        private void tssOptions_Click(object sender, EventArgs e)
        {
            DisableAutoLaunch();
            var frmOptions = new FrmOptions();
            frmOptions.ShowDialog();
        }

        private void chkLaunchGearth_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.LaunchGEarth = chkLaunchGearth.Checked;
            Program.Settings.SaveSettings();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SelfUpdater = new SelfUpdater(this);
            chkLaunchGearth.Checked = Program.Settings.LaunchGEarth;
            HandleAutoLaunch();
        }
    }
}
