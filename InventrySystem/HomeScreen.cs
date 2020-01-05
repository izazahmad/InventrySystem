﻿using System;
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

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            UserDisplayLbl.Text = retrieval.EMP_NAME;
            MDI.logOutToolStripMenuItem.Enabled = true;
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
    }
}
