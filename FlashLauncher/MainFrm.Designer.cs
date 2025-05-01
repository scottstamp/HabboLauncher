
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblVersionLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLaunchUnity = new System.Windows.Forms.Button();
            this.btnLaunchHabboOrigins = new System.Windows.Forms.Button();
            this.btnLaunchHabbox = new System.Windows.Forms.Button();
            this.btnLaunchOriginsUS = new System.Windows.Forms.Button();
            this.btnLaunchOriginsBR = new System.Windows.Forms.Button();
            this.btnLaunchOriginsES = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAutoLaunch
            // 
            this.chkAutoLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoLaunch.AutoSize = true;
            this.chkAutoLaunch.ForeColor = System.Drawing.Color.White;
            this.chkAutoLaunch.Location = new System.Drawing.Point(12, 329);
            this.chkAutoLaunch.Name = "chkAutoLaunch";
            this.chkAutoLaunch.Size = new System.Drawing.Size(92, 17);
            this.chkAutoLaunch.TabIndex = 2;
            this.chkAutoLaunch.Text = "Auto: AIR (5s)";
            this.chkAutoLaunch.UseVisualStyleBackColor = true;
            this.chkAutoLaunch.CheckedChanged += new System.EventHandler(this.chkAutoLaunch_CheckedChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(23, 74);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(237, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(310, 308);
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
            this.btnLaunchFlash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunchFlash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchFlash.Location = new System.Drawing.Point(23, 100);
            this.btnLaunchFlash.Name = "btnLaunchFlash";
            this.btnLaunchFlash.Size = new System.Drawing.Size(237, 47);
            this.btnLaunchFlash.TabIndex = 0;
            this.btnLaunchFlash.Text = "Habbo";
            this.btnLaunchFlash.UseVisualStyleBackColor = true;
            this.btnLaunchFlash.Click += new System.EventHandler(this.btnLaunchFlash_Click);
            // 
            // chkLaunchGearth
            // 
            this.chkLaunchGearth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLaunchGearth.AutoSize = true;
            this.chkLaunchGearth.ForeColor = System.Drawing.Color.White;
            this.chkLaunchGearth.Location = new System.Drawing.Point(172, 329);
            this.chkLaunchGearth.Name = "chkLaunchGearth";
            this.chkLaunchGearth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLaunchGearth.Size = new System.Drawing.Size(101, 17);
            this.chkLaunchGearth.TabIndex = 7;
            this.chkLaunchGearth.Text = "Launch G-Earth";
            this.chkLaunchGearth.UseVisualStyleBackColor = true;
            this.chkLaunchGearth.CheckedChanged += new System.EventHandler(this.chkLaunchGearth_CheckedChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Snow;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Options";
            this.toolStripLabel1.Click += new System.EventHandler(this.tssOptions_Click);
            // 
            // lblVersionLink
            // 
            this.lblVersionLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblVersionLink.IsLink = true;
            this.lblVersionLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblVersionLink.Name = "lblVersionLink";
            this.lblVersionLink.Size = new System.Drawing.Size(37, 20);
            this.lblVersionLink.Text = "v0.0.0";
            this.lblVersionLink.Click += new System.EventHandler(this.lblVersionLink_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblVersionLink});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip";
            // 
            // btnLaunchUnity
            // 
            this.btnLaunchUnity.Enabled = false;
            this.btnLaunchUnity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunchUnity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchUnity.Location = new System.Drawing.Point(23, 153);
            this.btnLaunchUnity.Name = "btnLaunchUnity";
            this.btnLaunchUnity.Size = new System.Drawing.Size(237, 47);
            this.btnLaunchUnity.TabIndex = 9;
            this.btnLaunchUnity.Text = "Habbo Beta";
            this.btnLaunchUnity.UseVisualStyleBackColor = true;
            this.btnLaunchUnity.Click += new System.EventHandler(this.btnLaunchUnity_Click);
            // 
            // btnLaunchHabboOrigins
            // 
            this.btnLaunchHabboOrigins.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunchHabboOrigins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchHabboOrigins.Location = new System.Drawing.Point(23, 206);
            this.btnLaunchHabboOrigins.Name = "btnLaunchHabboOrigins";
            this.btnLaunchHabboOrigins.Size = new System.Drawing.Size(237, 47);
            this.btnLaunchHabboOrigins.TabIndex = 10;
            this.btnLaunchHabboOrigins.Text = "Habbo: Origins";
            this.btnLaunchHabboOrigins.UseVisualStyleBackColor = true;
            this.btnLaunchHabboOrigins.Click += new System.EventHandler(this.btnLaunchHabboOrigins_Click);
            // 
            // btnLaunchHabbox
            // 
            this.btnLaunchHabbox.Enabled = false;
            this.btnLaunchHabbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunchHabbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchHabbox.Location = new System.Drawing.Point(23, 259);
            this.btnLaunchHabbox.Name = "btnLaunchHabbox";
            this.btnLaunchHabbox.Size = new System.Drawing.Size(237, 47);
            this.btnLaunchHabbox.TabIndex = 11;
            this.btnLaunchHabbox.Text = "Habbo X";
            this.btnLaunchHabbox.UseVisualStyleBackColor = true;
            this.btnLaunchHabbox.Click += new System.EventHandler(this.btnLaunchHabbox_Click);
            // 
            // btnLaunchOriginsUS
            // 
            this.btnLaunchOriginsUS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunchOriginsUS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchOriginsUS.Location = new System.Drawing.Point(23, 206);
            this.btnLaunchOriginsUS.Name = "btnLaunchOriginsUS";
            this.btnLaunchOriginsUS.Size = new System.Drawing.Size(68, 47);
            this.btnLaunchOriginsUS.TabIndex = 12;
            this.btnLaunchOriginsUS.Text = "US";
            this.btnLaunchOriginsUS.UseVisualStyleBackColor = true;
            this.btnLaunchOriginsUS.Click += new System.EventHandler(this.btnLaunchOriginsUS_Click);
            // 
            // btnLaunchOriginsBR
            // 
            this.btnLaunchOriginsBR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunchOriginsBR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchOriginsBR.Location = new System.Drawing.Point(107, 206);
            this.btnLaunchOriginsBR.Name = "btnLaunchOriginsBR";
            this.btnLaunchOriginsBR.Size = new System.Drawing.Size(68, 47);
            this.btnLaunchOriginsBR.TabIndex = 13;
            this.btnLaunchOriginsBR.Text = "BR";
            this.btnLaunchOriginsBR.UseVisualStyleBackColor = true;
            this.btnLaunchOriginsBR.Click += new System.EventHandler(this.btnLaunchOriginsBR_Click);
            // 
            // btnLaunchOriginsES
            // 
            this.btnLaunchOriginsES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLaunchOriginsES.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchOriginsES.Location = new System.Drawing.Point(192, 206);
            this.btnLaunchOriginsES.Name = "btnLaunchOriginsES";
            this.btnLaunchOriginsES.Size = new System.Drawing.Size(68, 47);
            this.btnLaunchOriginsES.TabIndex = 14;
            this.btnLaunchOriginsES.Text = "ES";
            this.btnLaunchOriginsES.UseVisualStyleBackColor = true;
            this.btnLaunchOriginsES.Click += new System.EventHandler(this.btnLaunchOriginsES_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(285, 358);
            this.Controls.Add(this.btnLaunchOriginsES);
            this.Controls.Add(this.btnLaunchOriginsBR);
            this.Controls.Add(this.btnLaunchOriginsUS);
            this.Controls.Add(this.btnLaunchHabbox);
            this.Controls.Add(this.btnLaunchHabboOrigins);
            this.Controls.Add(this.btnLaunchUnity);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchFlash;
        private System.Windows.Forms.CheckBox chkAutoLaunch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.CheckBox chkLaunchGearth;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblVersionLink;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnLaunchUnity;
        private System.Windows.Forms.Button btnLaunchHabboOrigins;
        private System.Windows.Forms.Button btnLaunchHabbox;
        private System.Windows.Forms.Button btnLaunchOriginsUS;
        private System.Windows.Forms.Button btnLaunchOriginsBR;
        private System.Windows.Forms.Button btnLaunchOriginsES;
    }
}