namespace InventrySystem
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordErrorLbl = new System.Windows.Forms.Label();
            this.usernameErrorLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.LoginBtn);
            this.leftPanel.Controls.Add(this.pwdTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.usernameTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.usernameErrorLbl);
            this.leftPanel.Controls.Add(this.PasswordErrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(280, 762);
            this.leftPanel.Controls.SetChildIndex(this.PasswordErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.pwdTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.LoginBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1046, 762);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(278, 80);
            // 
            // UserDisplayLbl
            // 
            this.UserDisplayLbl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(16, 280);
            this.usernameTxt.MaxLength = 30;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(214, 27);
            this.usernameTxt.TabIndex = 2;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(16, 340);
            this.pwdTxt.MaxLength = 30;
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Size = new System.Drawing.Size(214, 27);
            this.pwdTxt.TabIndex = 4;
            this.pwdTxt.UseSystemPasswordChar = true;
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(16, 384);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(214, 34);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordErrorLbl
            // 
            this.PasswordErrorLbl.AutoSize = true;
            this.PasswordErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.PasswordErrorLbl.Location = new System.Drawing.Point(94, 316);
            this.PasswordErrorLbl.Name = "PasswordErrorLbl";
            this.PasswordErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.PasswordErrorLbl.TabIndex = 14;
            this.PasswordErrorLbl.Text = "*";
            this.PasswordErrorLbl.Visible = false;
            // 
            // usernameErrorLbl
            // 
            this.usernameErrorLbl.AutoSize = true;
            this.usernameErrorLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLbl.ForeColor = System.Drawing.Color.Salmon;
            this.usernameErrorLbl.Location = new System.Drawing.Point(96, 254);
            this.usernameErrorLbl.Name = "usernameErrorLbl";
            this.usernameErrorLbl.Size = new System.Drawing.Size(25, 35);
            this.usernameErrorLbl.TabIndex = 15;
            this.usernameErrorLbl.Text = "*";
            this.usernameErrorLbl.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 762);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label usernameErrorLbl;
        private System.Windows.Forms.Label PasswordErrorLbl;
    }
}