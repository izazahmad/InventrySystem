using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventrySystem
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", InvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            PurchasedataGridView.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", InvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);

        }

        private void InvoiceDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InvoiceDD.SelectedIndex != -1 && InvoiceDD.SelectedIndex != 0)
            {
                float gt = 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(InvoiceDD.SelectedValue.ToString()),PurchasedataGridView,PIDGV ,ProductIDGV, NameGV, PerUnitGV, QuantityGV, TotGV);
                foreach (DataGridViewRow row in PurchasedataGridView.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["TotGV"].Value.ToString());

                }
                GrossLbl.Text = gt.ToString();
                gt = 0;
            }
        }
        Insertion i = new Insertion();
        Updation u = new Updation();
        Deletion d = new Deletion();
        private void PurchasedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                
                    if (e.ColumnIndex == 6)
                    {
                        DataGridViewRow row = PurchasedataGridView.Rows[e.RowIndex];
                        DialogResult dr = MessageBox.Show("Are you sure, you want to delete " + row.Cells["NameGV"].Value.ToString() + " from purchase invoice?\n\t\tWARNING\nDELETION OF PRODUCT WILL EFFECT STOCK", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            using (TransactionScope sc = new TransactionScope())
                            {
                                i.insertDeletedItem(Convert.ToInt64(InvoiceDD.SelectedValue.ToString()), retrieval.USER_ID, Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), DateTime.Today);
                                object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()));
                                int q = Convert.ToInt32(ob);
                                if (ob != null)
                                {
                                    q -= Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString());
                                    u.UpdateStock(Convert.ToInt32(row.Cells["ProductIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()));
                                    float tot = Convert.ToSingle(GrossLbl.Text) - Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                                    GrossLbl.Text = tot.ToString();
                                    d.delete(Convert.ToInt64(row.Cells["PIDGV"].Value.ToString()), "st_deleteProductFromPID", "@PID");
                                    PurchasedataGridView.Rows.Remove(row);

                                }
                                sc.Complete();
                            }


                        }
                    }
                
            }
        }
    }
}
