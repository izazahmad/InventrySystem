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
    public partial class Products : Sample2
    {
        retrieval r = new retrieval();
        int edit=0;
        int proID;
        public Products()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getCategoryList("st_getCategoriesList", categoryCB, "Category", "ID");


        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            
            MainClass.enable_reset(leftPanel);
            categoryCB.DataSource = null;
            categoryCB.Items.Clear();
            categoryCB.SelectedItem = 0;
            edit = 0;
            r.getCategoryList("st_getCategoriesList", categoryCB, "Category", "ID");

        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ProductTxt.Text == "")
            {
                productErrorLbl.Visible = true;
            }
            else
            {
                productErrorLbl.Visible = false;
            }
            if (barcodeTxt.Text == "")
            {
                barcodeErrorLbl.Visible = true;
            }
            else
            {
                barcodeErrorLbl.Visible = false;
            }
            if (ExpiryPicker.Value < DateTime.Now)
            {
                ExpiryErrorLbl.Visible = true;
                ExpiryErrorLbl.Text = "Invalid Date";
            }
            else
            {
                ExpiryErrorLbl.Visible = false;
            }
            if (ExpiryPicker.Value.Date == DateTime.Now.Date)
            {
                ExpiryErrorLbl.Visible = false;
            }
            
            if (priceTxt.Text == "")
            {
                priceErrorLbl.Visible = true;
            }
            else
            {
                priceErrorLbl.Visible = false;
            }
            if (categoryCB.SelectedIndex == -1 || categoryCB.SelectedIndex==0)
            {
                CategoryErrorLbl.Visible = true;
            }
            else
            {
                CategoryErrorLbl.Visible = false;
            }
            

            if (productErrorLbl.Visible || barcodeErrorLbl.Visible || priceErrorLbl.Visible || CategoryErrorLbl.Visible)
            {
                MainClass.ShowMSG("fields with * are mandatory", "stop", "Error");//Error is the type of message
            }
            else
            {
                
                if (edit == 0)//code for save operation
                {

                    Insertion i = new Insertion();
                    if(ExpiryPicker.Value.Date==DateTime.Now.Date)
                    {
                        i.insertProduct(ProductTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text),  Convert.ToInt32(categoryCB.SelectedValue));

                    }
                    else
                    {
                        i.insertProduct(ProductTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryCB.SelectedValue), ExpiryPicker.Value);

                    }

                    r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1)//code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (ExpiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(proID, ProductTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryCB.SelectedValue));

                        }
                        else
                        {
                            u.updateProduct(proID, ProductTxt.Text, barcodeTxt.Text, Convert.ToSingle(priceTxt.Text), Convert.ToInt32(categoryCB.SelectedValue), ExpiryPicker.Value);

                        }
                        r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV);
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
                    d.delete(proID, "st_deleteProduct", "@id");
                    r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV);
          
                }

            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (SearchTxt.Text != "")
            {
                r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV, SearchTxt.Text);

            }
            else
            {
                r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV);

            }
        }

        

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV);

        }

        private void ProductdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex!=-1)
            {
                edit = 1;
                DataGridViewRow row = ProductdataGridView.Rows[e.RowIndex];
                proID = Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString());
                ProductTxt.Text = row.Cells["NameGV"].Value.ToString();
                barcodeTxt.Text = row.Cells["BarcodeGV"].Value.ToString();
                if(row.Cells["ExpiryGV"].FormattedValue.ToString() == "")
                {
                    ExpiryPicker.Value = DateTime.Now;
                }
                else
                {
                    ExpiryPicker.Value = Convert.ToDateTime(row.Cells["ExpiryGV"].Value.ToString());

                }
                priceTxt.Text = row.Cells["PriceGV"].Value.ToString();
                categoryCB.SelectedValue = row.Cells["CategoryIDGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
