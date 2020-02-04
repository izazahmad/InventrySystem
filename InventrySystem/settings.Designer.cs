namespace InventrySystem
{
    partial class settings
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
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.DatabaseTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserIDTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IntSecChb = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.logInBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.logInBtn);
            this.leftPanel.Controls.Add(this.SaveBtn);
            this.leftPanel.Controls.Add(this.IntSecChb);
            this.leftPanel.Controls.Add(this.PasswordTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.UserIDTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.DatabaseTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.ServerTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(280, 760);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.ServerTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.DatabaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.UserIDTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.PasswordTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.IntSecChb, 0);
            this.leftPanel.Controls.SetChildIndex(this.SaveBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.logInBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            // 
            // UserDisplayLbl
            // 
            this.UserDisplayLbl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server";
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(4, 265);
            this.ServerTxt.MaxLength = 50;
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(232, 27);
            this.ServerTxt.TabIndex = 2;
            // 
            // DatabaseTxt
            // 
            this.DatabaseTxt.Location = new System.Drawing.Point(4, 325);
            this.DatabaseTxt.MaxLength = 100;
            this.DatabaseTxt.Name = "DatabaseTxt";
            this.DatabaseTxt.Size = new System.Drawing.Size(232, 27);
            this.DatabaseTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // UserIDTxt
            // 
            this.UserIDTxt.Location = new System.Drawing.Point(4, 388);
            this.UserIDTxt.MaxLength = 30;
            this.UserIDTxt.Name = "UserIDTxt";
            this.UserIDTxt.Size = new System.Drawing.Size(232, 27);
            this.UserIDTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(4, 451);
            this.PasswordTxt.MaxLength = 30;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(232, 27);
            this.PasswordTxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // IntSecChb
            // 
            this.IntSecChb.AutoSize = true;
            this.IntSecChb.ForeColor = System.Drawing.Color.Black;
            this.IntSecChb.Location = new System.Drawing.Point(4, 496);
            this.IntSecChb.Name = "IntSecChb";
            this.IntSecChb.Size = new System.Drawing.Size(160, 24);
            this.IntSecChb.TabIndex = 9;
            this.IntSecChb.Text = "Integrated Security ";
            this.IntSecChb.UseVisualStyleBackColor = true;
            this.IntSecChb.CheckedChanged += new System.EventHandler(this.IntSecChb_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(4, 537);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(232, 35);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logInBtn.FlatAppearance.BorderSize = 2;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.ForeColor = System.Drawing.Color.Black;
            this.logInBtn.Location = new System.Drawing.Point(0, 614);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(232, 35);
            this.logInBtn.TabIndex = 11;
            this.logInBtn.Text = "Login";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(94, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "OR";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 760);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox IntSecChb;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserIDTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DatabaseTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ServerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logInBtn;
    }
}