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
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            base.AddBtn.Enabled = false;
            base.EditBtn.Enabled = false;
            base.SaveBtn.Enabled = false;
            base.DeleteBtn.Enabled = false;
            groupBox1.Visible = false;

        }
        
        retrieval r = new retrieval();
        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.showStock(StockdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, BuyPriceGV, SellPriceGV,CategoryGV, StockGV, StatusGV, TotGV);
        }
        
        
    }
}
