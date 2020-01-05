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
            //base.AddBtn.Visible = false;
            //base.EditBtn.Visible = false;
            //base.SaveBtn.Visible = false;
            //base.DeleteBtn.Visible = false;
            
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {

        }
        public override void EditBtn_Click(object sender, EventArgs e)
        {

        }
        public override void SaveBtn_Click(object sender, EventArgs e)
        {

        }
        public override void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        retrieval r = new retrieval();
        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.showStock(StockdataGridView, ProductIDGV, NameGV, BarcodeGV, ExpiryGV, PriceGV, CategoryGV, StockGV, StatusGV, TotGV);
        }
    }
}
