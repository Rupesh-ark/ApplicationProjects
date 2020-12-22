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

namespace SE_ManagementSystem
{
    public partial class SettingsWin : SampleForm
    {
        private string connection;
        public SettingsWin()
        {
            InitializeComponent();
        }

        private void serverNameTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(serverNameTxt, serverNameError);
        }

        private void databaseNameTxt_TextChanged_1(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(databaseNameTxt, databaseError);
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (!isCV.Checked)
                CentralControl.ShowAstrError(usernameText, usernameError);
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (!isCV.Checked)
                CentralControl.ShowAstrError(passwordText, passwordError);
        }


        private void isCV_CheckedChanged(object sender, EventArgs e)
        {
            if (isCV.Checked)
            {
                usernameText.Text = "";
                usernameText.Enabled = false;

                passwordText.Text = "";
                passwordText.Enabled = false;
                usernameError.Visible = false;
                passwordError.Visible = false;
            }
            else
            {
                usernameText.Enabled = true;
                passwordText.Enabled = true;
            }
        }


        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\StockExchangeManagement_connect";
            File.WriteAllText(path, connection);
        }

        private void save_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (isCV.Checked)
            {
                CentralControl.ShowAstrError(serverNameTxt, serverNameError);
                CentralControl.ShowAstrError(databaseNameTxt, databaseError);
                if (databaseError.Visible || serverNameError.Visible)
                {
                    CentralControl.ShowMSG("Fields with * are mandatory", "Error");
                }
                else
                {
                    connection = "Data Source=" + serverNameTxt.Text
                               + ";Initial Catalog=" + databaseNameTxt.Text
                               + ";Integrated Security=true;MultipleActiveResultSets=true;";

                    saveConnection();
                    //    updateConfigFile(connection);
                    DialogResult dialogResult = MessageBox.Show("Settings Saved Successfully");
                    if (dialogResult == DialogResult.OK)
                    {
                        LoginWin loginScreen = new LoginWin();
                        CentralControl.ShowWindow(loginScreen, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                CentralControl.ShowAstrError(serverNameTxt, serverNameError);
                CentralControl.ShowAstrError(databaseNameTxt, databaseError);
                CentralControl.ShowAstrError(usernameText, usernameError);
                CentralControl.ShowAstrError(passwordText, passwordError);
                if (serverNameError.Visible || databaseError.Visible || usernameError.Visible || passwordError.Visible)
                {
                    CentralControl.ShowMSG("Fields with * are mandatory", "Error");
                }
                else
                {
                    connection = "Data Source=" + serverNameTxt.Text
                                + ";Initial Catalog=" + databaseNameTxt.Text
                                + ";User ID=" + usernameText.Text + ";Password=" + passwordText.Text + ";MultipleActiveResultSets=true;";
                    //   updateConfigFile(connection);
                    saveConnection();
                    DialogResult dialogResult = MessageBox.Show("Settings Saved Successfully");
                    if (dialogResult == DialogResult.OK)
                    {
                        LoginWin loginScreen = new LoginWin();
                        CentralControl.ShowWindow(loginScreen, this, MDI.ActiveForm);
                    }

                }

            }
        }
    }



}

