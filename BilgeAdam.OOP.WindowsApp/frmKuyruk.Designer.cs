namespace BilgeAdam.OOP.WindowsApp
{
    partial class frmKuyruk
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
            this.btnGetCustomer1 = new System.Windows.Forms.Button();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.btnGetCustomer2 = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblCalled = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetCustomer1
            // 
            this.btnGetCustomer1.Location = new System.Drawing.Point(21, 142);
            this.btnGetCustomer1.Name = "btnGetCustomer1";
            this.btnGetCustomer1.Size = new System.Drawing.Size(75, 23);
            this.btnGetCustomer1.TabIndex = 0;
            this.btnGetCustomer1.Text = "Çağır";
            this.btnGetCustomer1.UseVisualStyleBackColor = true;
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(60, 120);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(75, 23);
            this.btnGetOrder.TabIndex = 1;
            this.btnGetOrder.Text = "Sıra Al";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            // 
            // btnGetCustomer2
            // 
            this.btnGetCustomer2.Location = new System.Drawing.Point(106, 142);
            this.btnGetCustomer2.Name = "btnGetCustomer2";
            this.btnGetCustomer2.Size = new System.Drawing.Size(75, 23);
            this.btnGetCustomer2.TabIndex = 2;
            this.btnGetCustomer2.Text = "Çağır";
            this.btnGetCustomer2.UseVisualStyleBackColor = true;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrder.Location = new System.Drawing.Point(83, 9);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(33, 37);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "0";
            // 
            // lblCalled
            // 
            this.lblCalled.AutoSize = true;
            this.lblCalled.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalled.Location = new System.Drawing.Point(84, 31);
            this.lblCalled.Name = "lblCalled";
            this.lblCalled.Size = new System.Drawing.Size(33, 37);
            this.lblCalled.TabIndex = 3;
            this.lblCalled.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sıradaki";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOrder);
            this.panel1.Controls.Add(this.btnGetOrder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 195);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnGetCustomer1);
            this.panel2.Controls.Add(this.btnGetCustomer2);
            this.panel2.Controls.Add(this.lblCalled);
            this.panel2.Location = new System.Drawing.Point(247, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 195);
            this.panel2.TabIndex = 6;
            // 
            // frmKuyruk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 229);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKuyruk";
            this.Text = "SıraSis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomer1;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Button btnGetCustomer2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCalled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}