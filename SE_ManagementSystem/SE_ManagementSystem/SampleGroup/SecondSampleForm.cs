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
    public partial class SecondSampleForm : SampleIntermediate
    {
        public SecondSampleForm()
        {
            InitializeComponent();
        }

        public static bool edit = false;
        public static bool delStatus = false;

        public virtual void addBtn_Click(object sender, EventArgs e)
        {
            edit = false;
            CentralControl.ChangeStateReset(left, true);
            delStatus = false;
        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {
            edit = true;
            CentralControl.ChangeState(left, true);
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void viewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
