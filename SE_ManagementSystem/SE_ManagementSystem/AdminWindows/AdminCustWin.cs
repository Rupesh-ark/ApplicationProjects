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
    public partial class AdminCustWin : SecondSampleForm
    {
        public AdminCustWin()
        {
            InitializeComponent();
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(customerIDTxt, custIDErr);
            CentralControl.ShowAstrError(passwordTxt, passErr);
            CentralControl.ShowAstrError(customerNameTxt, nameErr);
            CentralControl.ShowAstrError(customerAddTxt, AddErr);
            CentralControl.ShowAstrError(customerMobTxt, numErr);

            if (custIDErr.Visible || passErr.Visible || nameErr.Visible || AddErr.Visible || numErr.Visible)
            {
                CentralControl.ShowMSG("Fields with * are mandatory", "Error");
            }
            else
            {
                if (edit == false)
                {
                    if (customerMobTxt.Text.Length == 10)
                    {
                        Insertion.InsertCustomers(customerIDTxt.Text, passwordTxt.Text, customerNameTxt.Text, customerAddTxt.Text, customerMobTxt.Text);
                        CentralControl.ChangeStateReset(left, false);
                        Retrival.GetCustomers(customerData, customerID, customerName, cusPass, customerAddress, customerNum);

                    }
                    else
                        CentralControl.ShowMSG("Enter Valid Mobile Number", "Error");
                }
                else 
                {
                    Updation.UpdateCustomer(customerIDTxt.Text, passwordTxt.Text, customerNameTxt.Text, customerAddTxt.Text, customerMobTxt.Text);
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetCustomers(customerData, customerID, customerName, cusPass, customerAddress, customerNum);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
         
          Retrival.GetCustomers(customerData, customerID, customerName, cusPass, customerAddress, customerNum);
            
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(delStatus)
            {
                if(CentralControl.ShowMSG("Are you sure you want to delete this record?", "Question") == DialogResult.Yes)
                {
                    Deletion.DeleteData("spDeleteCustomer", "@customerID", customerIDTxt.Text);
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetCustomers(customerData, customerID, customerName, cusPass, customerAddress, customerNum);
                }
            }
        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = true;
                delStatus = true;
                CentralControl.ChangeState(left, false);
                DataGridViewRow row = customerData.Rows[e.RowIndex];
                customerIDTxt.Text = row.Cells["customerID"].Value.ToString();
                customerNameTxt.Text = row.Cells["customerName"].Value.ToString();
                passwordTxt.Text = row.Cells["cusPass"].Value.ToString();
                customerAddTxt.Text = row.Cells["customerAddress"].Value.ToString();
                customerMobTxt.Text = row.Cells["customerNum"].Value.ToString();

            }
        }

        private void customerMobTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(customerMobTxt, numErr);
        }

        private void customerNameTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(customerNameTxt, nameErr);
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(passwordTxt, passErr);
        }

        private void customerAddTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(customerAddTxt, AddErr);
        }

        private void customerIDTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(customerIDTxt, custIDErr);
        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            AdminHomeWin adminHomeWin = new AdminHomeWin();
            CentralControl.ShowWindow(adminHomeWin, this, MDI.ActiveForm);
        }

    }
}
