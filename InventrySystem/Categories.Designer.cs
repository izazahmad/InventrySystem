namespace InventrySystem
{
    partial class Categories
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
            this.CatnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryErrorLbl = new System.Windows.Forms.Label();
            this.cat = new System.Windows.Forms.Label();
            this.activeErrorLbl = new System.Windows.Forms.Label();
            this.activeCB = new System.Windows.Forms.ComboBox();
            this.CatdataGridView = new System.Windows.Forms.DataGridView();
            this.categoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatStatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.activeCB);
            this.leftPanel.Controls.Add(this.cat);
            this.leftPanel.Controls.Add(this.activeErrorLbl);
            this.leftPanel.Controls.Add(this.CatnameTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.CategoryErrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(280, 719);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.CategoryErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.CatnameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.activeErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.cat, 0);
            this.leftPanel.Controls.SetChildIndex(this.activeCB, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.CatdataGridView);
            this.rightPanel.Size = new System.Drawing.Size(1050, 719);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.CatdataGridView, 0);
            // 
            // CatnameTxt
            // 
            this.CatnameTxt.Location = new System.Drawing.Point(3, 148);
            this.CatnameTxt.Name = "CatnameTxt";
            this.CatnameTxt.Size = new System.Drawing.Size(246, 27);
            this.CatnameTxt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category Name";
            // 
            // CategoryErrorLbl
            // 
            this.CategoryErrorLbl.AutoSize = true;
            this.CategoryErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.CategoryErrorLbl.Location = new System.Drawing.Point(107, 124);
            this.CategoryErrorLbl.Name = "CategoryErrorLbl";
            this.CategoryErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.CategoryErrorLbl.TabIndex = 19;
            this.CategoryErrorLbl.Text = "*";
            this.CategoryErrorLbl.Visible = false;
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.ForeColor = System.Drawing.Color.Black;
            this.cat.Location = new System.Drawing.Point(2, 181);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(75, 20);
            this.cat.TabIndex = 20;
            this.cat.Text = "Is Active ?";
            // 
            // activeErrorLbl
            // 
            this.activeErrorLbl.AutoSize = true;
            this.activeErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.activeErrorLbl.Location = new System.Drawing.Point(107, 181);
            this.activeErrorLbl.Name = "activeErrorLbl";
            this.activeErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.activeErrorLbl.TabIndex = 22;
            this.activeErrorLbl.Text = "*";
            this.activeErrorLbl.Visible = false;
            // 
            // activeCB
            // 
            this.activeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeCB.FormattingEnabled = true;
            this.activeCB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.activeCB.Location = new System.Drawing.Point(3, 205);
            this.activeCB.Name = "activeCB";
            this.activeCB.Size = new System.Drawing.Size(246, 28);
            this.activeCB.TabIndex = 23;
            // 
            // CatdataGridView
            // 
            this.CatdataGridView.AllowUserToAddRows = false;
            this.CatdataGridView.AllowUserToDeleteRows = false;
            this.CatdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CatdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CatdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDGV,
            this.CatNameGV,
            this.CatStatusGV});
            this.CatdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatdataGridView.Location = new System.Drawing.Point(0, 119);
            this.CatdataGridView.Name = "CatdataGridView";
            this.CatdataGridView.ReadOnly = true;
            this.CatdataGridView.RowHeadersVisible = false;
            this.CatdataGridView.RowHeadersWidth = 51;
            this.CatdataGridView.RowTemplate.Height = 24;
            this.CatdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatdataGridView.Size = new System.Drawing.Size(1050, 600);
            this.CatdataGridView.TabIndex = 4;
            this.CatdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatdataGridView_CellClick);
            // 
            // categoryIDGV
            // 
            this.categoryIDGV.HeaderText = "CategoryID";
            this.categoryIDGV.MinimumWidth = 6;
            this.categoryIDGV.Name = "categoryIDGV";
            this.categoryIDGV.ReadOnly = true;
            this.categoryIDGV.Visible = false;
            // 
            // CatNameGV
            // 
            this.CatNameGV.HeaderText = "Name";
            this.CatNameGV.MinimumWidth = 6;
            this.CatNameGV.Name = "CatNameGV";
            this.CatNameGV.ReadOnly = true;
            // 
            // CatStatusGV
            // 
            this.CatStatusGV.HeaderText = "Status";
            this.CatStatusGV.MinimumWidth = 6;
            this.CatStatusGV.Name = "CatStatusGV";
            this.CatStatusGV.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.ClientSize = new System.Drawing.Size(1330, 719);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox activeCB;
        private System.Windows.Forms.Label cat;
        private System.Windows.Forms.Label activeErrorLbl;
        private System.Windows.Forms.TextBox CatnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CategoryErrorLbl;
        private System.Windows.Forms.DataGridView CatdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatStatusGV;
    }
}