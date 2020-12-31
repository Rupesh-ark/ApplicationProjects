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
    public partial class CustHomeWin : SampleForm
    {
        public CustHomeWin()
        {
            InitializeComponent();
        }

        private void stocksBtn_Click(object sender, EventArgs e)
        {
            CustStockWin custStockWin = new CustStockWin();
            CentralControl.ShowWindow(custStockWin, this, MDI.ActiveForm);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            CustPfpWin custPfpWin = new CustPfpWin();
            CentralControl.ShowWindow(custPfpWin, this, MDI.ActiveForm);
        }

        private void order_Click(object sender, EventArgs e)
        {
            CustOrderWindow custOrderWindow = new CustOrderWindow();
            CentralControl.ShowWindow(custOrderWindow, this, MDI.ActiveForm);
        }
    }
}
