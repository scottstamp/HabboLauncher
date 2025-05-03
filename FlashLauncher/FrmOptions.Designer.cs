
namespace HabboLauncher
{
    partial class FrmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
            this.lblAutoLaunchDelay = new System.Windows.Forms.Label();
            this.numAutoLaunchDelay = new System.Windows.Forms.NumericUpDown();
            this.lblGEarthPath = new System.Windows.Forms.Label();
            this.txtGEarthPath = new System.Windows.Forms.TextBox();
            this.btnGEarthBrowse = new System.Windows.Forms.Button();
            this.chkLaunchGEarth = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.chkIgnoreClientUpdates = new System.Windows.Forms.CheckBox();
            this.defaultOriginsServer = new System.Windows.Forms.ComboBox();
            this.lblDefaultOriginsServer = new System.Windows.Forms.Label();
            this.chkOriginsXL = new System.Windows.Forms.CheckBox();
            this.btnGEarthOriginsBrowse = new System.Windows.Forms.Button();
            this.txtGEarthOriginsPath = new System.Windows.Forms.TextBox();
            this.lblGEarthOriginsPath = new System.Windows.Forms.Label();
            this.lblIgnoreUpdatesFor = new System.Windows.Forms.Label();
            this.chkIgnoreUpdateShockwave = new System.Windows.Forms.CheckBox();
            this.chkIgnoreUpdateHabbox = new System.Windows.Forms.CheckBox();
            this.chkIgnoreUpdateUnity = new System.Windows.Forms.CheckBox();
            this.chkIgnoreUpdateFlash = new System.Windows.Forms.CheckBox();
            this.txtCustomSwfFlash = new System.Windows.Forms.TextBox();
            this.lblCustomSwf = new System.Windows.Forms.Label();
            this.chkUseCustomSwf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoLaunchDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoLaunchDelay
            // 
            this.lblAutoLaunchDelay.AutoSize = true;
            this.lblAutoLaunchDelay.Location = new System.Drawing.Point(9, 14);
            this.lblAutoLaunchDelay.Name = "lblAutoLaunchDelay";
            this.lblAutoLaunchDelay.Size = new System.Drawing.Size(97, 13);
            this.lblAutoLaunchDelay.TabIndex = 0;
            this.lblAutoLaunchDelay.Text = "Auto-launch Delay:";
            // 
            // numAutoLaunchDelay
            // 
            this.numAutoLaunchDelay.Location = new System.Drawing.Point(115, 12);
            this.numAutoLaunchDelay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAutoLaunchDelay.Name = "numAutoLaunchDelay";
            this.numAutoLaunchDelay.Size = new System.Drawing.Size(138, 20);
            this.numAutoLaunchDelay.TabIndex = 1;
            this.numAutoLaunchDelay.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblGEarthPath
            // 
            this.lblGEarthPath.AutoSize = true;
            this.lblGEarthPath.Location = new System.Drawing.Point(8, 48);
            this.lblGEarthPath.Name = "lblGEarthPath";
            this.lblGEarthPath.Size = new System.Drawing.Size(71, 13);
            this.lblGEarthPath.TabIndex = 2;
            this.lblGEarthPath.Text = "G-Earth Path:";
            // 
            // txtGEarthPath
            // 
            this.txtGEarthPath.Location = new System.Drawing.Point(12, 69);
            this.txtGEarthPath.Name = "txtGEarthPath";
            this.txtGEarthPath.Size = new System.Drawing.Size(241, 20);
            this.txtGEarthPath.TabIndex = 2;
            // 
            // btnGEarthBrowse
            // 
            this.btnGEarthBrowse.Location = new System.Drawing.Point(163, 43);
            this.btnGEarthBrowse.Name = "btnGEarthBrowse";
            this.btnGEarthBrowse.Size = new System.Drawing.Size(90, 23);
            this.btnGEarthBrowse.TabIndex = 3;
            this.btnGEarthBrowse.Text = "Browse";
            this.btnGEarthBrowse.UseVisualStyleBackColor = true;
            this.btnGEarthBrowse.Click += new System.EventHandler(this.btnGEarthBrowse_Click);
            // 
            // chkLaunchGEarth
            // 
            this.chkLaunchGEarth.AutoSize = true;
            this.chkLaunchGEarth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLaunchGEarth.Location = new System.Drawing.Point(11, 271);
            this.chkLaunchGEarth.Name = "chkLaunchGEarth";
            this.chkLaunchGEarth.Size = new System.Drawing.Size(104, 17);
            this.chkLaunchGEarth.TabIndex = 4;
            this.chkLaunchGEarth.Text = "Launch G-Earth:";
            this.chkLaunchGEarth.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "G-Earth Executable|G-Earth.exe";
            // 
            // chkIgnoreClientUpdates
            // 
            this.chkIgnoreClientUpdates.AutoSize = true;
            this.chkIgnoreClientUpdates.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreClientUpdates.Location = new System.Drawing.Point(11, 294);
            this.chkIgnoreClientUpdates.Name = "chkIgnoreClientUpdates";
            this.chkIgnoreClientUpdates.Size = new System.Drawing.Size(145, 17);
            this.chkIgnoreClientUpdates.TabIndex = 6;
            this.chkIgnoreClientUpdates.Text = "Ignore All Client Updates:";
            this.chkIgnoreClientUpdates.UseVisualStyleBackColor = true;
            // 
            // defaultOriginsServer
            // 
            this.defaultOriginsServer.FormattingEnabled = true;
            this.defaultOriginsServer.Items.AddRange(new object[] {
            "None (You will select)",
            "English",
            "Portuguese",
            "Spanish"});
            this.defaultOriginsServer.Location = new System.Drawing.Point(12, 221);
            this.defaultOriginsServer.Name = "defaultOriginsServer";
            this.defaultOriginsServer.Size = new System.Drawing.Size(241, 21);
            this.defaultOriginsServer.TabIndex = 7;
            // 
            // lblDefaultOriginsServer
            // 
            this.lblDefaultOriginsServer.AutoSize = true;
            this.lblDefaultOriginsServer.Location = new System.Drawing.Point(9, 205);
            this.lblDefaultOriginsServer.Name = "lblDefaultOriginsServer";
            this.lblDefaultOriginsServer.Size = new System.Drawing.Size(113, 13);
            this.lblDefaultOriginsServer.TabIndex = 8;
            this.lblDefaultOriginsServer.Text = "Default Origins Server:";
            this.lblDefaultOriginsServer.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkOriginsXL
            // 
            this.chkOriginsXL.AutoSize = true;
            this.chkOriginsXL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOriginsXL.Location = new System.Drawing.Point(11, 248);
            this.chkOriginsXL.Name = "chkOriginsXL";
            this.chkOriginsXL.Size = new System.Drawing.Size(77, 17);
            this.chkOriginsXL.TabIndex = 9;
            this.chkOriginsXL.Text = "Origins XL:";
            this.chkOriginsXL.UseVisualStyleBackColor = true;
            // 
            // btnGEarthOriginsBrowse
            // 
            this.btnGEarthOriginsBrowse.Location = new System.Drawing.Point(163, 148);
            this.btnGEarthOriginsBrowse.Name = "btnGEarthOriginsBrowse";
            this.btnGEarthOriginsBrowse.Size = new System.Drawing.Size(90, 23);
            this.btnGEarthOriginsBrowse.TabIndex = 12;
            this.btnGEarthOriginsBrowse.Text = "Browse";
            this.btnGEarthOriginsBrowse.UseVisualStyleBackColor = true;
            this.btnGEarthOriginsBrowse.Click += new System.EventHandler(this.btnGEarthOriginsBrowse_Click);
            // 
            // txtGEarthOriginsPath
            // 
            this.txtGEarthOriginsPath.Location = new System.Drawing.Point(12, 174);
            this.txtGEarthOriginsPath.Name = "txtGEarthOriginsPath";
            this.txtGEarthOriginsPath.Size = new System.Drawing.Size(241, 20);
            this.txtGEarthOriginsPath.TabIndex = 10;
            // 
            // lblGEarthOriginsPath
            // 
            this.lblGEarthOriginsPath.AutoSize = true;
            this.lblGEarthOriginsPath.Location = new System.Drawing.Point(9, 153);
            this.lblGEarthOriginsPath.Name = "lblGEarthOriginsPath";
            this.lblGEarthOriginsPath.Size = new System.Drawing.Size(152, 13);
            this.lblGEarthOriginsPath.TabIndex = 11;
            this.lblGEarthOriginsPath.Text = "G-Earth Origins Path (optional):";
            // 
            // lblIgnoreUpdatesFor
            // 
            this.lblIgnoreUpdatesFor.AutoSize = true;
            this.lblIgnoreUpdatesFor.Location = new System.Drawing.Point(13, 322);
            this.lblIgnoreUpdatesFor.Name = "lblIgnoreUpdatesFor";
            this.lblIgnoreUpdatesFor.Size = new System.Drawing.Size(98, 13);
            this.lblIgnoreUpdatesFor.TabIndex = 13;
            this.lblIgnoreUpdatesFor.Text = "Ignore Updates for:";
            // 
            // chkIgnoreUpdateShockwave
            // 
            this.chkIgnoreUpdateShockwave.AutoSize = true;
            this.chkIgnoreUpdateShockwave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreUpdateShockwave.Location = new System.Drawing.Point(34, 344);
            this.chkIgnoreUpdateShockwave.Name = "chkIgnoreUpdateShockwave";
            this.chkIgnoreUpdateShockwave.Size = new System.Drawing.Size(58, 17);
            this.chkIgnoreUpdateShockwave.TabIndex = 14;
            this.chkIgnoreUpdateShockwave.Text = "Origins";
            this.chkIgnoreUpdateShockwave.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreUpdateHabbox
            // 
            this.chkIgnoreUpdateHabbox.AutoSize = true;
            this.chkIgnoreUpdateHabbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreUpdateHabbox.Location = new System.Drawing.Point(29, 361);
            this.chkIgnoreUpdateHabbox.Name = "chkIgnoreUpdateHabbox";
            this.chkIgnoreUpdateHabbox.Size = new System.Drawing.Size(63, 17);
            this.chkIgnoreUpdateHabbox.TabIndex = 15;
            this.chkIgnoreUpdateHabbox.Text = "Habbox";
            this.chkIgnoreUpdateHabbox.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreUpdateUnity
            // 
            this.chkIgnoreUpdateUnity.AutoSize = true;
            this.chkIgnoreUpdateUnity.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreUpdateUnity.Location = new System.Drawing.Point(111, 344);
            this.chkIgnoreUpdateUnity.Name = "chkIgnoreUpdateUnity";
            this.chkIgnoreUpdateUnity.Size = new System.Drawing.Size(50, 17);
            this.chkIgnoreUpdateUnity.TabIndex = 16;
            this.chkIgnoreUpdateUnity.Text = "Unity";
            this.chkIgnoreUpdateUnity.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreUpdateFlash
            // 
            this.chkIgnoreUpdateFlash.AutoSize = true;
            this.chkIgnoreUpdateFlash.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreUpdateFlash.Location = new System.Drawing.Point(110, 361);
            this.chkIgnoreUpdateFlash.Name = "chkIgnoreUpdateFlash";
            this.chkIgnoreUpdateFlash.Size = new System.Drawing.Size(51, 17);
            this.chkIgnoreUpdateFlash.TabIndex = 17;
            this.chkIgnoreUpdateFlash.Text = "Flash";
            this.chkIgnoreUpdateFlash.UseVisualStyleBackColor = true;
            // 
            // txtCustomSwfFlash
            // 
            this.txtCustomSwfFlash.Location = new System.Drawing.Point(11, 117);
            this.txtCustomSwfFlash.Name = "txtCustomSwfFlash";
            this.txtCustomSwfFlash.Size = new System.Drawing.Size(241, 20);
            this.txtCustomSwfFlash.TabIndex = 18;
            this.txtCustomSwfFlash.Leave += new System.EventHandler(this.txtCustomSwfFlash_Leave);
            // 
            // lblCustomSwf
            // 
            this.lblCustomSwf.AutoSize = true;
            this.lblCustomSwf.Location = new System.Drawing.Point(8, 101);
            this.lblCustomSwf.Name = "lblCustomSwf";
            this.lblCustomSwf.Size = new System.Drawing.Size(72, 13);
            this.lblCustomSwf.TabIndex = 19;
            this.lblCustomSwf.Text = "Custom SWF:";
            // 
            // chkUseCustomSwf
            // 
            this.chkUseCustomSwf.AutoSize = true;
            this.chkUseCustomSwf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUseCustomSwf.Location = new System.Drawing.Point(184, 100);
            this.chkUseCustomSwf.Name = "chkUseCustomSwf";
            this.chkUseCustomSwf.Size = new System.Drawing.Size(68, 17);
            this.chkUseCustomSwf.TabIndex = 20;
            this.chkUseCustomSwf.Text = "Enabled:";
            this.chkUseCustomSwf.UseVisualStyleBackColor = true;
            this.chkUseCustomSwf.CheckedChanged += new System.EventHandler(this.chkUseCustomSwf_CheckedChanged);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 433);
            this.Controls.Add(this.chkUseCustomSwf);
            this.Controls.Add(this.lblCustomSwf);
            this.Controls.Add(this.txtCustomSwfFlash);
            this.Controls.Add(this.chkIgnoreUpdateFlash);
            this.Controls.Add(this.chkIgnoreUpdateUnity);
            this.Controls.Add(this.chkIgnoreUpdateHabbox);
            this.Controls.Add(this.chkIgnoreUpdateShockwave);
            this.Controls.Add(this.lblIgnoreUpdatesFor);
            this.Controls.Add(this.btnGEarthOriginsBrowse);
            this.Controls.Add(this.txtGEarthOriginsPath);
            this.Controls.Add(this.lblGEarthOriginsPath);
            this.Controls.Add(this.chkOriginsXL);
            this.Controls.Add(this.lblDefaultOriginsServer);
            this.Controls.Add(this.defaultOriginsServer);
            this.Controls.Add(this.chkIgnoreClientUpdates);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkLaunchGEarth);
            this.Controls.Add(this.btnGEarthBrowse);
            this.Controls.Add(this.txtGEarthPath);
            this.Controls.Add(this.lblGEarthPath);
            this.Controls.Add(this.numAutoLaunchDelay);
            this.Controls.Add(this.lblAutoLaunchDelay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOptions";
            this.Text = "HabboLauncher: Options";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAutoLaunchDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutoLaunchDelay;
        private System.Windows.Forms.NumericUpDown numAutoLaunchDelay;
        private System.Windows.Forms.Label lblGEarthPath;
        private System.Windows.Forms.TextBox txtGEarthPath;
        private System.Windows.Forms.Button btnGEarthBrowse;
        private System.Windows.Forms.CheckBox chkLaunchGEarth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.CheckBox chkIgnoreClientUpdates;
        private System.Windows.Forms.ComboBox defaultOriginsServer;
        private System.Windows.Forms.Label lblDefaultOriginsServer;
        private System.Windows.Forms.CheckBox chkOriginsXL;
        private System.Windows.Forms.Button btnGEarthOriginsBrowse;
        private System.Windows.Forms.TextBox txtGEarthOriginsPath;
        private System.Windows.Forms.Label lblGEarthOriginsPath;
        private System.Windows.Forms.Label lblIgnoreUpdatesFor;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateShockwave;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateHabbox;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateUnity;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateFlash;
        private System.Windows.Forms.TextBox txtCustomSwfFlash;
        private System.Windows.Forms.Label lblCustomSwf;
        private System.Windows.Forms.CheckBox chkUseCustomSwf;
    }
}