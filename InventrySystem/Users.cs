using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventrySystem
{
    public partial class Users : Sample2
    {
        int edit=0; //this 0 is an indication to save operation and 1 is for update operation
        int userID;
        short stat;

        retrieval r = new retrieval();

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);

        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") 
            {
                nameErrorLbl.Visible = true;
            } 
            else
            {
                nameErrorLbl.Visible = false;
            }
            if (usernameTxt.Text == "")
            {
                usernameErrorLbl.Visible = true;
            }
            else
            {
                usernameErrorLbl.Visible = false;
            }
            if (passTxt.Text == "")
            {
                passErrorLbl.Visible = true;
            }
            else
            {
                passErrorLbl.Visible = false;
            }
            if (emailTxt.Text == "")
            {
                emailErrorLbl.Visible = true;
            }
            else
            {
                emailErrorLbl.Visible = false;
            }
            if (phoneTxt.Text == "")
            {
                phoneErrorLbl.Visible = true;
            }
            else
            {
                phoneErrorLbl.Visible = false;
            }
            if (StatusDD.SelectedIndex == -1)
            {
                statusErrorLbl.Visible = true;
            }
            else
            {
                statusErrorLbl.Visible = false;
            }

            if (nameErrorLbl.Visible || usernameErrorLbl.Visible || passErrorLbl.Visible || emailErrorLbl.Visible || phoneErrorLbl.Visible || statusErrorLbl.Visible)
            {
                MainClass.ShowMSG("fields with * are mandatory", "stop", "Error");//Error is the type of message
            }
            else
            {
                if (StatusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (StatusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit==0)//code for save operation
                {
                    
                    Insertion i = new Insertion();

                    i.insertUser(nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text,stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if(edit==1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dr== DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateUser(userID, nameTxt.Text, usernameTxt.Text, passTxt.Text, emailTxt.Text, phoneTxt.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }
                    

                }
            }
        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(edit==1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to Delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);

                }

            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if(SearchTxt.Text != "")
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV,SearchTxt.Text);

            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);

            }
        }
        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, EmailGV, PhoneGV, StatusGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID =Convert.ToInt32( row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UserNameGV"].Value.ToString();
                passTxt.Text = row.Cells["PassGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                StatusDD.SelectedItem= row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }

    }
}
