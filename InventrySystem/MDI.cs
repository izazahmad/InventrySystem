using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventrySystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            //IsMdiContainer = true;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path+"\\connect"))
            {
                Login log = new Login();
                MainClass.showWindow(log, this);
            }
            else
            {
                settings set = new settings();
                MainClass.showWindow(set, this);
            }
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            MainClass.showWindow(set, this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOutToolStripMenuItem.Enabled = false;
            
            Login set = new Login();
            MainClass.showWindow(set, this);
            
        }
    }
}
