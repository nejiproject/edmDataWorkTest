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
    public partial class fmRemove : Form
    {
        public fmRemove()
        {
            InitializeComponent();
        }

        private int result = 0;

        private void btOk_Click(object sender, EventArgs e)
        {
            result = Convert.ToInt32(tbText.Text);
            Close();
        }
   

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        public int GetResult()
        {
            return result;
        }

       
    }
}
