namespace InventrySystem
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SupplierBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.PurchaseInvoiceBtn = new System.Windows.Forms.Button();
            this.StockBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.CatogoryBtn = new System.Windows.Forms.Button();
            this.proPricingBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(280, 719);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Location = new System.Drawing.Point(280, 0);
            this.rightPanel.Size = new System.Drawing.Size(1463, 719);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1463, 80);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(280, 80);
            // 
            // UserDisplayLbl
            // 
            this.UserDisplayLbl.Size = new System.Drawing.Size(960, 80);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.SupplierBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SalesBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PurchaseInvoiceBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.StockBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CatogoryBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.proPricingBtn, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1463, 639);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SupplierBtn
            // 
            this.SupplierBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SupplierBtn.FlatAppearance.BorderSize = 2;
            this.SupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierBtn.Location = new System.Drawing.Point(295, 130);
            this.SupplierBtn.Name = "SupplierBtn";
            this.SupplierBtn.Size = new System.Drawing.Size(286, 121);
            this.SupplierBtn.TabIndex = 7;
            this.SupplierBtn.Text = "Suppliers";
            this.SupplierBtn.UseVisualStyleBackColor = true;
            this.SupplierBtn.Click += new System.EventHandler(this.SupplierBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SalesBtn.FlatAppearance.BorderSize = 2;
            this.SalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBtn.Location = new System.Drawing.Point(1171, 3);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(289, 121);
            this.SalesBtn.TabIndex = 4;
            this.SalesBtn.Text = "Sales";
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // PurchaseInvoiceBtn
            // 
            this.PurchaseInvoiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchaseInvoiceBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.PurchaseInvoiceBtn.FlatAppearance.BorderSize = 2;
            this.PurchaseInvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseInvoiceBtn.Location = new System.Drawing.Point(879, 3);
            this.PurchaseInvoiceBtn.Name = "PurchaseInvoiceBtn";
            this.PurchaseInvoiceBtn.Size = new System.Drawing.Size(286, 121);
            this.PurchaseInvoiceBtn.TabIndex = 3;
            this.PurchaseInvoiceBtn.Text = "Purchase Invoice";
            this.PurchaseInvoiceBtn.UseVisualStyleBackColor = true;
            this.PurchaseInvoiceBtn.Click += new System.EventHandler(this.PurchaseInvoiceBtn_Click);
            // 
            // StockBtn
            // 
            this.StockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.StockBtn.FlatAppearance.BorderSize = 2;
            this.StockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockBtn.Location = new System.Drawing.Point(587, 3);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(286, 121);
            this.StockBtn.TabIndex = 2;
            this.StockBtn.Text = "Stock";
            this.StockBtn.UseVisualStyleBackColor = true;
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.productBtn.FlatAppearance.BorderSize = 2;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Location = new System.Drawing.Point(295, 3);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(286, 121);
            this.productBtn.TabIndex = 1;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Location = new System.Drawing.Point(3, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(286, 121);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // CatogoryBtn
            // 
            this.CatogoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatogoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CatogoryBtn.FlatAppearance.BorderSize = 2;
            this.CatogoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatogoryBtn.Location = new System.Drawing.Point(3, 130);
            this.CatogoryBtn.Name = "CatogoryBtn";
            this.CatogoryBtn.Size = new System.Drawing.Size(286, 121);
            this.CatogoryBtn.TabIndex = 6;
            this.CatogoryBtn.Text = "Categories";
            this.CatogoryBtn.UseVisualStyleBackColor = true;
            this.CatogoryBtn.Click += new System.EventHandler(this.CatogoryBtn_Click);
            // 
            // proPricingBtn
            // 
            this.proPricingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proPricingBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.proPricingBtn.FlatAppearance.BorderSize = 2;
            this.proPricingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proPricingBtn.Location = new System.Drawing.Point(587, 130);
            this.proPricingBtn.Name = "proPricingBtn";
            this.proPricingBtn.Size = new System.Drawing.Size(286, 121);
            this.proPricingBtn.TabIndex = 8;
            this.proPricingBtn.Text = "Product Price";
            this.proPricingBtn.UseVisualStyleBackColor = true;
            this.proPricingBtn.Click += new System.EventHandler(this.proPricingBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 719);
            this.IsMdiContainer = false;
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button PurchaseInvoiceBtn;
        private System.Windows.Forms.Button StockBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button CatogoryBtn;
        private System.Windows.Forms.Button SupplierBtn;
        private System.Windows.Forms.Button proPricingBtn;
    }
}