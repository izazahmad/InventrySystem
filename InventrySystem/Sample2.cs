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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }
        private void Sample2_Load(object sender, EventArgs e)
        {

        }
        public virtual void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        public virtual void AddBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void EditBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        

        public virtual void ViewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
