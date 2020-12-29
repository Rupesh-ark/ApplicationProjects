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
    public partial class AdminStockWin : SecondSampleForm
    {
        public AdminStockWin()
        {
            InitializeComponent();
        }

        private void AdminStockWin_Load(object sender, EventArgs e)
        {
            Retrival.LoadItems("spCompany_GetCompanyID", IDDrop, "companyID", "companyID");
            IDDrop.SelectedItem = -1;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(shareNameTxt, shareNameErr);
            CentralControl.ShowAstrError(holdingsQuantityTxt, holdingCostErr);
            CentralControl.ShowAstrError(openingPriceTxt, openingErr);
            CentralControl.ShowAstrError(holdingsCostTxt, holdingCostErr);
            CentralControl.ShowAstrError(volumeTxt, volumeErr);

            if (shareNameErr.Visible || holdingCostErr.Visible || openingErr.Visible || quantityErr.Visible || volumeErr.Visible||IDErr.Visible)
            {
                CentralControl.ShowMSG("Fields with * are mandatory", "Error");
            }
            else
            {
                if (edit == false)
                {
                    Insertion.InsertShares(shareNameTxt.Text,IDDrop.Text, Convert.ToInt32(openingPriceTxt.Text), Convert.ToInt16(volumeTxt.Text), Convert.ToInt32(holdingsCostTxt.Text), Convert.ToInt16(holdingsQuantityTxt.Text));
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetShares(stockDataSet, shareName, companyID, changeInPrice,openingPrice,volume,holdingsCost,holdingsQuantity);
                }
                else
                {
                    Updation.UpdateShares(shareNameTxt.Text, IDDrop.Text, Convert.ToInt32(openingPriceTxt.Text), Convert.ToInt16(volumeTxt.Text), Convert.ToInt32(holdingsCostTxt.Text), Convert.ToInt16(holdingsQuantityTxt.Text));
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetShares(stockDataSet, shareName, companyID, changeInPrice, openingPrice, volume, holdingsCost, holdingsQuantity);
                }
            }



        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus)
            {
                if (CentralControl.ShowMSG("Are you sure you want to delete this record?", "Question") == DialogResult.Yes)
                {
                    Deletion.DeleteData("spDeleteShares", "@shareName", shareNameTxt.Text);
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetShares(stockDataSet, shareName, companyID, changeInPrice, openingPrice, volume, holdingsCost, holdingsQuantity);
                }
            }

        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retrival.GetShares(stockDataSet, shareName, companyID, changeInPrice, openingPrice, volume, holdingsCost, holdingsQuantity);

        }


        private void holdingQuantityTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(holdingsQuantityTxt,quantityErr);
        }

        private void IDDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IDDrop.SelectedIndex == -1)
            {
                IDErr.Visible = true;
            }
            else
            {
                IDErr.Visible = false;
            }
        }

        private void openingPriceTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(openingPriceTxt, openingErr);

        }

        private void volumeTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(volumeTxt, volumeErr);
        }

        private void holdingCostTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(holdingsCostTxt, holdingCostErr);
        }

        private void shareNameTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(shareNameTxt, shareNameErr);
        }

        private void stockDataSet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = true;
                delStatus = true;
                CentralControl.ChangeState(left, false);
                DataGridViewRow row = stockDataSet.Rows[e.RowIndex];
                shareNameTxt.Text = row.Cells["shareName"].Value.ToString();
                IDDrop.SelectedValue = row.Cells["companyID"].Value;
                openingPriceTxt.Text = (Convert.ToInt32(row.Cells["openingPrice"].Value)).ToString();
                holdingsCostTxt.Text = (Convert.ToInt32(row.Cells["holdingsCost"].Value)).ToString();
                volumeTxt.Text = (Convert.ToInt16(row.Cells["volume"].Value)).ToString();
                holdingsQuantityTxt.Text = (Convert.ToInt16(row.Cells["holdingsQuantity"].Value)).ToString();
                

            }
        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            AdminHomeWin adminHomeWin = new AdminHomeWin();
            CentralControl.ShowWindow(adminHomeWin, this, MDI.ActiveForm);
        }
    }
}
