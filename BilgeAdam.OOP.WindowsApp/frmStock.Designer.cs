namespace BilgeAdam.OOP.WindowsApp
{
    partial class frmStock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.prgProduct = new System.Windows.Forms.PropertyGrid();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddToStock = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 21);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(528, 200);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.prgProduct);
            this.groupBox2.Location = new System.Drawing.Point(558, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçili Ürün";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(105, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // prgProduct
            // 
            this.prgProduct.HelpVisible = false;
            this.prgProduct.Location = new System.Drawing.Point(6, 21);
            this.prgProduct.Name = "prgProduct";
            this.prgProduct.Size = new System.Drawing.Size(224, 175);
            this.prgProduct.TabIndex = 0;
            this.prgProduct.ToolbarVisible = false;
            this.prgProduct.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgProduct_PropertyValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(166, 245);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Yeni Ürün";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(12, 247);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(148, 21);
            this.cmbType.TabIndex = 5;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(12, 274);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(148, 22);
            this.nudAmount.TabIndex = 6;
            // 
            // btnAddToStock
            // 
            this.btnAddToStock.Location = new System.Drawing.Point(166, 274);
            this.btnAddToStock.Name = "btnAddToStock";
            this.btnAddToStock.Size = new System.Drawing.Size(106, 23);
            this.btnAddToStock.TabIndex = 7;
            this.btnAddToStock.Text = "Stoğa Ekle";
            this.btnAddToStock.UseVisualStyleBackColor = true;
            this.btnAddToStock.Click += new System.EventHandler(this.btnAddToStock_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(166, 303);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(106, 23);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sat";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 337);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnAddToStock);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.Text = "Ürün Takibi";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PropertyGrid prgProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnAddToStock;
        private System.Windows.Forms.Button btnSell;
    }
}