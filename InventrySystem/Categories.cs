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
    public partial class Categories : Sample2
    {
        int edit = 0; //this 0 is an indication to save operation and 1 is for update operation
        int catID;
        short stat;
        retrieval r = new retrieval();
        public Categories()
        {
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);

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
            if (CatnameTxt.Text == "")
            {
               CategoryErrorLbl.Visible = true;
            }
            else
            {
                CategoryErrorLbl.Visible = false;
            }
            
            if (activeCB.SelectedIndex == -1)
            {
                activeErrorLbl.Visible = true;
            }
            else
            {
                activeErrorLbl.Visible = false;
            }

            if (CategoryErrorLbl.Visible || activeErrorLbl.Visible)
            {
                MainClass.ShowMSG("fields with * are mandatory", "stop", "Error");//Error is the type of message
            }
            else
            {
                if (activeCB.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (activeCB.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)//code for save operation
                {

                    Insertion i = new Insertion();

                    i.insertCategory(CatnameTxt.Text, stat);
                    r.showCategory(CatdataGridView, categoryIDGV, CatNameGV, CatStatusGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateCategory(catID, CatnameTxt.Text, stat);
                        r.showCategory(CatdataGridView, categoryIDGV, CatNameGV, CatStatusGV);
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
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategory(CatdataGridView, categoryIDGV, CatNameGV, CatStatusGV);
                }

            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                r.showCategory(CatdataGridView, categoryIDGV, CatNameGV, CatStatusGV, SearchTxt.Text);

            }
            else
            {
                r.showCategory(CatdataGridView, categoryIDGV, CatNameGV, CatStatusGV);

            }
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.showCategory(CatdataGridView, categoryIDGV, CatNameGV, CatStatusGV);
        }

        private void CatdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = CatdataGridView.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["categoryIDGV"].Value.ToString());
                CatnameTxt.Text = row.Cells["CatNameGV"].Value.ToString();
                activeCB.SelectedItem = row.Cells["CatStatusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
