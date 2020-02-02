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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameErrorLbl.Visible = true;
            }
            else
            {
                usernameErrorLbl.Visible = false;
            }
            if (pwdTxt.Text == "")
            {
                PasswordErrorLbl.Visible = true;
            }
            else
            {
                PasswordErrorLbl.Visible = false;
            }
            if(usernameErrorLbl.Visible || PasswordErrorLbl.Visible)
            {
                MainClass.ShowMSG("Fileds with * are mandatory", "Stop", "Error");
            }
            if (usernameTxt.Text != "" && pwdTxt.Text != "")
            {
                if(retrieval.getUserDetails(usernameTxt.Text,pwdTxt.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);
                    

                }
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                usernameErrorLbl.Visible = true;
            }
            else
            {
                usernameErrorLbl.Visible = false;
            }
        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {
            if (pwdTxt.Text == "")
            {
                PasswordErrorLbl.Visible = true;
            }
            else
            {
                PasswordErrorLbl.Visible = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //MDI mdi = new MDI();
            //if (retrieval.USER_ID == 0)
            //{
            //    mdi.logOutToolStripMenuItem.Enabled = false;
            //}

        }
    }
}
