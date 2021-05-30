
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
            this.lblAutoLaunchDelay = new System.Windows.Forms.Label();
            this.numAutoLaunchDelay = new System.Windows.Forms.NumericUpDown();
            this.lblGEarthPath = new System.Windows.Forms.Label();
            this.txtGEarthPath = new System.Windows.Forms.TextBox();
            this.btnGEarthBrowse = new System.Windows.Forms.Button();
            this.chkLaunchGEarth = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.chkIgnoreClientUpdates = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoLaunchDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoLaunchDelay
            // 
            this.lblAutoLaunchDelay.AutoSize = true;
            this.lblAutoLaunchDelay.Location = new System.Drawing.Point(12, 14);
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
            this.numAutoLaunchDelay.Size = new System.Drawing.Size(90, 20);
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
            this.lblGEarthPath.Location = new System.Drawing.Point(12, 43);
            this.lblGEarthPath.Name = "lblGEarthPath";
            this.lblGEarthPath.Size = new System.Drawing.Size(71, 13);
            this.lblGEarthPath.TabIndex = 2;
            this.lblGEarthPath.Text = "G-Earth Path:";
            // 
            // txtGEarthPath
            // 
            this.txtGEarthPath.Location = new System.Drawing.Point(12, 69);
            this.txtGEarthPath.Name = "txtGEarthPath";
            this.txtGEarthPath.Size = new System.Drawing.Size(193, 20);
            this.txtGEarthPath.TabIndex = 2;
            // 
            // btnGEarthBrowse
            // 
            this.btnGEarthBrowse.Location = new System.Drawing.Point(115, 38);
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
            this.chkLaunchGEarth.Location = new System.Drawing.Point(12, 95);
            this.chkLaunchGEarth.Name = "chkLaunchGEarth";
            this.chkLaunchGEarth.Size = new System.Drawing.Size(104, 17);
            this.chkLaunchGEarth.TabIndex = 4;
            this.chkLaunchGEarth.Text = "Launch G-Earth:";
            this.chkLaunchGEarth.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 141);
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
            this.chkIgnoreClientUpdates.Location = new System.Drawing.Point(12, 118);
            this.chkIgnoreClientUpdates.Name = "chkIgnoreClientUpdates";
            this.chkIgnoreClientUpdates.Size = new System.Drawing.Size(131, 17);
            this.chkIgnoreClientUpdates.TabIndex = 6;
            this.chkIgnoreClientUpdates.Text = "Ignore Client Updates:";
            this.chkIgnoreClientUpdates.UseVisualStyleBackColor = true;
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 172);
            this.Controls.Add(this.chkIgnoreClientUpdates);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkLaunchGEarth);
            this.Controls.Add(this.btnGEarthBrowse);
            this.Controls.Add(this.txtGEarthPath);
            this.Controls.Add(this.lblGEarthPath);
            this.Controls.Add(this.numAutoLaunchDelay);
            this.Controls.Add(this.lblAutoLaunchDelay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOptions";
            this.Text = "HabboLauncher: Options";
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
    }
}