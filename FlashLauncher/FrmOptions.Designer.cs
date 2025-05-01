
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkOriginsXL = new System.Windows.Forms.CheckBox();
            this.btnGEarthOriginsBrowse = new System.Windows.Forms.Button();
            this.txtGEarthOriginsPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIgnoreUpdateShockwave = new System.Windows.Forms.CheckBox();
            this.chkIgnoreUpdateHabbox = new System.Windows.Forms.CheckBox();
            this.chkIgnoreUpdateUnity = new System.Windows.Forms.CheckBox();
            this.chkIgnoreUpdateFlash = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoLaunchDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoLaunchDelay
            // 
            this.lblAutoLaunchDelay.AutoSize = true;
            this.lblAutoLaunchDelay.ForeColor = System.Drawing.Color.White;
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
            this.lblGEarthPath.ForeColor = System.Drawing.Color.White;
            this.lblGEarthPath.Location = new System.Drawing.Point(9, 43);
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
            this.btnGEarthBrowse.Location = new System.Drawing.Point(163, 38);
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
            this.chkLaunchGEarth.ForeColor = System.Drawing.Color.White;
            this.chkLaunchGEarth.Location = new System.Drawing.Point(11, 235);
            this.chkLaunchGEarth.Name = "chkLaunchGEarth";
            this.chkLaunchGEarth.Size = new System.Drawing.Size(104, 17);
            this.chkLaunchGEarth.TabIndex = 4;
            this.chkLaunchGEarth.Text = "Launch G-Earth:";
            this.chkLaunchGEarth.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(178, 345);
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
            this.chkIgnoreClientUpdates.ForeColor = System.Drawing.Color.White;
            this.chkIgnoreClientUpdates.Location = new System.Drawing.Point(11, 258);
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
            this.defaultOriginsServer.Location = new System.Drawing.Point(12, 185);
            this.defaultOriginsServer.Name = "defaultOriginsServer";
            this.defaultOriginsServer.Size = new System.Drawing.Size(241, 21);
            this.defaultOriginsServer.TabIndex = 7;
            this.defaultOriginsServer.SelectedIndexChanged += new System.EventHandler(this.defaultOriginsServer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Default Origins Server:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkOriginsXL
            // 
            this.chkOriginsXL.AutoSize = true;
            this.chkOriginsXL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOriginsXL.ForeColor = System.Drawing.Color.White;
            this.chkOriginsXL.Location = new System.Drawing.Point(11, 212);
            this.chkOriginsXL.Name = "chkOriginsXL";
            this.chkOriginsXL.Size = new System.Drawing.Size(77, 17);
            this.chkOriginsXL.TabIndex = 9;
            this.chkOriginsXL.Text = "Origins XL:";
            this.chkOriginsXL.UseVisualStyleBackColor = true;
            // 
            // btnGEarthOriginsBrowse
            // 
            this.btnGEarthOriginsBrowse.Location = new System.Drawing.Point(163, 107);
            this.btnGEarthOriginsBrowse.Name = "btnGEarthOriginsBrowse";
            this.btnGEarthOriginsBrowse.Size = new System.Drawing.Size(90, 23);
            this.btnGEarthOriginsBrowse.TabIndex = 12;
            this.btnGEarthOriginsBrowse.Text = "Browse";
            this.btnGEarthOriginsBrowse.UseVisualStyleBackColor = true;
            this.btnGEarthOriginsBrowse.Click += new System.EventHandler(this.btnGEarthOriginsBrowse_Click);
            // 
            // txtGEarthOriginsPath
            // 
            this.txtGEarthOriginsPath.Location = new System.Drawing.Point(12, 138);
            this.txtGEarthOriginsPath.Name = "txtGEarthOriginsPath";
            this.txtGEarthOriginsPath.Size = new System.Drawing.Size(241, 20);
            this.txtGEarthOriginsPath.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "G-Earth Origins Path (optional):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ignore Updates for:";
            // 
            // chkIgnoreUpdateShockwave
            // 
            this.chkIgnoreUpdateShockwave.AutoSize = true;
            this.chkIgnoreUpdateShockwave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreUpdateShockwave.ForeColor = System.Drawing.Color.White;
            this.chkIgnoreUpdateShockwave.Location = new System.Drawing.Point(34, 308);
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
            this.chkIgnoreUpdateHabbox.ForeColor = System.Drawing.Color.White;
            this.chkIgnoreUpdateHabbox.Location = new System.Drawing.Point(29, 325);
            this.chkIgnoreUpdateHabbox.Name = "chkIgnoreUpdateHabbox";
            this.chkIgnoreUpdateHabbox.Size = new System.Drawing.Size(63, 17);
            this.chkIgnoreUpdateHabbox.TabIndex = 15;
            this.chkIgnoreUpdateHabbox.Text = "Habbox";
            this.chkIgnoreUpdateHabbox.UseVisualStyleBackColor = true;
            this.chkIgnoreUpdateHabbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkIgnoreUpdateUnity
            // 
            this.chkIgnoreUpdateUnity.AutoSize = true;
            this.chkIgnoreUpdateUnity.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIgnoreUpdateUnity.ForeColor = System.Drawing.Color.White;
            this.chkIgnoreUpdateUnity.Location = new System.Drawing.Point(111, 308);
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
            this.chkIgnoreUpdateFlash.ForeColor = System.Drawing.Color.White;
            this.chkIgnoreUpdateFlash.Location = new System.Drawing.Point(110, 325);
            this.chkIgnoreUpdateFlash.Name = "chkIgnoreUpdateFlash";
            this.chkIgnoreUpdateFlash.Size = new System.Drawing.Size(51, 17);
            this.chkIgnoreUpdateFlash.TabIndex = 17;
            this.chkIgnoreUpdateFlash.Text = "Flash";
            this.chkIgnoreUpdateFlash.UseVisualStyleBackColor = true;
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(286, 380);
            this.Controls.Add(this.chkIgnoreUpdateFlash);
            this.Controls.Add(this.chkIgnoreUpdateUnity);
            this.Controls.Add(this.chkIgnoreUpdateHabbox);
            this.Controls.Add(this.chkIgnoreUpdateShockwave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGEarthOriginsBrowse);
            this.Controls.Add(this.txtGEarthOriginsPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkOriginsXL);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOriginsXL;
        private System.Windows.Forms.Button btnGEarthOriginsBrowse;
        private System.Windows.Forms.TextBox txtGEarthOriginsPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateShockwave;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateHabbox;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateUnity;
        private System.Windows.Forms.CheckBox chkIgnoreUpdateFlash;
    }
}