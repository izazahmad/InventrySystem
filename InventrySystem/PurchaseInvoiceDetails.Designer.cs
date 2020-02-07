namespace InventrySystem
{
    partial class PurchaseInvoiceDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceDD = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GrossLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PurchasedataGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerUnitGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.InvoiceDD);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.datePicker);
            this.leftPanel.Size = new System.Drawing.Size(280, 727);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.datePicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.InvoiceDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel2);
            this.rightPanel.Controls.Add(this.PurchasedataGridView);
            this.rightPanel.Size = new System.Drawing.Size(1050, 727);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.PurchasedataGridView, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Date";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MMMM-yyyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datePicker.Location = new System.Drawing.Point(11, 151);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(253, 27);
            this.datePicker.TabIndex = 2;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Purchase Invoice";
            // 
            // InvoiceDD
            // 
            this.InvoiceDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InvoiceDD.FormattingEnabled = true;
            this.InvoiceDD.Location = new System.Drawing.Point(11, 208);
            this.InvoiceDD.Name = "InvoiceDD";
            this.InvoiceDD.Size = new System.Drawing.Size(253, 28);
            this.InvoiceDD.TabIndex = 4;
            this.InvoiceDD.SelectedIndexChanged += new System.EventHandler(this.InvoiceDD_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.48757F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.51243F));
            this.tableLayoutPanel2.Controls.Add(this.GrossLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 622);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1050, 105);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // GrossLbl
            // 
            this.GrossLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossLbl.Location = new System.Drawing.Point(690, 0);
            this.GrossLbl.Name = "GrossLbl";
            this.GrossLbl.Size = new System.Drawing.Size(357, 105);
            this.GrossLbl.TabIndex = 13;
            this.GrossLbl.Text = "0.00";
            this.GrossLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(681, 105);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gross Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PurchasedataGridView
            // 
            this.PurchasedataGridView.AllowUserToAddRows = false;
            this.PurchasedataGridView.AllowUserToDeleteRows = false;
            this.PurchasedataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PurchasedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurchasedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PurchasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDGV,
            this.PIDGV,
            this.NameGV,
            this.QuantityGV,
            this.PerUnitGV,
            this.TotGV,
            this.DeleteGV});
            this.PurchasedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchasedataGridView.Location = new System.Drawing.Point(0, 119);
            this.PurchasedataGridView.Name = "PurchasedataGridView";
            this.PurchasedataGridView.ReadOnly = true;
            this.PurchasedataGridView.RowHeadersVisible = false;
            this.PurchasedataGridView.RowHeadersWidth = 51;
            this.PurchasedataGridView.RowTemplate.Height = 24;
            this.PurchasedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchasedataGridView.Size = new System.Drawing.Size(1050, 608);
            this.PurchasedataGridView.TabIndex = 16;
            // 
            // ProductIDGV
            // 
            this.ProductIDGV.HeaderText = "ProductID";
            this.ProductIDGV.MinimumWidth = 6;
            this.ProductIDGV.Name = "ProductIDGV";
            this.ProductIDGV.ReadOnly = true;
            this.ProductIDGV.Visible = false;
            this.ProductIDGV.Width = 125;
            // 
            // PIDGV
            // 
            this.PIDGV.HeaderText = "PID";
            this.PIDGV.MinimumWidth = 6;
            this.PIDGV.Name = "PIDGV";
            this.PIDGV.ReadOnly = true;
            this.PIDGV.Visible = false;
            this.PIDGV.Width = 125;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 6;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            this.NameGV.Width = 210;
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.MinimumWidth = 6;
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            this.QuantityGV.Width = 210;
            // 
            // PerUnitGV
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.PerUnitGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.PerUnitGV.HeaderText = "Per Unit Price";
            this.PerUnitGV.MinimumWidth = 6;
            this.PerUnitGV.Name = "PerUnitGV";
            this.PerUnitGV.ReadOnly = true;
            this.PerUnitGV.Width = 209;
            // 
            // TotGV
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.TotGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotGV.HeaderText = "Total Amount";
            this.TotGV.MinimumWidth = 6;
            this.TotGV.Name = "TotGV";
            this.TotGV.ReadOnly = true;
            this.TotGV.Width = 210;
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
            // PurchaseInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Name = "PurchaseInvoiceDetails";
            this.Text = "Purchase Invoice Details";
            this.Load += new System.EventHandler(this.PurchaseInvoiceDetails_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InvoiceDD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GrossLbl;
        private System.Windows.Forms.DataGridView PurchasedataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerUnitGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGV;
    }
}