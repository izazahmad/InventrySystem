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
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        string[] prodArr = new string[4];
        int productID;
        float gt, tot;
        

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void BarcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if (BarcodeTxt.Text != "")
            {
                prodArr = r.getProductByBarcodeList(BarcodeTxt.Text);
                productID = Convert.ToInt32(prodArr[0]);
                if (SalesdataGridView.Rows.Count == 0)
                {
                    SalesdataGridView.Rows.Add(productID, prodArr[1], 1, prodArr[2], prodArr[2]);
                    gt = 0;
                    foreach (DataGridViewRow row1 in SalesdataGridView.Rows)
                    {
                        gt += Convert.ToSingle(row1.Cells["TotGV"].Value.ToString());

                    }
                    GrossLbl.Text = gt.ToString();
                    BarcodeTxt.Text = "";
                    BarcodeTxt.Focus();
                    Array.Clear(prodArr, 0, prodArr.Length);

                }
                else
                {
                    foreach (DataGridViewRow row in SalesdataGridView.Rows)
                    {
                        if (row.Cells["ProductIDGV"].Value.ToString() == productID.ToString())
                        {

                            int quan = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                            quan += 1;
                            tot = Convert.ToSingle(row.Cells["PerUnitGV"].Value.ToString()) * quan;
                            row.Cells["QuantityGV"].Value = quan;
                            row.Cells["TotGV"].Value = tot;
                            foreach (DataGridViewRow row1 in SalesdataGridView.Rows)
                            {
                                gt += Convert.ToSingle(row1.Cells["TotGV"].Value.ToString());

                            }
                            GrossLbl.Text = gt.ToString();
                            tot = 0;
                            quan = 0;
                            gt = 0;
                            BarcodeTxt.Text = "";
                            BarcodeTxt.Focus();
                            Array.Clear(prodArr, 0, prodArr.Length);


                        }
                        else
                        {
                            SalesdataGridView.Rows.Add(productID, prodArr[1], 1, prodArr[2], prodArr[2]);
                            gt = 0;
                            foreach (DataGridViewRow row1 in SalesdataGridView.Rows)
                            {
                                gt += Convert.ToSingle(row1.Cells["TotGV"].Value.ToString());

                            }
                            GrossLbl.Text = gt.ToString();
                            BarcodeTxt.Text = "";
                            
                            BarcodeTxt.Focus();
                            Array.Clear(prodArr, 0, prodArr.Length);

                        }


                    }
                }
                
            }
            else
            {
                productID = 0;
                BarcodeTxt.Text = "";
                Array.Clear(prodArr, 0, prodArr.Length);
            }
        }

        private void BarcodeTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
