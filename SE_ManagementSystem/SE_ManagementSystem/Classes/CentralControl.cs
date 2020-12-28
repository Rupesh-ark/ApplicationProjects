using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SE_ManagementSystem
{
    enum AuthLevel
    {
        None,
        AdminLevel,
        CustomerLevel
    }

    internal class CentralControl
    {
        private static string path;

        public static void sNoInitiator(DataGridView dataGridView,string sno)
        {
            int count = 0;
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                count++;
                row.Cells[sno].Value = count;
            }
        }
        public static void ShowWindow(Form WinToOpen, Form WinToClose, Form MDI)
        {
            WinToClose.Close();
            WinToOpen.WindowState = FormWindowState.Maximized;
            WinToOpen.MdiParent = MDI;
            WinToOpen.Show();
        }

        public static void ShowWindow(Form WinToOpen, Form MDI)
        {
            WinToOpen.WindowState = FormWindowState.Maximized;
            WinToOpen.MdiParent = MDI;
            WinToOpen.Show();
        }

        public static void ShowAstrError(TextBox textBox, Label labelAstr)
        {
            if (textBox.Text == "")
                labelAstr.Visible = true;
            else
                labelAstr.Visible = false;
        }

        public static DialogResult ShowMSG(string msg, string type)
        {
            if (type == "Success")
                return MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (type == "Error")
                return MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (type == "Question")
                return MessageBox.Show(msg, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                return MessageBox.Show("Dunno how this happened", "Now What?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public static void ChangeStateReset(Panel panel, bool stat)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = stat;
                    textBox.Text = "";
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Enabled = stat;
                    comboBox.SelectedIndex = -1;
                }
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Enabled = stat;
                    radioButton.Checked = false;
                }
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Enabled = stat;
                    checkBox.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Enabled = stat;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Enabled = stat;
                }
            }
        }

        public static void ChangeState(Panel panel, bool stat)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = stat;
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Enabled = stat;
                }
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Enabled = stat;
                }
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Enabled = stat;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Enabled = stat;
                }

                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Enabled = stat;
                }
            }
        }

        public static void ChangeStateReset(GroupBox groupBox, bool stat)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = stat;
                    textBox.Text = "";
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Enabled = stat;
                    comboBox.SelectedIndex = -1;
                }
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Enabled = stat;
                    radioButton.Checked = false;
                }
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Enabled = stat;
                    checkBox.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Enabled = stat;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Enabled = stat;
                }
            }
        }

        public static bool CheckControls(Panel panel)
        {
            bool ch = false;

            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
            
                    ch = textBox.Text == "" ? false : true;
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
             
                    ch = comboBox.SelectedIndex == -1 ? false : true;
                }
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                
                    ch = radioButton.Checked == false ? false : true;
                }
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
             
                    ch = checkBox.Checked == false? false : true;
                }
            }

            return ch;
        }

        private static string ConnectionString()
        {
           path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\StockExchangeManagement_connect";
            
           if(File.Exists(path))            
               return File.ReadAllText(path);
            
           else
               return "";
        }

        public static SqlConnection con = new SqlConnection(ConnectionString());

    }
}