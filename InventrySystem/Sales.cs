using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventrySystem
{
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        string[] prodArr = new string[6];
        Int64 productID;
        float gt, tot, discount;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        private void Sales_Load(object sender, EventArgs e)
        {

        }
        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewSalesInvoice vws = new ViewSalesInvoice();
            MainClass.showWindow(vws, this, MDI.ActiveForm);
        }
        private bool productCheck;
        private void BarcodeTxt_Validating(object sender, CancelEventArgs e)
        {

            if (BarcodeTxt.Text != "" )
            {
                GrossTxt.Text = "";
                TotDiscountTxt.Text = "";
                AmountGiveTxt.Text = "";
                ChangeGiveTxt.Text = "";
                prodArr = r.getProductByBarcodeList(BarcodeTxt.Text);

                if (prodArr[0] != null)
                {
                    
                    if (prodArr[3].Length != 0 )
                    {
                        productID = Convert.ToInt64(prodArr[0]);
                        int quanCount = 0;
                        int Quantity = 0;
                        int newCount = 0;
                        foreach (DataGridViewRow row in SalesdataGridView.Rows)
                        {
                            if (prodArr[0] == row.Cells["ProductIDGV"].Value.ToString())
                            {
                                quanCount = quanCount + Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                            }
                        }
                        Quantity = Convert.ToInt32(r.getProductQuantity(productID));
                        newCount = Quantity - quanCount;
                        if (newCount<=0)
                        {
                            MainClass.ShowMSG(" no stock left now", "Alert", "Alert");
                        }
                        else
                        {
                            if (SalesdataGridView.RowCount == 0)
                            {
                                SalesdataGridView.Rows.Add(productID, prodArr[1], 1, Convert.ToSingle(prodArr[3]), prodArr[4], Convert.ToSingle(prodArr[5]));
                            }
                            else
                            {
                                foreach (DataGridViewRow row in SalesdataGridView.Rows)
                                {
                                    if (row.Cells["ProductIDGV"].Value.ToString() == productID.ToString())
                                    {
                                        productCheck = true;
                                        break;

                                    }
                                    else
                                    {
                                        productCheck = false;

                                    }
                                }
                                if (productCheck == true)
                                {
                                    foreach (DataGridViewRow row in SalesdataGridView.Rows)
                                    {
                                        if (row.Cells["ProductIDGV"].Value.ToString() == productID.ToString())
                                        {
                                            int quan = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                                            quan += 1;
                                            tot = Convert.ToSingle(row.Cells["PerUnitGV"].Value.ToString()) * quan;
                                            row.Cells["QuantityGV"].Value = quan;
                                            if (row.Cells["DiscountGV"].Value.ToString() != null)
                                            {
                                                //discount = Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()) * Convert.ToSingle(row.Cells["QuantityGV"].Value.ToString());
                                                discount = Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()) + Convert.ToSingle(prodArr[4]);
                                                row.Cells["DiscountGV"].Value =Math.Round(discount,0);
                                            }
                                            row.Cells["TotGV"].Value = Math.Round(tot-discount,0);
                                            
                                        }
                                    }
                                }
                                else
                                {
                                    SalesdataGridView.Rows.Add(productID, prodArr[1], 1, Convert.ToSingle(prodArr[3]), prodArr[4], Convert.ToSingle(prodArr[5]));

                                }
                            }
                            foreach (DataGridViewRow row1 in SalesdataGridView.Rows)
                            {
                                gt += Convert.ToSingle(row1.Cells["TotGV"].Value.ToString());

                            }
                            GrossLbl.Text =Math.Round(gt,0).ToString();
                            gt = 0;
                            BarcodeTxt.Text = "";
                            BarcodeTxt.Focus();
                        }
                        
                    }
                    else
                    {
                        MainClass.ShowMSG("Product Price is not set for this product choose other one", "Error", "Error");
                        BarcodeTxt.Text = "";
                        BarcodeTxt.Focus();
                    }
                }
                else
                {
                    BarcodeTxt.Text = "";
                    BarcodeTxt.Focus();
                }
            }
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            if(SalesdataGridView.Rows.Count>0)
            {
                foreach (DataGridViewRow row in SalesdataGridView.Rows)
                {
                    discount += Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString());
                    gt += Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                }
                GrossTxt.Text = Math.Round(gt,0).ToString();
                TotDiscountTxt.Text = Math.Round(discount,0).ToString();
            }
        }

        private void SalesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex ==6)
                {
                    GrossTxt.Text = "";
                    TotDiscountTxt.Text = "";
                    AmountGiveTxt.Text = "";
                    ChangeGiveTxt.Text = "";
                    DataGridViewRow row = SalesdataGridView.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    if (q==1)
                    {
                        gt = Convert.ToSingle(GrossLbl.Text);
                        
                        gt = gt - Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                        GrossLbl.Text = Math.Round(gt,0).ToString();
                        SalesdataGridView.Rows.Remove(row);
                    }
                    else if(q>1)
                    {
                        q--;
                        row.Cells["QuantityGV"].Value = q;
                        //discount = Convert.ToSingle(row.Cells["QuantityGV"].Value.ToString()) * Convert.ToSingle(prodArr[4]);
                        discount = Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()) - Convert.ToSingle(prodArr[4]);
                        row.Cells["DiscountGV"].Value = Math.Round(discount,0);
                        tot = Convert.ToSingle(row.Cells["QuantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["PerUnitGV"].Value.ToString())-discount;
                        row.Cells["TotGV"].Value = Math.Round(tot,0);
                        foreach (DataGridViewRow row1 in SalesdataGridView.Rows)
                        {
                            gt += Convert.ToSingle(row1.Cells["TotGV"].Value.ToString());

                        }
                        GrossLbl.Text = Math.Round(gt,0).ToString();
                        gt = 0;
                    }

                }

            }
        }

        private void BarcodeTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
        Insertion i = new Insertion();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (AmountGiveTxt.Text != "" && TotDiscountTxt.Text!="" && GrossTxt.Text != "" && PaymentDD.SelectedIndex != -1 && ChangeGiveTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\tTotal Amount: "+GrossTxt.Text+"\n\tTotal Discount: "+TotDiscountTxt.Text+"\n\tAmount Given: "+AmountGiveTxt.Text+"\n\tAmount Returned: "+ChangeGiveTxt.Text+ "\n\nAre you sure, submit current sales?", "Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    i.insertSales(SalesdataGridView, "ProductIDGV", "QuantityGV", retrieval.USER_ID, DateTime.Now, Convert.ToSingle(GrossTxt.Text), Convert.ToSingle(TotDiscountTxt.Text), Convert.ToSingle(AmountGiveTxt.Text), Convert.ToSingle(ChangeGiveTxt.Text),PaymentDD.SelectedItem.ToString());
                    MainClass.enable_reset(PayGroupBox);
                    SalesdataGridView.Rows.Clear();
                    GrossLbl.Text = "0.00";
                    SalesReciept sr = new SalesReciept();
                    sr.Show();
                }
            }
        }

        private void AmountGiveTxt_TextChanged(object sender, EventArgs e)
        {
            if (AmountGiveTxt.Text != "")
            {
                if (!rg.Match(AmountGiveTxt.Text).Success)
                {
                    AmountGiveTxt.Text = "";
                    AmountGiveTxt.Focus();
                }
                else
                {
                    
                }
            }
            else
            {
                ChangeGiveTxt.Text = "";    
            }
        }
        private void AmountGiveTxt_Validating(object sender, CancelEventArgs e)
        {
            if (AmountGiveTxt.Text != "" && GrossTxt.Text != "")
            {
                if (!(Convert.ToSingle(GrossTxt.Text) <= Convert.ToSingle(AmountGiveTxt.Text)))
                {
                    AmountGiveTxt.Text = "";
                    AmountGiveTxt.Focus();
                }
                else
                {
                    float Given = Convert.ToSingle(AmountGiveTxt.Text);
                    float Return = Given - Convert.ToSingle(GrossTxt.Text);
                    ChangeGiveTxt.Text = Math.Round(Return,0).ToString();
                }
            }
        }
    }
}
