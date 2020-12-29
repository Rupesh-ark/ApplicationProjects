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
    public partial class AdminBroWin : SecondSampleForm
    {
        public AdminBroWin()
        {
            InitializeComponent();
        }


        private void AdminBroWin_Load(object sender, EventArgs e)
        {
            Retrival.LoadItems("spStockExchange_GetName", seDropDown, "seName", "seName");
            seDropDown.SelectedItem = -1;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(brokerIDTxt, broIDErr);
            CentralControl.ShowAstrError(brokerNameTxt, broNameErr);
            CentralControl.ShowAstrError(passwordTxt, passErr);
            CentralControl.ShowAstrError(commisionTxt, commisionErr);
            

            if (broIDErr.Visible || broNameErr.Visible || passErr.Visible || commisionErr.Visible || seErr.Visible)
            {
                CentralControl.ShowMSG("Fields with * are mandatory", "Error");
            }
            else
            {
                if (edit == false)
                {
                    Insertion.InsertBrokers(brokerIDTxt.Text, brokerNameTxt.Text, passwordTxt.Text, Convert.ToInt64(commisionTxt.Text), seDropDown.Text);
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetBrokers(brokerDataSet, brokerID, brokerName,password, commision, seName);
                }
                else
                {
                    Updation.UpdateBrokers(brokerIDTxt.Text, brokerNameTxt.Text, passwordTxt.Text, Convert.ToInt64(commisionTxt.Text), seDropDown.Text); 
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetBrokers(brokerDataSet, brokerID, brokerName, password, commision, seName);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retrival.GetBrokers(brokerDataSet, brokerID, brokerName, password, commision, seName);
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus)
            {
                if (CentralControl.ShowMSG("Are you sure you want to delete this record?", "Question") == DialogResult.Yes)
                {
                    Deletion.DeleteData("spDeleteBroker", "@brokerID", brokerIDTxt.Text);
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetBrokers(brokerDataSet, brokerID, brokerName, password, commision, seName);
                }
            }
        }


        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(passwordTxt, passErr);
        }

        private void brokerNameTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(brokerNameTxt, broNameErr);
        }

        private void brokerIDTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(brokerIDTxt, broIDErr);
        }

        private void commisionTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(commisionTxt, commisionErr);
        }

        private void seDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seDropDown.SelectedIndex == -1)
            {
                seErr.Visible = true;
            }
            else
            {
                seErr.Visible = false;
            }
        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            AdminHomeWin adminHomeWin = new AdminHomeWin();
            CentralControl.ShowWindow(adminHomeWin, this, MDI.ActiveForm);
        }

        private void brokerDataSet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = true;
                delStatus = true;
                CentralControl.ChangeState(left, false);
                DataGridViewRow row = brokerDataSet.Rows[e.RowIndex];
                brokerIDTxt.Text = row.Cells["brokerID"].Value.ToString();
                brokerNameTxt.Text = row.Cells["brokerName"].Value.ToString();
                passwordTxt.Text = row.Cells["password"].Value.ToString();
                commisionTxt.Text = (Convert.ToInt32(row.Cells["commision"].Value)).ToString();
                seDropDown.SelectedValue = row.Cells["seName"].Value;

            }
        }
    }
}
