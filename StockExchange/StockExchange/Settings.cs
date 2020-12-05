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

namespace StockExchange
{
    public partial class Settings : TemplateForm
    {
        MainClass mainClassInst = new MainClass();
        public Settings()
        {
            InitializeComponent();
        }

        private void dataSourceText_TextChanged(object sender, EventArgs e)
        {
            if(dataSourceText.Text == "") {dataSourceError.Visible = true;}else{dataSourceError.Visible = false;}
        }

        private void databaseText_TextChanged(object sender, EventArgs e)
        {
            if (databaseText.Text == "") {databaseError.Visible = true;} else { databaseError.Visible = false;}
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (usernameText.Text == "") { usernameError.Visible = true; } else { usernameError.Visible = false; }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (passwordText.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if(isCV.Checked)
            {
                if (dataSourceText.Text == "") { dataSourceError.Visible = true; } else { dataSourceError.Visible = false; }
                if (databaseText.Text == "") { databaseError.Visible = true; } else { databaseError.Visible = false; }
                if (databaseError.Visible || dataSourceError.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + dataSourceText.Text + ";" + "Initial Catalog=" + databaseText.Text + ";" + "Integrated Security=true;MultipleActiveResultSets=true;");
                    File.WriteAllText(mainClassInst.path+"\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Saved Sucessfully.","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        mainClassInst.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (dataSourceText.Text == "") { dataSourceError.Visible = true; } else { dataSourceError.Visible = false; }
                if (databaseText.Text == "") { databaseError.Visible = true; } else { databaseError.Visible = false; }
                if (usernameText.Text == "") { usernameError.Visible = true; } else { usernameError.Visible = false; }
                if (passwordText.Text == "") { passwordError.Visible = true; } else { passwordError.Visible = false; }
                if (databaseError.Visible || dataSourceError.Visible || usernameError.Visible || passwordError.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + dataSourceText.Text + ";" + "Initial Catalog=" + databaseText.Text + ";" + "User ID="+usernameText.Text+";Password="+passwordText.Text+";MultipleActiveResultSets=true;");
                    File.WriteAllText(mainClassInst.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Saved Sucessfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        mainClassInst.showWindow(log, this, MDI.ActiveForm);
                    }
                }

            }
        }

        private void isCV_CheckedChanged(object sender, EventArgs e)
        {
            if(isCV.Checked)
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
    }
}
