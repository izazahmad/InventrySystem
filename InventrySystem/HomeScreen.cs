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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void CatogoryBtn_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }
        //MDI mdi = new MDI();
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            //MDI mdi = new MDI();
            UserDisplayLbl.Text = retrieval.EMP_NAME;
            MDI.logoutToolStripMenuItem.Enabled = true;
            MDI.homeToolStripMenuItem.Enabled = true;
            int admin = retrieval.Role;
            if (admin==1)
            {
                StockBtn.Enabled = true;
                StockBtn.Visible = true;
                PurchaseInvoiceBtn.Enabled = true;
                PurchaseInvoiceBtn.Visible = true;
                productBtn.Enabled = true;
                productBtn.Visible = true;
                CatogoryBtn.Enabled = true;
                CatogoryBtn.Visible = true;
                SupplierBtn.Enabled = true;
                SupplierBtn.Visible = true;
                proPricingBtn.Enabled = true;
                proPricingBtn.Visible = true;
                userBtn.Enabled = true;
                userBtn.Visible = true;

            }
            //mdi.Controls["logOutToolStripMenuItem"].Enabled = true;
            //MDI.mdiObj.homeToolStripMenuItem.Enabled = true;

        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice p = new PurchaseInvoice();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void StockBtn_Click(object sender, EventArgs e)
        {
            Stocks s = new Stocks();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void proPricingBtn_Click(object sender, EventArgs e)
        {
            ProductPricing p = new ProductPricing();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void SalesReturnBtn_Click(object sender, EventArgs e)
        {
            SalesReturnWindow sr = new SalesReturnWindow();
            MainClass.showWindow(sr,this,MDI.ActiveForm);
        }
    }
}
