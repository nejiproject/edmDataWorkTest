using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edmDataWorkTest
{
    public partial class fmAddDivision : Form
    {
        public fmAddDivision()
        {
            InitializeComponent();
        }


        private string result = "";


        private void btAdd_Click(object sender, EventArgs e)
        {
            result = tbAddDivision.Text;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetResult()
        {
            return result;
        }

    }
}
