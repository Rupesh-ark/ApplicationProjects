using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_ManagementSystem
{
    public partial class LoginWin : SampleForm
    {
        public LoginWin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(passwordText, passErr);
            AdminHomeWin adminHomeWin = new AdminHomeWin();
            if(usernameErr.Visible|| passErr.Visible)
            {
                CentralControl.ShowMSG("Fields with * cannot be left blank", "Error");
            }
            else
            {   
                if(Retrival.IsValidUser(usernameText.Text,passwordText.Text) && (Retrival.AUTH == AuthLevel.AdminLevel))
                {
                    CentralControl.ShowWindow(adminHomeWin, this, MDI.ActiveForm);
                }
                
            }
                
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(passwordText, passErr);
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(usernameText, usernameErr);
        }
    }
}
