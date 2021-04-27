﻿
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
            this.btnLaunchFlash = new System.Windows.Forms.Button();
            this.btnLaunchUnity = new System.Windows.Forms.Button();
            this.chkAutoLaunch = new System.Windows.Forms.CheckBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLaunchFlash
            // 
            this.btnLaunchFlash.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchFlash.Image")));
            this.btnLaunchFlash.Location = new System.Drawing.Point(20, 38);
            this.btnLaunchFlash.Name = "btnLaunchFlash";
            this.btnLaunchFlash.Size = new System.Drawing.Size(100, 100);
            this.btnLaunchFlash.TabIndex = 0;
            this.btnLaunchFlash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLaunchFlash.UseVisualStyleBackColor = true;
            this.btnLaunchFlash.Click += new System.EventHandler(this.btnLaunchFlash_Click);
            // 
            // btnLaunchUnity
            // 
            this.btnLaunchUnity.Image = ((System.Drawing.Image)(resources.GetObject("btnLaunchUnity.Image")));
            this.btnLaunchUnity.Location = new System.Drawing.Point(136, 38);
            this.btnLaunchUnity.Name = "btnLaunchUnity";
            this.btnLaunchUnity.Size = new System.Drawing.Size(100, 100);
            this.btnLaunchUnity.TabIndex = 1;
            this.btnLaunchUnity.UseVisualStyleBackColor = true;
            this.btnLaunchUnity.Click += new System.EventHandler(this.btnLaunchUnity_Click);
            // 
            // chkAutoLaunch
            // 
            this.chkAutoLaunch.AutoSize = true;
            this.chkAutoLaunch.Location = new System.Drawing.Point(12, 148);
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
            this.txtCode.Size = new System.Drawing.Size(232, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 174);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.chkAutoLaunch);
            this.Controls.Add(this.btnLaunchUnity);
            this.Controls.Add(this.btnLaunchFlash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Habbo Launcher";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchFlash;
        private System.Windows.Forms.Button btnLaunchUnity;
        private System.Windows.Forms.CheckBox chkAutoLaunch;
        private System.Windows.Forms.TextBox txtCode;
    }
}