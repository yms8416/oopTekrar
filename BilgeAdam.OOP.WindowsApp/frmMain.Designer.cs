﻿namespace BilgeAdam.OOP.WindowsApp
{
    partial class frmMain
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
            this.btnGetOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetOn
            // 
            this.btnGetOn.Location = new System.Drawing.Point(12, 12);
            this.btnGetOn.Name = "btnGetOn";
            this.btnGetOn.Size = new System.Drawing.Size(143, 35);
            this.btnGetOn.TabIndex = 0;
            this.btnGetOn.Text = "Arabaya Yolcuları Al";
            this.btnGetOn.UseVisualStyleBackColor = true;
            this.btnGetOn.Click += new System.EventHandler(this.btnGetOn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 337);
            this.Controls.Add(this.btnGetOn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Can Taşımacılık";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetOn;
    }
}

