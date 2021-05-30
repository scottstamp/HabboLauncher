using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            txtGEarthPath.Text = Program.Settings.GEarthPath;
            ofd.FileName = Program.Settings.GEarthPath;
            chkLaunchGEarth.Checked = Program.Settings.LaunchGEarth;
            chkIgnoreClientUpdates.Checked = Program.Settings.IgnoreClientUpdates;
            numAutoLaunchDelay.Value = Program.Settings.AutoLaunchDelay;
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

            Program.Settings.GEarthPath = txtGEarthPath.Text;
            Program.Settings.LaunchGEarth = chkLaunchGEarth.Checked;
            Program.Settings.IgnoreClientUpdates = chkIgnoreClientUpdates.Checked;
            Program.Settings.AutoLaunchDelay = (int)numAutoLaunchDelay.Value;

            Program.Settings.SaveSettings();

            Close();
        }
    }
}
