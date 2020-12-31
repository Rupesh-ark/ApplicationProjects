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
    public partial class CustPfpWin : SampleForm
    {
        public CustPfpWin()
        {
            InitializeComponent();
        }

        private void addBalanceBtn_Click(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(balanceTxt, balErr);
            if (balErr.Visible)
            {
                CentralControl.ShowMSG("Fields with * are necessary", "Error");
            }
            else
            {
                Updation.UpdateBalance(Retrival.LOGINID, Convert.ToInt32(balanceTxt.Text));
                Retrival.LoadItem(balance, "spCustBalanceSheet_GetBalance", "@customerID", Retrival.LOGINID, "balance");
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
            CentralControl.ShowAstrError(customerNameTxt, nameErr);
            CentralControl.ShowAstrError(mobileTxt, mobErr);
            if (mobErr.Visible || nameErr.Visible)
            {
                CentralControl.ShowMSG("Fields with * are necessary", "Error");
            }
            else
            {
                Updation.UpdateCustNameNum(Retrival.LOGINID, customerNameTxt.Text, mobileTxt.Text);
                Retrival.LoadItem(name, "spCustomer_GetIndividualGetName", "@ID", Retrival.LOGINID, "customerName");
                Retrival.LoadItem(mobileNumber, "spCustomer_GetIndividualGetNum", "@ID", Retrival.LOGINID, "customerNum");
            }
        }

        private void CustPfpWin_Load(object sender, EventArgs e)
        {

            Retrival.LoadItem(balance, "spCustBalanceSheet_GetBalance", "@customerID", Retrival.LOGINID, "balance");
            Retrival.LoadItem(name, "spCustomer_GetIndividualGetName", "@ID", Retrival.LOGINID, "customerName");
            Retrival.LoadItem(mobileNumber, "spCustomer_GetIndividualGetNum", "@ID", Retrival.LOGINID, "customerNum");

        }

        private void mobileTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(mobileTxt, mobErr);
        }

        private void customerNameTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(customerNameTxt, nameErr);
        }

        private void balanceTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(balanceTxt, balErr);
        }
    }
}
