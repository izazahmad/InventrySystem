namespace InventrySystem
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.SalesdataGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerUnitGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.GrossLbl = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.PayGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.ChangeGiveTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AmountGiveTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotDiscountTxt = new System.Windows.Forms.TextBox();
            this.GrossTxt = new System.Windows.Forms.TextBox();
            this.PaymentDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.PayGroupBox.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 63);
            this.panel4.Size = new System.Drawing.Size(280, 56);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel7);
            this.leftPanel.Controls.Add(this.PayGroupBox);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.PayGroupBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel7, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.SalesdataGridView);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.SalesdataGridView, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Location = new System.Drawing.Point(11, 6);
            this.BarcodeTxt.MaxLength = 100;
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(256, 27);
            this.BarcodeTxt.TabIndex = 3;
            this.BarcodeTxt.TextChanged += new System.EventHandler(this.BarcodeTxt_TextChanged);
            this.BarcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.BarcodeTxt_Validating);
            // 
            // SalesdataGridView
            // 
            this.SalesdataGridView.AllowUserToAddRows = false;
            this.SalesdataGridView.AllowUserToDeleteRows = false;
            this.SalesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SalesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDGV,
            this.NameGV,
            this.QuantityGV,
            this.PerUnitGV,
            this.DiscountGV,
            this.TotGV,
            this.DeleteGV});
            this.SalesdataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesdataGridView.Location = new System.Drawing.Point(0, 119);
            this.SalesdataGridView.Name = "SalesdataGridView";
            this.SalesdataGridView.ReadOnly = true;
            this.SalesdataGridView.RowHeadersVisible = false;
            this.SalesdataGridView.RowHeadersWidth = 51;
            this.SalesdataGridView.RowTemplate.Height = 24;
            this.SalesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesdataGridView.Size = new System.Drawing.Size(1046, 549);
            this.SalesdataGridView.TabIndex = 6;
            this.SalesdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesdataGridView_CellClick);
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
            // DiscountGV
            // 
            this.DiscountGV.HeaderText = "Discount";
            this.DiscountGV.MinimumWidth = 6;
            this.DiscountGV.Name = "DiscountGV";
            this.DiscountGV.ReadOnly = true;
            // 
            // TotGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.TotGV.DefaultCellStyle = dataGridViewCellStyle4;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 668);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1046, 77);
            this.panel5.TabIndex = 7;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1046, 77);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(679, 77);
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
            this.GrossLbl.Size = new System.Drawing.Size(355, 77);
            this.GrossLbl.TabIndex = 13;
            this.GrossLbl.Text = "0.00";
            this.GrossLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Blue;
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderSize = 2;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Location = new System.Drawing.Point(12, 408);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(256, 93);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "&PAY";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // PayGroupBox
            // 
            this.PayGroupBox.Controls.Add(this.CheckoutBtn);
            this.PayGroupBox.Controls.Add(this.ChangeGiveTxt);
            this.PayGroupBox.Controls.Add(this.label7);
            this.PayGroupBox.Controls.Add(this.AmountGiveTxt);
            this.PayGroupBox.Controls.Add(this.label6);
            this.PayGroupBox.Controls.Add(this.TotDiscountTxt);
            this.PayGroupBox.Controls.Add(this.GrossTxt);
            this.PayGroupBox.Controls.Add(this.PaymentDD);
            this.PayGroupBox.Controls.Add(this.label5);
            this.PayGroupBox.Controls.Add(this.label4);
            this.PayGroupBox.Controls.Add(this.label3);
            this.PayGroupBox.Controls.Add(this.payBtn);
            this.PayGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PayGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PayGroupBox.Location = new System.Drawing.Point(0, 158);
            this.PayGroupBox.Name = "PayGroupBox";
            this.PayGroupBox.Size = new System.Drawing.Size(280, 584);
            this.PayGroupBox.TabIndex = 5;
            this.PayGroupBox.TabStop = false;
            this.PayGroupBox.Text = "Payments";
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.BackColor = System.Drawing.Color.Blue;
            this.CheckoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckoutBtn.FlatAppearance.BorderSize = 2;
            this.CheckoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckoutBtn.Location = new System.Drawing.Point(12, 304);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(256, 93);
            this.CheckoutBtn.TabIndex = 15;
            this.CheckoutBtn.Text = "&CHECKOUT";
            this.CheckoutBtn.UseVisualStyleBackColor = false;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // ChangeGiveTxt
            // 
            this.ChangeGiveTxt.Enabled = false;
            this.ChangeGiveTxt.Location = new System.Drawing.Point(11, 267);
            this.ChangeGiveTxt.MaxLength = 100;
            this.ChangeGiveTxt.Name = "ChangeGiveTxt";
            this.ChangeGiveTxt.Size = new System.Drawing.Size(256, 27);
            this.ChangeGiveTxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Change to Give";
            // 
            // AmountGiveTxt
            // 
            this.AmountGiveTxt.Location = new System.Drawing.Point(11, 214);
            this.AmountGiveTxt.MaxLength = 100;
            this.AmountGiveTxt.Name = "AmountGiveTxt";
            this.AmountGiveTxt.Size = new System.Drawing.Size(256, 27);
            this.AmountGiveTxt.TabIndex = 12;
            this.AmountGiveTxt.TextChanged += new System.EventHandler(this.AmountGiveTxt_TextChanged);
            this.AmountGiveTxt.Validating += new System.ComponentModel.CancelEventHandler(this.AmountGiveTxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount Given";
            // 
            // TotDiscountTxt
            // 
            this.TotDiscountTxt.Enabled = false;
            this.TotDiscountTxt.Location = new System.Drawing.Point(11, 99);
            this.TotDiscountTxt.MaxLength = 100;
            this.TotDiscountTxt.Name = "TotDiscountTxt";
            this.TotDiscountTxt.Size = new System.Drawing.Size(256, 27);
            this.TotDiscountTxt.TabIndex = 10;
            // 
            // GrossTxt
            // 
            this.GrossTxt.Enabled = false;
            this.GrossTxt.Location = new System.Drawing.Point(11, 46);
            this.GrossTxt.MaxLength = 100;
            this.GrossTxt.Name = "GrossTxt";
            this.GrossTxt.Size = new System.Drawing.Size(256, 27);
            this.GrossTxt.TabIndex = 9;
            // 
            // PaymentDD
            // 
            this.PaymentDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentDD.FormattingEnabled = true;
            this.PaymentDD.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.PaymentDD.Location = new System.Drawing.Point(11, 158);
            this.PaymentDD.Name = "PaymentDD";
            this.PaymentDD.Size = new System.Drawing.Size(256, 28);
            this.PaymentDD.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gross Total";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BarcodeTxt);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 39);
            this.panel7.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Barcode";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 56);
            this.panel6.TabIndex = 1;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 742);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel4.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.PayGroupBox.ResumeLayout(false);
            this.PayGroupBox.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.DataGridView SalesdataGridView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GrossLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerUnitGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGV;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.GroupBox PayGroupBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PaymentDD;
        private System.Windows.Forms.TextBox TotDiscountTxt;
        private System.Windows.Forms.TextBox GrossTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountGiveTxt;
        private System.Windows.Forms.TextBox ChangeGiveTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button CheckoutBtn;
    }
}