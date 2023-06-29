
namespace HabboLauncher
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.chkAutoLaunch = new System.Windows.Forms.CheckBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.lblVersionLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnLaunchHabbox = new System.Windows.Forms.Button();
            this.btnLaunchUnity = new System.Windows.Forms.Button();
            this.btnLaunchFlash = new System.Windows.Forms.Button();
            this.chkLaunchGearth = new System.Windows.Forms.CheckBox();
            this.tssOptions = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAutoLaunch
            // 
            this.chkAutoLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoLaunch.AutoSize = true;
            this.chkAutoLaunch.Location = new System.Drawing.Point(12, 124);
            this.chkAutoLaunch.Name = "chkAutoLaunch";
            this.chkAutoLaunch.Size = new System.Drawing.Size(92, 17);
            this.chkAutoLaunch.TabIndex = 2;
            this.chkAutoLaunch.Text = "Auto: AIR (5s)";
            this.chkAutoLaunch.UseVisualStyleBackColor = true;
            this.chkAutoLaunch.CheckedChanged += new System.EventHandler(this.chkAutoLaunch_CheckedChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(237, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // ssInfo
            // 
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersionLink,
            this.tssOptions});
            this.ssInfo.Location = new System.Drawing.Point(0, 149);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(261, 22);
            this.ssInfo.SizingGrip = false;
            this.ssInfo.TabIndex = 4;
            // 
            // lblVersionLink
            // 
            this.lblVersionLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblVersionLink.IsLink = true;
            this.lblVersionLink.Name = "lblVersionLink";
            this.lblVersionLink.Size = new System.Drawing.Size(37, 17);
            this.lblVersionLink.Text = "v0.0.0";
            this.lblVersionLink.Click += new System.EventHandler(this.lblVersionLink_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(286, 121);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 21);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnLaunchHabbox
            // 
            this.btnLaunchHabbox.Enabled = false;
            this.btnLaunchHabbox.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchHabbox.Image")));
            this.btnLaunchHabbox.Location = new System.Drawing.Point(174, 38);
            this.btnLaunchHabbox.Name = "btnLaunchHabbox";
            this.btnLaunchHabbox.Size = new System.Drawing.Size(75, 75);
            this.btnLaunchHabbox.TabIndex = 6;
            this.btnLaunchHabbox.UseVisualStyleBackColor = true;
            this.btnLaunchHabbox.Click += new System.EventHandler(this.btnLaunchHabbox_Click);
            // 
            // btnLaunchUnity
            // 
            this.btnLaunchUnity.Enabled = false;
            this.btnLaunchUnity.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchUnity.Image")));
            this.btnLaunchUnity.Location = new System.Drawing.Point(93, 38);
            this.btnLaunchUnity.Name = "btnLaunchUnity";
            this.btnLaunchUnity.Size = new System.Drawing.Size(75, 75);
            this.btnLaunchUnity.TabIndex = 1;
            this.btnLaunchUnity.UseVisualStyleBackColor = true;
            this.btnLaunchUnity.Click += new System.EventHandler(this.btnLaunchUnity_Click);
            // 
            // btnLaunchFlash
            // 
            this.btnLaunchFlash.Enabled = false;
            this.btnLaunchFlash.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchFlash.Image")));
            this.btnLaunchFlash.Location = new System.Drawing.Point(12, 38);
            this.btnLaunchFlash.Name = "btnLaunchFlash";
            this.btnLaunchFlash.Size = new System.Drawing.Size(75, 75);
            this.btnLaunchFlash.TabIndex = 0;
            this.btnLaunchFlash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLaunchFlash.UseVisualStyleBackColor = true;
            this.btnLaunchFlash.Click += new System.EventHandler(this.btnLaunchFlash_Click);
            // 
            // chkLaunchGearth
            // 
            this.chkLaunchGearth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLaunchGearth.AutoSize = true;
            this.chkLaunchGearth.Location = new System.Drawing.Point(148, 124);
            this.chkLaunchGearth.Name = "chkLaunchGearth";
            this.chkLaunchGearth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLaunchGearth.Size = new System.Drawing.Size(101, 17);
            this.chkLaunchGearth.TabIndex = 7;
            this.chkLaunchGearth.Text = "Launch G-Earth";
            this.chkLaunchGearth.UseVisualStyleBackColor = true;
            this.chkLaunchGearth.CheckedChanged += new System.EventHandler(this.chkLaunchGearth_CheckedChanged);
            // 
            // tssOptions
            // 
            this.tssOptions.IsLink = true;
            this.tssOptions.Margin = new System.Windows.Forms.Padding(170, 3, 0, 2);
            this.tssOptions.Name = "tssOptions";
            this.tssOptions.Size = new System.Drawing.Size(49, 17);
            this.tssOptions.Text = "Options";
            this.tssOptions.Click += new System.EventHandler(this.tssOptions_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 171);
            this.Controls.Add(this.chkLaunchGearth);
            this.Controls.Add(this.btnLaunchHabbox);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.chkAutoLaunch);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnLaunchUnity);
            this.Controls.Add(this.btnLaunchFlash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Habbo Launcher";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchFlash;
        private System.Windows.Forms.Button btnLaunchUnity;
        private System.Windows.Forms.CheckBox chkAutoLaunch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblVersionLink;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnLaunchHabbox;
        private System.Windows.Forms.CheckBox chkLaunchGearth;
        private System.Windows.Forms.ToolStripStatusLabel tssOptions;
    }
}