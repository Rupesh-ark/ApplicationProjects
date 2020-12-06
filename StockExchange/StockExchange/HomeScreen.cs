using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockExchange
{
    public partial class HomeScreen : TemplateForm
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            Customers cstms = new Customers();
            MainClass.showWindow(cstms, this, MDI.ActiveForm);
        }

        private void brokers_Click(object sender, EventArgs e)
        {
            Broker brk = new Broker();
            MainClass.showWindow(brk, this, MDI.ActiveForm);
        }

        private void stocks_Click(object sender, EventArgs e)
        {
            Stocks stk = new Stocks();
            MainClass.showWindow(stk, this, MDI.ActiveForm);
        }

        private void transactions_Click(object sender, EventArgs e)
        {
            Transactions trans = new Transactions();
            MainClass.showWindow(trans, this, MDI.ActiveForm);
        }
    }
}
