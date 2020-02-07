namespace InventrySystem
{
    partial class Users
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameErrorLbl = new System.Windows.Forms.Label();
            this.usernameErrorLbl = new System.Windows.Forms.Label();
            this.passErrorLbl = new System.Windows.Forms.Label();
            this.phoneErrorLbl = new System.Windows.Forms.Label();
            this.emailErrorLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.statusErrorLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1094, 56);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(285, 53);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.StatusDD);
            this.leftPanel.Controls.Add(this.StatusLbl);
            this.leftPanel.Controls.Add(this.emailTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.usernameTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.nameErrorLbl);
            this.leftPanel.Controls.Add(this.usernameErrorLbl);
            this.leftPanel.Controls.Add(this.passErrorLbl);
            this.leftPanel.Controls.Add(this.phoneErrorLbl);
            this.leftPanel.Controls.Add(this.emailErrorLbl);
            this.leftPanel.Controls.Add(this.statusErrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(280, 718);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.passErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.StatusLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.StatusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(1094, 718);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1094, 63);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(16, 163);
            this.nameTxt.MaxLength = 35;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(248, 27);
            this.nameTxt.TabIndex = 3;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(16, 217);
            this.usernameTxt.MaxLength = 20;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(248, 27);
            this.usernameTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username:";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(16, 271);
            this.passTxt.MaxLength = 20;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(248, 27);
            this.passTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(16, 325);
            this.phoneTxt.MaxLength = 15;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(248, 27);
            this.phoneTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone (03xx-xxxxxx):";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(16, 379);
            this.emailTxt.MaxLength = 50;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(248, 27);
            this.emailTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email:";
            // 
            // nameErrorLbl
            // 
            this.nameErrorLbl.AutoSize = true;
            this.nameErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.nameErrorLbl.Location = new System.Drawing.Point(60, 136);
            this.nameErrorLbl.Name = "nameErrorLbl";
            this.nameErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.nameErrorLbl.TabIndex = 12;
            this.nameErrorLbl.Text = "*";
            this.nameErrorLbl.Visible = false;
            // 
            // usernameErrorLbl
            // 
            this.usernameErrorLbl.AutoSize = true;
            this.usernameErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.usernameErrorLbl.Location = new System.Drawing.Point(87, 190);
            this.usernameErrorLbl.Name = "usernameErrorLbl";
            this.usernameErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.usernameErrorLbl.TabIndex = 13;
            this.usernameErrorLbl.Text = "*";
            this.usernameErrorLbl.Visible = false;
            // 
            // passErrorLbl
            // 
            this.passErrorLbl.AutoSize = true;
            this.passErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.passErrorLbl.Location = new System.Drawing.Point(83, 245);
            this.passErrorLbl.Name = "passErrorLbl";
            this.passErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.passErrorLbl.TabIndex = 14;
            this.passErrorLbl.Text = "*";
            this.passErrorLbl.Visible = false;
            // 
            // phoneErrorLbl
            // 
            this.phoneErrorLbl.AutoSize = true;
            this.phoneErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.phoneErrorLbl.Location = new System.Drawing.Point(154, 298);
            this.phoneErrorLbl.Name = "phoneErrorLbl";
            this.phoneErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.phoneErrorLbl.TabIndex = 15;
            this.phoneErrorLbl.Text = "*";
            this.phoneErrorLbl.Visible = false;
            // 
            // emailErrorLbl
            // 
            this.emailErrorLbl.AutoSize = true;
            this.emailErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.emailErrorLbl.Location = new System.Drawing.Point(59, 353);
            this.emailErrorLbl.Name = "emailErrorLbl";
            this.emailErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.emailErrorLbl.TabIndex = 16;
            this.emailErrorLbl.Text = "*";
            this.emailErrorLbl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDGV,
            this.NameGV,
            this.UserNameGV,
            this.PassGV,
            this.EmailGV,
            this.PhoneGV,
            this.StatusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 599);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "UserID";
            this.userIDGV.MinimumWidth = 6;
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.MinimumWidth = 6;
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            this.UserNameGV.HeaderText = "Username";
            this.UserNameGV.MinimumWidth = 6;
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            // 
            // PassGV
            // 
            this.PassGV.HeaderText = "Password";
            this.PassGV.MinimumWidth = 6;
            this.PassGV.Name = "PassGV";
            this.PassGV.ReadOnly = true;
            this.PassGV.Visible = false;
            // 
            // EmailGV
            // 
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.MinimumWidth = 6;
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone";
            this.PhoneGV.MinimumWidth = 6;
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.MinimumWidth = 6;
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.ForeColor = System.Drawing.Color.Black;
            this.StatusLbl.Location = new System.Drawing.Point(13, 415);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(52, 20);
            this.StatusLbl.TabIndex = 17;
            this.StatusLbl.Text = "Status:";
            // 
            // StatusDD
            // 
            this.StatusDD.FormattingEnabled = true;
            this.StatusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.StatusDD.Location = new System.Drawing.Point(17, 441);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(247, 28);
            this.StatusDD.TabIndex = 18;
            // 
            // statusErrorLbl
            // 
            this.statusErrorLbl.AutoSize = true;
            this.statusErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrorLbl.Location = new System.Drawing.Point(63, 412);
            this.statusErrorLbl.Name = "statusErrorLbl";
            this.statusErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.statusErrorLbl.TabIndex = 19;
            this.statusErrorLbl.Text = "*";
            this.statusErrorLbl.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1374, 718);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameErrorLbl;
        private System.Windows.Forms.Label usernameErrorLbl;
        private System.Windows.Forms.Label passErrorLbl;
        private System.Windows.Forms.Label phoneErrorLbl;
        private System.Windows.Forms.Label emailErrorLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label statusErrorLbl;
    }
}