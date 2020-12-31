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
    public partial class CustStockWin : SecondSampleForm
    {
        public CustStockWin()
        {
            InitializeComponent();
        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            CustHomeWin custHomeWin = new CustHomeWin();
            CentralControl.ShowWindow(custHomeWin, this, MDI.ActiveForm);
        }

    }
}
