using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventrySystem
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(IntSecChb.Checked)
            { 
                if(ServerTxt.Text != "" && DatabaseTxt.Text !="")
                {
                    s = "Data Source=" + ServerTxt.Text + ";initial Catalog=" + DatabaseTxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(path+"//connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        bool admincheck = retrieval.checkAdminExist();
                        if (admincheck==true)
                        {
                            Login log = new Login();
                            MainClass.showWindow(log, this, MDI.ActiveForm);
                        }
                        else
                        {
                            AdminEntry adm = new AdminEntry();
                            MainClass.showWindow(adm, this, MDI.ActiveForm);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please give information to continue..");
                }
            }
            else
            {
                if(ServerTxt.Text != "" && DatabaseTxt.Text != "" && UserIDTxt.Text!="" && PasswordTxt.Text != "")
                {
                    s = "Data Source=" + ServerTxt.Text + ";initial Catalog=" + DatabaseTxt.Text + ";User ID="+UserIDTxt.Text+";Password="+PasswordTxt.Text+ ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path+"//connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }

                }
                else
                {
                    MessageBox.Show("Please give information to continue..");
                }
            }
            
        }

        private void IntSecChb_CheckedChanged(object sender, EventArgs e)
        {
            if(IntSecChb.Checked)
            {
                UserIDTxt.Enabled = false;
                PasswordTxt.Enabled = false;
                UserIDTxt.Text = "";
                PasswordTxt.Text = "";
            }
            else
            {
                UserIDTxt.Enabled = true;
                PasswordTxt.Enabled = true;
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            UserDisplayLbl.Text = "";

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.showWindow(log, this, MDI.ActiveForm);
        }
    }
}
