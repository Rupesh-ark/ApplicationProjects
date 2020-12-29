using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

namespace SE_ManagementSystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\StockExchangeManagement_connect"))
            {
                 SettingsWin settingsInstance = new SettingsWin();
                 CentralControl.ShowWindow(settingsInstance, this);
            }
            else
            {
                 LoginWin loginInstance = new LoginWin();
                 CentralControl.ShowWindow(loginInstance, this);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginWin loginInstance = new LoginWin();
            CentralControl.ShowWindow(loginInstance, this);
        }
    }
}
