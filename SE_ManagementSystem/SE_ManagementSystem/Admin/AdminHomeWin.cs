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
    public partial class AdminHomeWin : SampleForm
    {
        public AdminHomeWin()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            AdminCustWin adminCustWin = new AdminCustWin();
            CentralControl.ShowWindow(adminCustWin, this, MDI.ActiveForm);
        }

        private void brokers_Click(object sender, EventArgs e)
        {
            AdminBroWin adminBroWin = new AdminBroWin();
            CentralControl.ShowWindow(adminBroWin, this, MDI.ActiveForm);
        }

        private void transactions_Click(object sender, EventArgs e)
        {
            AdminTransWin adminTransWin = new AdminTransWin();
            CentralControl.ShowWindow(adminTransWin, this, MDI.ActiveForm);
        }

        private void companies_Click(object sender, EventArgs e)
        {
            AdminCompWin adminCompWin = new AdminCompWin();
            CentralControl.ShowWindow(adminCompWin, this, MDI.ActiveForm);
        }

        private void stocks_Click(object sender, EventArgs e)
        {
            AdminStockWin adminStockWin = new AdminStockWin();
            CentralControl.ShowWindow(adminStockWin, this, MDI.ActiveForm);
        }

        private void chart_Click(object sender, EventArgs e)
        {
            AdminChartWin adminChartWin = new AdminChartWin();
            CentralControl.ShowWindow(adminChartWin, this, MDI.ActiveForm);
        }
    }
}
