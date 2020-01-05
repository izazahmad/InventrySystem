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
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sample_Load(object sender, EventArgs e)
        {
            if (retrieval.EMP_NAME != null && MDI.logOutToolStripMenuItem.Enabled==true)
            {
                UserDisplayLbl.Text = retrieval.EMP_NAME;
            }
            
        }
    }
}
