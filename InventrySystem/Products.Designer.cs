namespace InventrySystem
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductTxt = new System.Windows.Forms.TextBox();
            this.productErrorLbl = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeErrorLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpiryPicker = new System.Windows.Forms.DateTimePicker();
            this.ExpiryErrorLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoryErrorLbl = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.ProductdataGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1046, 56);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoryCB);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.CategoryErrorLbl);
            this.leftPanel.Controls.Add(this.ExpiryPicker);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.barcodeErrorLbl);
            this.leftPanel.Controls.Add(this.ProductTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.productErrorLbl);
            this.leftPanel.Controls.Add(this.ExpiryErrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(280, 718);
            this.leftPanel.Controls.SetChildIndex(this.ExpiryErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.ProductTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.ExpiryPicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.CategoryErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryCB, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.ProductdataGridView);
            this.rightPanel.Size = new System.Drawing.Size(1046, 718);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.ProductdataGridView, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1046, 63);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // ProductTxt
            // 
            this.ProductTxt.Location = new System.Drawing.Point(8, 150);
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(246, 27);
            this.ProductTxt.TabIndex = 3;
            // 
            // productErrorLbl
            // 
            this.productErrorLbl.AutoSize = true;
            this.productErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.productErrorLbl.Location = new System.Drawing.Point(104, 123);
            this.productErrorLbl.Name = "productErrorLbl";
            this.productErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.productErrorLbl.TabIndex = 13;
            this.productErrorLbl.Text = "*";
            this.productErrorLbl.Visible = false;
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(9, 203);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(246, 27);
            this.barcodeTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Barcode";
            // 
            // barcodeErrorLbl
            // 
            this.barcodeErrorLbl.AutoSize = true;
            this.barcodeErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.barcodeErrorLbl.Location = new System.Drawing.Point(104, 179);
            this.barcodeErrorLbl.Name = "barcodeErrorLbl";
            this.barcodeErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.barcodeErrorLbl.TabIndex = 16;
            this.barcodeErrorLbl.Text = "*";
            this.barcodeErrorLbl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expiry Date";
            // 
            // ExpiryPicker
            // 
            this.ExpiryPicker.CustomFormat = "dd-MMM-yyy";
            this.ExpiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpiryPicker.Location = new System.Drawing.Point(9, 258);
            this.ExpiryPicker.Name = "ExpiryPicker";
            this.ExpiryPicker.Size = new System.Drawing.Size(245, 27);
            this.ExpiryPicker.TabIndex = 18;
            // 
            // ExpiryErrorLbl
            // 
            this.ExpiryErrorLbl.AutoSize = true;
            this.ExpiryErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.ExpiryErrorLbl.Location = new System.Drawing.Point(104, 233);
            this.ExpiryErrorLbl.Name = "ExpiryErrorLbl";
            this.ExpiryErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.ExpiryErrorLbl.TabIndex = 19;
            this.ExpiryErrorLbl.Text = "*";
            this.ExpiryErrorLbl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Category";
            // 
            // CategoryErrorLbl
            // 
            this.CategoryErrorLbl.AutoSize = true;
            this.CategoryErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.CategoryErrorLbl.Location = new System.Drawing.Point(100, 289);
            this.CategoryErrorLbl.Name = "CategoryErrorLbl";
            this.CategoryErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.CategoryErrorLbl.TabIndex = 25;
            this.CategoryErrorLbl.Text = "*";
            this.CategoryErrorLbl.Visible = false;
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(8, 316);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(242, 28);
            this.categoryCB.TabIndex = 26;
            // 
            // ProductdataGridView
            // 
            this.ProductdataGridView.AllowUserToAddRows = false;
            this.ProductdataGridView.AllowUserToDeleteRows = false;
            this.ProductdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDGV,
            this.CategoryIDGV,
            this.NameGV,
            this.BarcodeGV,
            this.ExpiryGV,
            this.CategoryGV});
            this.ProductdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductdataGridView.Location = new System.Drawing.Point(0, 119);
            this.ProductdataGridView.Name = "ProductdataGridView";
            this.ProductdataGridView.ReadOnly = true;
            this.ProductdataGridView.RowHeadersVisible = false;
            this.ProductdataGridView.RowHeadersWidth = 51;
            this.ProductdataGridView.RowTemplate.Height = 24;
            this.ProductdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductdataGridView.Size = new System.Drawing.Size(1046, 599);
            this.ProductdataGridView.TabIndex = 4;
            this.ProductdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductdataGridView_CellClick);
            // 
            // ProductIDGV
            // 
            this.ProductIDGV.HeaderText = "ProductID";
            this.ProductIDGV.MinimumWidth = 6;
            this.ProductIDGV.Name = "ProductIDGV";
            this.ProductIDGV.ReadOnly = true;
            this.ProductIDGV.Visible = false;
            // 
            // CategoryIDGV
            // 
            this.CategoryIDGV.HeaderText = "CategoryID";
            this.CategoryIDGV.MinimumWidth = 6;
            this.CategoryIDGV.Name = "CategoryIDGV";
            this.CategoryIDGV.ReadOnly = true;
            this.CategoryIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 6;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // BarcodeGV
            // 
            this.BarcodeGV.HeaderText = "Barcode";
            this.BarcodeGV.MinimumWidth = 6;
            this.BarcodeGV.Name = "BarcodeGV";
            this.BarcodeGV.ReadOnly = true;
            // 
            // ExpiryGV
            // 
            this.ExpiryGV.HeaderText = "Expiry";
            this.ExpiryGV.MinimumWidth = 6;
            this.ExpiryGV.Name = "ExpiryGV";
            this.ExpiryGV.ReadOnly = true;
            // 
            // CategoryGV
            // 
            this.CategoryGV.HeaderText = "Category";
            this.CategoryGV.MinimumWidth = 6;
            this.CategoryGV.Name = "CategoryGV";
            this.CategoryGV.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.ClientSize = new System.Drawing.Size(1330, 718);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ProductTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productErrorLbl;
        private System.Windows.Forms.DateTimePicker ExpiryPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label barcodeErrorLbl;
        private System.Windows.Forms.Label ExpiryErrorLbl;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CategoryErrorLbl;
        private System.Windows.Forms.DataGridView ProductdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGV;
    }
}