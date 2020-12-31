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
    public partial class CustOrderWindow : SampleForm
    {


        public CustOrderWindow()
        {
            InitializeComponent();
        }

        private void generateBill_Click(object sender, EventArgs e)
        {

        }

        private void finishTransaction_Click(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(quantityToBuy, quantityErr);
            if (Convert.ToInt32(quantityToBuy.Text) > Convert.ToInt32(quantityAvailable.Text))
            {
                CentralControl.ShowMSG("You cannot buy more than available", "error");
            }
            else
            {
                if(quantityErr.Visible || shareToBuyErr.Visible || brokerToBuyFromErr.Visible)
                {
                    CentralControl.ShowMSG("Fields with * are necessary", "Error");
                }
                else
                {
                    Int16 updatedQuantity = Convert.ToInt16(Convert.ToInt16(quantityAvailable.Text) - Convert.ToInt16(quantityToBuy.Text));
                    Retrival.LoadItem(balance, "spCustBalanceSheet_GetBalance", "@customerID", Retrival.LOGINID, "balance");
                    Decimal nBalance = Convert.ToDecimal(balance.Text);
                    Decimal nTotalAmount = Convert.ToDecimal(totalAmount.Text);
                    Decimal nQuantityToBuy = Convert.ToDecimal(quantityToBuy.Text);
                    if ( nBalance > nTotalAmount)
                    {
                        Insertion.InsertShareholder(Retrival.LOGINID, shareToBuy.Text, (int)nTotalAmount, (int)nQuantityToBuy , brokerToBuyFrom.Text);
                        Updation.UpdateSharesHoldingQuantity(shareToBuy.Text, updatedQuantity);
                        Updation.UpdateBalance(Retrival.LOGINID, (int)(nBalance - nTotalAmount));
                        Retrival.LoadItem(balance, "spCustBalanceSheet_GetBalance", "@customerID", Retrival.LOGINID, "balance");
                        Retrival.LoadItem(quantityAvailable, "spShares_GetShareQuantityIndi", "@shareName", shareToBuy.Text, "holdingsQuantity");

                    }
                    else
                    {
                        CentralControl.ShowMSG("You don't have sufficient balance to buy the stocks", "Error");
                    }

                }
            }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            CentralControl.ChangeStateReset(right, true);
        }

        private void shareToBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Retrival.LoadItem(commisionAdded, "spBroker_GetBrokerCommision", "@ID", brokerToBuyFrom.Text, "commision");
            Retrival.LoadItem(quantityAvailable, "spShares_GetShareQuantityIndi", "@shareName", shareToBuy.Text, "holdingsQuantity");
            
            if (shareToBuy.SelectedIndex == -1)
            {
                shareToBuyErr.Visible = true;
            }
            else
            {
                shareToBuyErr.Visible = false;
            }

            Retrival.LoadItem(stockPrice, "spShares_GetSharePriceIndi", "@shareName", shareToBuy.Text, "sharePrice");
           
        }

        private void brokerToBuyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Retrival.LoadItem(commisionAdded, "spBroker_GetBrokerCommision", "@ID", brokerToBuyFrom.Text, "commision");
            if (brokerToBuyFrom.SelectedIndex == -1)
            {
                brokerToBuyFromErr.Visible = true;
            }
            else
            {
                brokerToBuyFromErr.Visible = false;
            }
            
        }

        private void CustOrderWindow_Load(object sender, EventArgs e)
        {
            CentralControl.ChangeState(right, false);
            Retrival.LoadItems("spShares_GetShareName", shareToBuy, "shareName", "shareName");
            Retrival.LoadItems("spBroker_GetID", brokerToBuyFrom, "brokerID", "brokerID");
            Retrival.LoadItem(balance,"spCustBalanceSheet_GetBalance","@customerID",Retrival.LOGINID,"balance");
        }

        private void quantityToBuy_TextChanged(object sender, EventArgs e)
        {
            CentralControl.ShowAstrError(quantityToBuy, quantityErr);
            decimal quant;
            try
            {
                if (quantityToBuy.Text != "")
                {
                    quant = Convert.ToDecimal(quantityToBuy.Text);
                }
                else
                {
                    quant = 0;

                }
                decimal stPrice = Convert.ToDecimal(stockPrice.Text);
                decimal comm = Convert.ToDecimal(commisionAdded.Text);
                totalAmount.Text = ((quant * stPrice) + comm).ToString();

            }
            catch (Exception T)
            {

                CentralControl.ShowMSG(T.Message, "Error");
            }
        }
    }
}
