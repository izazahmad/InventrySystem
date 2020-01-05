using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventrySystem
{
    public partial class Suppliers : Sample2
    {
        int edit = 0; //this 0 is an indication to save operation and 1 is for update operation
        int suppID;
        short stat;

        retrieval r = new retrieval();
        public Suppliers()
        {
            InitializeComponent();
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
            if (SuppNameTxt.Text == "")
            {
                suppnameErrorLbl.Visible = true;
            }
            else
            {
                suppnameErrorLbl.Visible = false;
            }
            if (ContactPersonTxt.Text == "")
            {
                contPersonErrorLbl.Visible = true;
            }
            else
            {
                contPersonErrorLbl.Visible = false;
            }
            if (Phone1Txt.Text == "")
            {
                Phone1ErrorLbl.Visible = true;
            }
            else
            {
                Phone1ErrorLbl.Visible = false;
            }
            //if (Phone2Txt.Text == "")
            //{
            //    Phone2ErrorLbl.Visible = true;
            //}
            //else
            //{
            //    Phone2ErrorLbl.Visible = false;
            //}
            if (AddressTxt.Text == "")
            {
                AddressErrorLbl.Visible = true;
            }
            else
            {
                AddressErrorLbl.Visible = false;
            }
            //if (TinTxt.Text == "")
            //{
            //    TinErrorLbl.Visible = true;
            //}
            //else
            //{
            //    TinErrorLbl.Visible = false;
            //}
            if (StatusDD.SelectedIndex == -1)
            {
                StatusErrorLbl.Visible = true;
            }
            else
            {
                StatusErrorLbl.Visible = false;
            }

            if (suppnameErrorLbl.Visible || contPersonErrorLbl.Visible || Phone1ErrorLbl.Visible || AddressErrorLbl.Visible || StatusErrorLbl.Visible)
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
                if (edit == 0)//code for save operation
                {

                    Insertion i = new Insertion();
                    if (Phone2Txt.Text == "" && TinTxt.Text != "")
                    {
                        i.insertSupplier(SuppNameTxt.Text, ContactPersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, null, TinTxt.Text);

                    }
                    else if (Phone2Txt.Text != "" && TinTxt.Text == "")
                    {
                        i.insertSupplier(SuppNameTxt.Text, ContactPersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, Phone2Txt.Text, null);

                    }
                    else if (Phone2Txt.Text == "" && TinTxt.Text == "")
                    {
                        i.insertSupplier(SuppNameTxt.Text, ContactPersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, null, null);

                    }
                    else
                    {
                        i.insertSupplier(SuppNameTxt.Text, ContactPersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, Phone2Txt.Text, TinTxt.Text);
                    }
                    r.showSupplier(SupplierdataGridView, SupplierIDGV, CompanyGV, ContactPersonGV, Phone1GV, Phone2GV, AddressGV, TinGV, StatusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateSupplier(suppID, SuppNameTxt.Text, ContactPersonTxt.Text, Phone1Txt.Text, AddressTxt.Text, stat, Phone2Txt.Text, TinTxt.Text);
                        r.showSupplier(SupplierdataGridView, SupplierIDGV, CompanyGV, ContactPersonGV, Phone1GV, Phone2GV, AddressGV, TinGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }


                }
            }
        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to Delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(suppID, "st_deleteSupplier", "@suppID");
                    r.showSupplier(SupplierdataGridView, SupplierIDGV, CompanyGV, ContactPersonGV, Phone1GV, Phone2GV, AddressGV, TinGV, StatusGV);

                }

            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                r.showSupplier(SupplierdataGridView, SupplierIDGV, CompanyGV, ContactPersonGV, Phone1GV, Phone2GV, AddressGV, TinGV, StatusGV, SearchTxt.Text);


            }
            else
            {
                r.showSupplier(SupplierdataGridView, SupplierIDGV, CompanyGV, ContactPersonGV, Phone1GV, Phone2GV, AddressGV, TinGV, StatusGV);

            }
        }
        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.showSupplier(SupplierdataGridView, SupplierIDGV, CompanyGV, ContactPersonGV, Phone1GV, Phone2GV, AddressGV, TinGV, StatusGV);

        }

        private void SupplierdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                edit = 1;
                DataGridViewRow row = SupplierdataGridView.Rows[e.RowIndex];
                suppID = Convert.ToInt32(row.Cells["SupplierIDGV"].Value.ToString());
                SuppNameTxt.Text = row.Cells["CompanyGV"].Value.ToString();
                ContactPersonTxt.Text = row.Cells["ContactPersonGV"].Value.ToString();
                Phone1Txt.Text = row.Cells["Phone1GV"].Value.ToString();
                Phone2Txt.Text = row.Cells["Phone2GV"].Value.ToString();
                AddressTxt.Text = row.Cells["AddressGV"].Value.ToString();
                TinTxt.Text = row.Cells["TinGV"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex != -1)
        //    {
        //        edit = 1;
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //        userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
        //        nameTxt.Text = row.Cells["NameGV"].Value.ToString();
        //        usernameTxt.Text = row.Cells["UserNameGV"].Value.ToString();
        //        passTxt.Text = row.Cells["PassGV"].Value.ToString();
        //        phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
        //        emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
        //        StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
        //        MainClass.disable(leftPanel);

        //    }
        //}
    }
}
