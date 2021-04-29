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
            fbd.SelectedPath = Program.Settings.GEarthPath;
            chkLaunchGEarth.Checked = Program.Settings.LaunchGEarth;
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
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                txtGEarthPath.Text = fbd.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.Settings.GEarthPath = txtGEarthPath.Text;
            Program.Settings.LaunchGEarth = chkLaunchGEarth.Checked;
            Program.Settings.AutoLaunchDelay = (int)numAutoLaunchDelay.Value;

            Program.Settings.SaveSettings();

            Close();
        }
    }
}
