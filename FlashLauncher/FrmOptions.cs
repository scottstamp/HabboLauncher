using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabboLauncher
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                txtGEarthPath.Text = Program.Settings.GEarthPath;
                ofd.FileName = Program.Settings.GEarthPath;
                chkLaunchGEarth.Checked = Program.Settings.LaunchGEarth;
                chkIgnoreClientUpdates.Checked = Program.Settings.IgnoreClientUpdates;
                chkIgnoreUpdateFlash.Checked = Program.Settings.IgnoreClientUpdatesFlash;
                chkIgnoreUpdateUnity.Checked = Program.Settings.IgnoreClientUpdatesUnity;
                chkIgnoreUpdateShockwave.Checked = Program.Settings.IgnoreClientUpdatesOrigins;
                chkIgnoreUpdateHabbox.Checked = Program.Settings.IgnoreClientUpdatesHabbox;
                chkOriginsXL.Checked = Program.Settings.OriginsXL;
                defaultOriginsServer.SelectedIndex = Program.Settings.DefaultOriginsServer;
                txtGEarthOriginsPath.Text = Program.Settings.GEarthOriginsPath;
                txtCustomSwfFlash.Text = Program.Settings.CustomSWFLink;
                chkUseCustomSwf.Checked = Program.Settings.UseCustomSwf;
                numAutoLaunchDelay.Value = Program.Settings.AutoLaunchDelay;
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

        private void btnGEarthBrowse_Click(object sender, EventArgs e)
        {
            
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK && ofd.CheckFileExists)
            {
                txtGEarthPath.Text = ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((int)numAutoLaunchDelay.Value < 3)
            {
                var result = MessageBox.Show("An auto-launch value lower than 3 seconds may make it impossible to open the options menu.\r\nYou can still manually edit the settings.json file to reset this value.\r\n\r\nAre you sure you wish to continue?", "HabboLauncher - Alert", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            if (defaultOriginsServer.SelectedIndex > 0)
            {
                MessageBox.Show("Now once you click on Habbo Origins on the launcher it will open by default on the selected server.");
            }
            else
            {
                defaultOriginsServer.SelectedIndex = 0;
            }

            Program.Settings.DefaultOriginsServer = defaultOriginsServer.SelectedIndex;
            Program.Settings.GEarthPath = txtGEarthPath.Text;
            Program.Settings.GEarthOriginsPath = txtGEarthOriginsPath.Text;
            Program.Settings.CustomSWFLink = txtCustomSwfFlash.Text;
            Program.Settings.UseCustomSwf = chkUseCustomSwf.Checked;
            Program.Settings.OriginsXL = chkOriginsXL.Checked;
            Program.Settings.LaunchGEarth = chkLaunchGEarth.Checked;
            Program.Settings.IgnoreClientUpdates = chkIgnoreClientUpdates.Checked;
            Program.Settings.IgnoreClientUpdatesFlash = chkIgnoreUpdateFlash.Checked; 
            Program.Settings.IgnoreClientUpdatesHabbox = chkIgnoreUpdateHabbox.Checked;
            Program.Settings.IgnoreClientUpdatesOrigins = chkIgnoreUpdateShockwave.Checked;
            Program.Settings.IgnoreClientUpdatesUnity = chkIgnoreUpdateUnity.Checked;
            
            Program.Settings.AutoLaunchDelay = (int)numAutoLaunchDelay.Value;

            Program.Settings.SaveSettings();

            if (Application.OpenForms["MainFrm"] is MainFrm MainFrm)
            {
                MainFrm.validateSettings(chkLaunchGEarth.Checked, chkUseCustomSwf.Checked);
            }


            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmOptions_Load(object sender, EventArgs e)
        {

        }

        private void btnGEarthOriginsBrowse_Click(object sender, EventArgs e)
        {
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK && ofd.CheckFileExists)
            {
                txtGEarthOriginsPath.Text = ofd.FileName;
            }
        }

        private async void txtCustomSwfFlash_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomSwfFlash.Text))
                return;

            if (txtCustomSwfFlash.Text == Program.Settings.CustomSWFLink)
                return;

            DialogResult result = MessageBox.Show(
                "Please ensure that you only use trusted SWF files.\n\n" +
                "Running unverified or modified SWF files can pose serious security risks, including the execution of malicious code on your computer.\n\n" +
                "Use this feature with caution. We are not responsible for any damage or misuse resulting from custom SWF files.\n\nBy pressing OK, this program will download the file from the Link you typed",
                "HabboLauncher ~ Alert",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                btnSave.Enabled = false;
                try
                {
                    await Program.Updater.DownloadCustomSWF(txtCustomSwfFlash.Text);
                    chkUseCustomSwf.Checked = true;
                }catch (Exception ex)
                {
                    MessageBox.Show(
                        $"An error occurred while downloading the file: {ex.Message}\n\n" +
                        "Make sure you are using a downloadable link to the SWF.\n\n" +
                        "For instance:\n" +
                        "https://github.com/LilithRainbows/HabboAirPlus/raw/refs/heads/main/HabboAir.swf",
                        "HabboLauncher ~ Download Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                btnSave.Enabled = true;
            }
        }

        private void chkUseCustomSwf_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.UseCustomSwf = chkUseCustomSwf.Checked;

            Task.Run(() =>
            {
                Launcher.ChangeFlashSwf();
            });
        }
    }
}
