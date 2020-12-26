using System;
using System.Windows.Forms;

namespace SE_ManagementSystem
{
    public partial class AdminCompWin : SecondSampleForm
    {
        public AdminCompWin()
        {
            InitializeComponent();
        }

        private bool edit = false;
        private bool delStatus = false;
        private void AdminCompWin_Load(object sender, EventArgs e)
        {
            Retrival.LoadItems("spStockExchange_GetName", rolesDropDown, "seName", "seName");
            rolesDropDown.SelectedItem = -1;
        }


        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = false;
            CentralControl.ChangeStateReset(left, true);
            delStatus = false;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = true;
            CentralControl.ChangeState(left, true);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(companyIDTxt, compIDErr);
            CentralControl.ShowAstrError(companyNameTxt, companyNameErr);
            CentralControl.ShowAstrError(companyTypeTxt, companyTypeErr);
            CentralControl.ShowAstrError(marketCapitalTxt, marketCapErr);
            CentralControl.ShowAstrError(yearEstablishedTxt, establishedErr);

            if (compIDErr.Visible || companyNameErr.Visible || companyTypeErr.Visible || marketCapErr.Visible || establishedErr.Visible)
            {
                CentralControl.ShowMSG("Fields with * are mandatory", "Error");
            }
            else
            {
                if (edit == false)
                {
                    Insertion.InsertCompanies(companyIDTxt.Text, companyNameTxt.Text, companyTypeTxt.Text, Convert.ToInt32(marketCapitalTxt.Text), Convert.ToInt16(yearEstablishedTxt.Text),rolesDropDown.Text);
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetCompanies(companyDetails,companyID,companyName,companyType,marketCapital,yearEstablished,seName);
                }
                else
                {
                    Updation.UpdateCompany(companyIDTxt.Text, companyNameTxt.Text, companyTypeTxt.Text, Convert.ToInt32(marketCapitalTxt.Text), Convert.ToInt16(yearEstablishedTxt.Text));
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetCompanies(companyDetails, companyID, companyName, companyType, marketCapital, yearEstablished,seName);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retrival.GetCompanies(companyDetails, companyID, companyName, companyType, marketCapital, yearEstablished,seName);
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus)
            {
                if (CentralControl.ShowMSG("Are you sure you want to delete this record?", "Question") == DialogResult.Yes)
                {
                    Deletion.DeleteData("spDeleteCompany", "@companyID", companyIDTxt.Text);
                    CentralControl.ChangeStateReset(left, false);
                    Retrival.GetCustomers(companyDetails, companyID, companyName, companyType, marketCapital, yearEstablished);
                }
            }
        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {
        }

        private void customerData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = true;
                delStatus = true;
                CentralControl.ChangeState(left, false);
                DataGridViewRow row = companyDetails.Rows[e.RowIndex];
                companyIDTxt.Text = row.Cells["companyID"].Value.ToString();
                companyNameTxt.Text = row.Cells["companyName"].Value.ToString();
                companyTypeTxt.Text = row.Cells["companyType"].Value.ToString();
                marketCapitalTxt.Text = row.Cells["marketCapital"].Value.ToString();
                yearEstablishedTxt.Text = row.Cells["yearEstablished"].Value.ToString();
            }
        }

        private void companyIDTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(companyIDTxt, compIDErr);
        }

        private void companyNameTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(companyNameTxt, companyNameErr);
        }

        private void companyTypeTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(companyTypeTxt, companyTypeErr);
        }

        private void maketCapitalTxt_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(marketCapitalTxt, marketCapErr);
        }

        private void yearEstablishedErr_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(yearEstablishedTxt, establishedErr);
        }

        private void rolesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolesDropDown.SelectedIndex == -1)
            {
                stockExErr.Visible = true;
            }
            else
            {
                stockExErr.Visible = false;
            }
        }

        private void companyDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = true;
                delStatus = true;
                CentralControl.ChangeState(left, false);
                DataGridViewRow row = companyDetails.Rows[e.RowIndex];
                companyIDTxt.Text = row.Cells["companyID"].Value.ToString();
                companyNameTxt.Text = row.Cells["companyName"].Value.ToString();
                companyTypeTxt.Text = row.Cells["companyType"].Value.ToString();
                marketCapitalTxt.Text = (Convert.ToInt32(row.Cells["marketCapital"].Value)).ToString();
                yearEstablishedTxt.Text = (Convert.ToInt32(row.Cells["yearEstablished"].Value)).ToString();
                rolesDropDown.SelectedValue = row.Cells["seName"].Value; 
            }
        }
    }
}