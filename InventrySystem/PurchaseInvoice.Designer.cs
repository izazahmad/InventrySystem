namespace InventrySystem
{
    partial class PurchaseInvoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.ProductTxt = new System.Windows.Forms.TextBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PerUnitTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PurchasedataGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerUnitGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TotLbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.GrossLbl = new System.Windows.Forms.Label();
            this.SupplierErrorLbl = new System.Windows.Forms.Label();
            this.BarcodeErrorLbl = new System.Windows.Forms.Label();
            this.ProductErrorLbl = new System.Windows.Forms.Label();
            this.PerUnitErrorLbl = new System.Windows.Forms.Label();
            this.QuantityErrorLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.TotLbl);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.CartBtn);
            this.leftPanel.Controls.Add(this.PerUnitTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.QuantityTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.ProductTxt);
            this.leftPanel.Controls.Add(this.BarcodeTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.SupplierDD);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.SupplierErrorLbl);
            this.leftPanel.Controls.Add(this.BarcodeErrorLbl);
            this.leftPanel.Controls.Add(this.ProductErrorLbl);
            this.leftPanel.Controls.Add(this.PerUnitErrorLbl);
            this.leftPanel.Controls.Add(this.QuantityErrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(280, 769);
            this.leftPanel.Controls.SetChildIndex(this.QuantityErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.PerUnitErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.ProductErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.BarcodeErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.SupplierErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.SupplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.BarcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.ProductTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.QuantityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.PerUnitTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.CartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.TotLbl, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.PurchasedataGridView);
            this.rightPanel.Size = new System.Drawing.Size(1046, 769);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.PurchasedataGridView, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // panel1
            // 
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Supplier";
            // 
            // SupplierDD
            // 
            this.SupplierDD.FormattingEnabled = true;
            this.SupplierDD.Location = new System.Drawing.Point(8, 147);
            this.SupplierDD.Name = "SupplierDD";
            this.SupplierDD.Size = new System.Drawing.Size(255, 28);
            this.SupplierDD.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barcode";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Location = new System.Drawing.Point(8, 201);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(255, 27);
            this.BarcodeTxt.TabIndex = 1;
            this.BarcodeTxt.TextChanged += new System.EventHandler(this.BarcodeTxt_TextChanged);
            this.BarcodeTxt.Validated += new System.EventHandler(this.BarcodeTxt_Validated);
            // 
            // ProductTxt
            // 
            this.ProductTxt.Location = new System.Drawing.Point(8, 254);
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(255, 27);
            this.ProductTxt.TabIndex = 2;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(8, 364);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(255, 27);
            this.QuantityTxt.TabIndex = 4;
            this.QuantityTxt.TextChanged += new System.EventHandler(this.QuantityTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // PerUnitTxt
            // 
            this.PerUnitTxt.Location = new System.Drawing.Point(8, 308);
            this.PerUnitTxt.Name = "PerUnitTxt";
            this.PerUnitTxt.Size = new System.Drawing.Size(255, 27);
            this.PerUnitTxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Per Unit Price";
            // 
            // PurchasedataGridView
            // 
            this.PurchasedataGridView.AllowUserToAddRows = false;
            this.PurchasedataGridView.AllowUserToDeleteRows = false;
            this.PurchasedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchasedataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PurchasedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchasedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PurchasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDGV,
            this.NameGV,
            this.QuantityGV,
            this.PerUnitGV,
            this.TotGV,
            this.DeleteGV});
            this.PurchasedataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurchasedataGridView.Location = new System.Drawing.Point(0, 119);
            this.PurchasedataGridView.Name = "PurchasedataGridView";
            this.PurchasedataGridView.ReadOnly = true;
            this.PurchasedataGridView.RowHeadersVisible = false;
            this.PurchasedataGridView.RowHeadersWidth = 51;
            this.PurchasedataGridView.RowTemplate.Height = 24;
            this.PurchasedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchasedataGridView.Size = new System.Drawing.Size(1046, 549);
            this.PurchasedataGridView.TabIndex = 5;
            this.PurchasedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchasedataGridView_CellClick);
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
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.MinimumWidth = 6;
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // PerUnitGV
            // 
            this.PerUnitGV.HeaderText = "Per Unit Price";
            this.PerUnitGV.MinimumWidth = 6;
            this.PerUnitGV.Name = "PerUnitGV";
            this.PerUnitGV.ReadOnly = true;
            // 
            // TotGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.TotGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotGV.HeaderText = "Total Amount";
            this.TotGV.MinimumWidth = 6;
            this.TotGV.Name = "TotGV";
            this.TotGV.ReadOnly = true;
            // 
            // DeleteGV
            // 
            this.DeleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteGV.HeaderText = "Action";
            this.DeleteGV.MinimumWidth = 6;
            this.DeleteGV.Name = "DeleteGV";
            this.DeleteGV.ReadOnly = true;
            this.DeleteGV.Text = "DELETE";
            this.DeleteGV.UseColumnTextForButtonValue = true;
            // 
            // CartBtn
            // 
            this.CartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartBtn.FlatAppearance.BorderSize = 2;
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartBtn.Location = new System.Drawing.Point(8, 407);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(254, 38);
            this.CartBtn.TabIndex = 5;
            this.CartBtn.Text = "ADD TO CART";
            this.CartBtn.UseVisualStyleBackColor = true;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Amount";
            // 
            // TotLbl
            // 
            this.TotLbl.AutoSize = true;
            this.TotLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotLbl.Location = new System.Drawing.Point(12, 499);
            this.TotLbl.Name = "TotLbl";
            this.TotLbl.Size = new System.Drawing.Size(81, 46);
            this.TotLbl.TabIndex = 11;
            this.TotLbl.Text = "0.00";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 668);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1046, 101);
            this.panel5.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.48757F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.51243F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GrossLbl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1046, 101);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(679, 101);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gross Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GrossLbl
            // 
            this.GrossLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossLbl.Location = new System.Drawing.Point(688, 0);
            this.GrossLbl.Name = "GrossLbl";
            this.GrossLbl.Size = new System.Drawing.Size(355, 101);
            this.GrossLbl.TabIndex = 13;
            this.GrossLbl.Text = "0.00";
            this.GrossLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SupplierErrorLbl
            // 
            this.SupplierErrorLbl.AutoSize = true;
            this.SupplierErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.SupplierErrorLbl.Location = new System.Drawing.Point(237, 122);
            this.SupplierErrorLbl.Name = "SupplierErrorLbl";
            this.SupplierErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.SupplierErrorLbl.TabIndex = 14;
            this.SupplierErrorLbl.Text = "*";
            this.SupplierErrorLbl.Visible = false;
            // 
            // BarcodeErrorLbl
            // 
            this.BarcodeErrorLbl.AutoSize = true;
            this.BarcodeErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.BarcodeErrorLbl.Location = new System.Drawing.Point(237, 178);
            this.BarcodeErrorLbl.Name = "BarcodeErrorLbl";
            this.BarcodeErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.BarcodeErrorLbl.TabIndex = 15;
            this.BarcodeErrorLbl.Text = "*";
            this.BarcodeErrorLbl.Visible = false;
            // 
            // ProductErrorLbl
            // 
            this.ProductErrorLbl.AutoSize = true;
            this.ProductErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.ProductErrorLbl.Location = new System.Drawing.Point(237, 231);
            this.ProductErrorLbl.Name = "ProductErrorLbl";
            this.ProductErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.ProductErrorLbl.TabIndex = 16;
            this.ProductErrorLbl.Text = "*";
            this.ProductErrorLbl.Visible = false;
            // 
            // PerUnitErrorLbl
            // 
            this.PerUnitErrorLbl.AutoSize = true;
            this.PerUnitErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerUnitErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.PerUnitErrorLbl.Location = new System.Drawing.Point(237, 284);
            this.PerUnitErrorLbl.Name = "PerUnitErrorLbl";
            this.PerUnitErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.PerUnitErrorLbl.TabIndex = 17;
            this.PerUnitErrorLbl.Text = "*";
            this.PerUnitErrorLbl.Visible = false;
            // 
            // QuantityErrorLbl
            // 
            this.QuantityErrorLbl.AutoSize = true;
            this.QuantityErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.QuantityErrorLbl.Location = new System.Drawing.Point(237, 338);
            this.QuantityErrorLbl.Name = "QuantityErrorLbl";
            this.QuantityErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.QuantityErrorLbl.TabIndex = 18;
            this.QuantityErrorLbl.Text = "*";
            this.QuantityErrorLbl.Visible = false;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 769);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SupplierDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductTxt;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PerUnitTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView PurchasedataGridView;
        private System.Windows.Forms.Button CartBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GrossLbl;
        private System.Windows.Forms.Label QuantityErrorLbl;
        private System.Windows.Forms.Label PerUnitErrorLbl;
        private System.Windows.Forms.Label ProductErrorLbl;
        private System.Windows.Forms.Label BarcodeErrorLbl;
        private System.Windows.Forms.Label SupplierErrorLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerUnitGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGV;
    }
}