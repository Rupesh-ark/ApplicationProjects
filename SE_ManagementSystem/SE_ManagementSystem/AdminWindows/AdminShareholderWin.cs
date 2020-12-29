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
    public partial class AdminShareholderWin : SampleForm
    {

        public static bool edit = false;
        public static bool delStatus = false;

        public AdminShareholderWin()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus)
            {
                if (CentralControl.ShowMSG("Are you sure you want to delete this record?", "Question") == DialogResult.Yes)
                {
                    Deletion.DeleteData("spDeleteShares", "@shareName", currBalanceTxt.Text);
                    CentralControl.ChangeStateReset(left, false);
  //                  Retrival.GetShares(stockDataSet, shareName, companyID, changeInPrice, openingPrice, volume, holdingsCost, holdingsQuantity);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            edit = true;
            CentralControl.ChangeState(left, true);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminShareholderWin_Load(object sender, EventArgs e)
        {
            welcomeText.Text = "Welcome to Shareholder Window";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminHomeWin adminHomeWin = new AdminHomeWin();
            CentralControl.ShowWindow(adminHomeWin, this, MDI.ActiveForm);
        }
    }
}
