namespace InventrySystem
{
    partial class Stocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StockdataGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(280, 718);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.StockdataGridView);
            this.rightPanel.Size = new System.Drawing.Size(1050, 718);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.StockdataGridView, 0);
            // 
            // StockdataGridView
            // 
            this.StockdataGridView.AllowUserToAddRows = false;
            this.StockdataGridView.AllowUserToDeleteRows = false;
            this.StockdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.StockdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StockdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDGV,
            this.NameGV,
            this.BarcodeGV,
            this.ExpiryGV,
            this.BuyPriceGV,
            this.SellPriceGV,
            this.CategoryGV,
            this.StockGV,
            this.TotGV,
            this.StatusGV});
            this.StockdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockdataGridView.Location = new System.Drawing.Point(0, 119);
            this.StockdataGridView.Name = "StockdataGridView";
            this.StockdataGridView.ReadOnly = true;
            this.StockdataGridView.RowHeadersVisible = false;
            this.StockdataGridView.RowHeadersWidth = 51;
            this.StockdataGridView.RowTemplate.Height = 24;
            this.StockdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockdataGridView.Size = new System.Drawing.Size(1050, 599);
            this.StockdataGridView.TabIndex = 5;
            // 
            // ProductIDGV
            // 
            this.ProductIDGV.HeaderText = "ProductID";
            this.ProductIDGV.MinimumWidth = 6;
            this.ProductIDGV.Name = "ProductIDGV";
            this.ProductIDGV.ReadOnly = true;
            this.ProductIDGV.Visible = false;
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
            // BuyPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.BuyPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BuyPriceGV.HeaderText = "Buying Price";
            this.BuyPriceGV.MinimumWidth = 6;
            this.BuyPriceGV.Name = "BuyPriceGV";
            this.BuyPriceGV.ReadOnly = true;
            // 
            // SellPriceGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.SellPriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SellPriceGV.HeaderText = "Selling Price";
            this.SellPriceGV.MinimumWidth = 6;
            this.SellPriceGV.Name = "SellPriceGV";
            this.SellPriceGV.ReadOnly = true;
            // 
            // CategoryGV
            // 
            this.CategoryGV.HeaderText = "Category";
            this.CategoryGV.MinimumWidth = 6;
            this.CategoryGV.Name = "CategoryGV";
            this.CategoryGV.ReadOnly = true;
            // 
            // StockGV
            // 
            this.StockGV.HeaderText = "Stock";
            this.StockGV.MinimumWidth = 6;
            this.StockGV.Name = "StockGV";
            this.StockGV.ReadOnly = true;
            // 
            // TotGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.TotGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotGV.HeaderText = "Total Amount";
            this.TotGV.MinimumWidth = 6;
            this.TotGV.Name = "TotGV";
            this.TotGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.MinimumWidth = 6;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.ClientSize = new System.Drawing.Size(1330, 718);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StockdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}