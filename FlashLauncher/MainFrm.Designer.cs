
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
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnLaunchFlash = new System.Windows.Forms.Button();
            this.chkLaunchGearth = new System.Windows.Forms.CheckBox();
            this.btnLaunchHabbox = new System.Windows.Forms.Button();
            this.btnLaunchOriginsUS = new System.Windows.Forms.Button();
            this.btnLaunchOriginsBR = new System.Windows.Forms.Button();
            this.btnLaunchOriginsES = new System.Windows.Forms.Button();
            this.btnLaunchHabboOrigins = new System.Windows.Forms.Button();
            this.btnLaunchUnity = new System.Windows.Forms.Button();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.lblVersionLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssOptions = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkUseCustomSwf = new System.Windows.Forms.CheckBox();
            this.ssInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAutoLaunch
            // 
            this.chkAutoLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoLaunch.AutoSize = true;
            this.chkAutoLaunch.Location = new System.Drawing.Point(9, 270);
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
            this.txtCode.Size = new System.Drawing.Size(312, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(361, 286);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 21);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnLaunchFlash
            // 
            this.btnLaunchFlash.Enabled = false;
            this.btnLaunchFlash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchFlash.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchFlash.Image")));
            this.btnLaunchFlash.Location = new System.Drawing.Point(12, 48);
            this.btnLaunchFlash.Name = "btnLaunchFlash";
            this.btnLaunchFlash.Size = new System.Drawing.Size(153, 100);
            this.btnLaunchFlash.TabIndex = 0;
            this.btnLaunchFlash.UseVisualStyleBackColor = true;
            this.btnLaunchFlash.Click += new System.EventHandler(this.btnLaunchFlash_Click);
            // 
            // chkLaunchGearth
            // 
            this.chkLaunchGearth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLaunchGearth.AutoSize = true;
            this.chkLaunchGearth.Location = new System.Drawing.Point(107, 270);
            this.chkLaunchGearth.Name = "chkLaunchGearth";
            this.chkLaunchGearth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLaunchGearth.Size = new System.Drawing.Size(101, 17);
            this.chkLaunchGearth.TabIndex = 7;
            this.chkLaunchGearth.Text = "Launch G-Earth";
            this.chkLaunchGearth.UseVisualStyleBackColor = false;
            this.chkLaunchGearth.CheckedChanged += new System.EventHandler(this.chkLaunchGearth_CheckedChanged);
            // 
            // btnLaunchHabbox
            // 
            this.btnLaunchHabbox.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunchHabbox.Enabled = false;
            this.btnLaunchHabbox.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchHabbox.Image")));
            this.btnLaunchHabbox.Location = new System.Drawing.Point(171, 154);
            this.btnLaunchHabbox.Name = "btnLaunchHabbox";
            this.btnLaunchHabbox.Size = new System.Drawing.Size(153, 100);
            this.btnLaunchHabbox.TabIndex = 11;
            this.btnLaunchHabbox.UseVisualStyleBackColor = false;
            this.btnLaunchHabbox.Click += new System.EventHandler(this.btnLaunchHabbox_Click);
            // 
            // btnLaunchOriginsUS
            // 
            this.btnLaunchOriginsUS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchOriginsUS.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchOriginsUS.Image")));
            this.btnLaunchOriginsUS.Location = new System.Drawing.Point(12, 184);
            this.btnLaunchOriginsUS.Name = "btnLaunchOriginsUS";
            this.btnLaunchOriginsUS.Size = new System.Drawing.Size(48, 40);
            this.btnLaunchOriginsUS.TabIndex = 12;
            this.btnLaunchOriginsUS.UseVisualStyleBackColor = true;
            this.btnLaunchOriginsUS.Click += new System.EventHandler(this.btnLaunchOriginsUS_Click);
            // 
            // btnLaunchOriginsBR
            // 
            this.btnLaunchOriginsBR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchOriginsBR.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchOriginsBR.Image")));
            this.btnLaunchOriginsBR.Location = new System.Drawing.Point(66, 184);
            this.btnLaunchOriginsBR.Name = "btnLaunchOriginsBR";
            this.btnLaunchOriginsBR.Size = new System.Drawing.Size(48, 40);
            this.btnLaunchOriginsBR.TabIndex = 13;
            this.btnLaunchOriginsBR.UseVisualStyleBackColor = true;
            this.btnLaunchOriginsBR.Click += new System.EventHandler(this.btnLaunchOriginsBR_Click);
            // 
            // btnLaunchOriginsES
            // 
            this.btnLaunchOriginsES.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchOriginsES.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchOriginsES.Image")));
            this.btnLaunchOriginsES.Location = new System.Drawing.Point(117, 184);
            this.btnLaunchOriginsES.Name = "btnLaunchOriginsES";
            this.btnLaunchOriginsES.Size = new System.Drawing.Size(48, 40);
            this.btnLaunchOriginsES.TabIndex = 14;
            this.btnLaunchOriginsES.UseVisualStyleBackColor = true;
            this.btnLaunchOriginsES.Click += new System.EventHandler(this.btnLaunchOriginsES_Click);
            // 
            // btnLaunchHabboOrigins
            // 
            this.btnLaunchHabboOrigins.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunchHabboOrigins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaunchHabboOrigins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchHabboOrigins.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchHabboOrigins.Image")));
            this.btnLaunchHabboOrigins.Location = new System.Drawing.Point(12, 154);
            this.btnLaunchHabboOrigins.Name = "btnLaunchHabboOrigins";
            this.btnLaunchHabboOrigins.Size = new System.Drawing.Size(153, 100);
            this.btnLaunchHabboOrigins.TabIndex = 10;
            this.btnLaunchHabboOrigins.UseVisualStyleBackColor = false;
            this.btnLaunchHabboOrigins.Click += new System.EventHandler(this.btnLaunchHabboOrigins_Click);
            // 
            // btnLaunchUnity
            // 
            this.btnLaunchUnity.BackColor = System.Drawing.Color.Transparent;
            this.btnLaunchUnity.Enabled = false;
            this.btnLaunchUnity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchUnity.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchUnity.Image")));
            this.btnLaunchUnity.Location = new System.Drawing.Point(171, 48);
            this.btnLaunchUnity.Name = "btnLaunchUnity";
            this.btnLaunchUnity.Size = new System.Drawing.Size(153, 100);
            this.btnLaunchUnity.TabIndex = 9;
            this.btnLaunchUnity.UseVisualStyleBackColor = false;
            this.btnLaunchUnity.Click += new System.EventHandler(this.btnLaunchUnity_Click);
            // 
            // ssInfo
            // 
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersionLink,
            this.tssOptions});
            this.ssInfo.Location = new System.Drawing.Point(0, 314);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(336, 22);
            this.ssInfo.SizingGrip = false;
            this.ssInfo.TabIndex = 4;
            // 
            // lblVersionLink
            // 
            this.lblVersionLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblVersionLink.IsLink = true;
            this.lblVersionLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblVersionLink.Name = "lblVersionLink";
            this.lblVersionLink.Size = new System.Drawing.Size(37, 17);
            this.lblVersionLink.Text = "v0.0.0";
            this.lblVersionLink.Click += new System.EventHandler(this.lblVersionLink_Click);
            // 
            // tssOptions
            // 
            this.tssOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssOptions.IsLink = true;
            this.tssOptions.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tssOptions.Margin = new System.Windows.Forms.Padding(250, 3, 0, 2);
            this.tssOptions.Name = "tssOptions";
            this.tssOptions.Size = new System.Drawing.Size(49, 17);
            this.tssOptions.Text = "Options";
            this.tssOptions.Click += new System.EventHandler(this.tssOptions_Click);
            // 
            // chkUseCustomSwf
            // 
            this.chkUseCustomSwf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUseCustomSwf.AutoSize = true;
            this.chkUseCustomSwf.Location = new System.Drawing.Point(214, 270);
            this.chkUseCustomSwf.Name = "chkUseCustomSwf";
            this.chkUseCustomSwf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUseCustomSwf.Size = new System.Drawing.Size(110, 17);
            this.chkUseCustomSwf.TabIndex = 15;
            this.chkUseCustomSwf.Text = "Use Custom SWF";
            this.chkUseCustomSwf.UseVisualStyleBackColor = false;
            this.chkUseCustomSwf.CheckedChanged += new System.EventHandler(this.chkUseCustomSwf_CheckedChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 336);
            this.Controls.Add(this.chkUseCustomSwf);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.btnLaunchOriginsES);
            this.Controls.Add(this.btnLaunchOriginsBR);
            this.Controls.Add(this.btnLaunchOriginsUS);
            this.Controls.Add(this.btnLaunchHabbox);
            this.Controls.Add(this.btnLaunchHabboOrigins);
            this.Controls.Add(this.btnLaunchUnity);
            this.Controls.Add(this.chkLaunchGearth);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.chkAutoLaunch);
            this.Controls.Add(this.txtCode);
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
        private System.Windows.Forms.CheckBox chkAutoLaunch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.CheckBox chkLaunchGearth;
        private System.Windows.Forms.Button btnLaunchUnity;
        private System.Windows.Forms.Button btnLaunchHabboOrigins;
        private System.Windows.Forms.Button btnLaunchHabbox;
        private System.Windows.Forms.Button btnLaunchOriginsUS;
        private System.Windows.Forms.Button btnLaunchOriginsBR;
        private System.Windows.Forms.Button btnLaunchOriginsES;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblVersionLink;
        private System.Windows.Forms.ToolStripStatusLabel tssOptions;
        private System.Windows.Forms.CheckBox chkUseCustomSwf;
    }
}