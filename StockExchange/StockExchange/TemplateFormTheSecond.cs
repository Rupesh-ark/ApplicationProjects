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
    public partial class TemplateFormTheSecond : TemplateForm
    {
        public TemplateFormTheSecond()
        {
            InitializeComponent();
        }

        protected virtual void add_Click(object sender, EventArgs e)
        {

        }

        protected virtual void edit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void save_Click(object sender, EventArgs e)
        {

        }

        protected virtual void delete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void view_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}
