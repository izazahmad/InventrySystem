using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventrySystem
{
    public partial class PurchaseInvoice : Sample2
    {
        retrieval r = new retrieval();
        
        string[] prodArr = new string[6];
        string[] prod = new string[3];
        Int64 productID;
        float gt;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getSupplierList("st_getSupplierList", SupplierDD, "Company", "ID");

        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {

            MainClass.enable_reset(leftPanel);
            SupplierDD.DataSource = null;
            SupplierDD.Items.Clear();
            SupplierDD.SelectedItem = 0;
            r.getSupplierList("st_getSupplierList", SupplierDD, "Company", "ID");

        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable(leftPanel);
        }
        int co;
        Updation u = new Updation();
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PurchasedataGridView.Rows.Count >0)
            {
                Int64 purchaseInvoiceID;
                Insertion i = new Insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrieval.USER_ID, Convert.ToInt32(SupplierDD.SelectedValue));
                    foreach (DataGridViewRow row in PurchasedataGridView.Rows)
                    {
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["TotGV"].Value.ToString()));
                        if (r.checkProductPriceExistance(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString())))
                        {
                            u.UpdateProductPrice(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["PerUnitGV"].Value.ToString()));
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["PerUnitGV"].Value.ToString()));

                        }
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()));
                        int q = Convert.ToInt32(ob);

                        if (ob != null)
                        {
                            
                            q += Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                            u.UpdateStock(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()), q);

                        }
                        else
                        {
                            i.insertStock(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()));
                        }
                    }
                    if (co > 0)
                    {
                        MainClass.ShowMSG("Purchase invoice created Successfully.", "Success", "Success");
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable to create Purchase invoice.", "Error", "Error");
                    }
                    sc.Complete();
                }
               
            }
        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {
            //if (edit == 1)
            //{
            //    DialogResult dr = MessageBox.Show("Are you sure, you want to Delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dr == DialogResult.Yes)
            //    {
            //        Deletion d = new Deletion();
            //        d.delete(proID, "st_deleteProduct", "@id");
            //        r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV);

            //    }

            //}
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            //if (SearchTxt.Text != "")
            //{
            //    r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV, SearchTxt.Text);

            //}
            //else
            //{
            //    r.showProduct(ProductdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, CategoryIDGV);

            //}
        }



        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails piDetail = new PurchaseInvoiceDetails();
            MainClass.showWindow(piDetail, this, ActiveForm);

        }

        private void BarcodeTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BarcodeTxt_Validated(object sender, EventArgs e)
        {
            
        }

        private void QuantityTxt_TextChanged(object sender, EventArgs e)
        {
            if(QuantityTxt.Text != "" )
            {
                if(rg.Match(QuantityTxt.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(QuantityTxt.Text);
                    price = Convert.ToSingle(PerUnitTxt.Text);
                    tot = quan * price;
                    TotLbl.Text = tot.ToString();
                }
                else
                {
                    QuantityTxt.SelectAll();
                }
            }
            else
            {
                TotLbl.Text = "0.00";
            }
        }

        private void PurchasedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 5)
                {       
                    DataGridViewRow row = PurchasedataGridView.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                    GrossLbl.Text = gt.ToString();
                    PurchasedataGridView.Rows.Remove(row);
                }
            }

        }

        private void PerUnitTxt_TextChanged(object sender, EventArgs e)
        {
            if(PerUnitTxt.Text != "")
            {
                if(!rg.Match(PerUnitTxt.Text).Success)
                {
                    PerUnitTxt.Text = "";
                    PerUnitTxt.Focus();
                }
            }
        }

        private void BarcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (BarcodeTxt.Text != "")
            {
                prod = r.getProductDetailBarcode(BarcodeTxt.Text);
                productID = Convert.ToInt32(prod[0]);
                ProductTxt.Text = prod[1];
                string barco = prod[2];
                ProductTxt.Enabled = false;
                //PerUnitTxt.Enabled = false;
                if (barco != null)
                {
                    PerUnitTxt.Focus();
                    //QuantityTxt.Focus();

                }
            }
            else
            {
                productID = 0;
                ProductTxt.Text = "";
                PerUnitTxt.Text = "";
                Array.Clear(prod, 0, prod.Length);
            }
        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            if (SupplierDD.SelectedIndex == 0)
            {
                SupplierErrorLbl.Visible = true;
            }
            else
            {
                SupplierErrorLbl.Visible = false;
            }
            if (BarcodeTxt.Text == "")
            {
                BarcodeErrorLbl.Visible = true;
            }
            else
            {
                BarcodeErrorLbl.Visible = false;
            }
            if (ProductTxt.Text == "")
            {
                ProductErrorLbl.Visible = true;
            }
            else
            {
                ProductErrorLbl.Visible = false;
            }
            if (PerUnitTxt.Text=="")
            {
                PerUnitErrorLbl.Visible = true;
            }
            else
            {
                PerUnitErrorLbl.Visible = false;

            }

            if (QuantityTxt.Text == "")
            {
                QuantityErrorLbl.Visible = true;
            }
            else
            {
                QuantityErrorLbl.Visible = false;
            }

            if (SupplierErrorLbl.Visible || BarcodeErrorLbl.Visible || ProductErrorLbl.Visible || PerUnitErrorLbl.Visible || QuantityErrorLbl.Visible)
            {
                MainClass.ShowMSG("fields with * are mandatory", "stop", "Error");//Error is the type of message
            }
            else
            {
                PurchasedataGridView.Rows.Add(productID, ProductTxt.Text, QuantityTxt.Text, PerUnitTxt.Text, TotLbl.Text);
                gt += Convert.ToSingle(TotLbl.Text);
                GrossLbl.Text = gt.ToString();
                productID = 0;
                ProductTxt.Text = "";
                PerUnitTxt.Text = "";
                BarcodeTxt.Text = "";
                TotLbl.Text = "0.00";
                QuantityTxt.Text = "";
                Array.Clear(prodArr, 0, prodArr.Length);

            }
        }
    }
}
