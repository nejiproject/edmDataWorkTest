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
    public partial class fmRemoveWorker : Form
    {
        public fmRemoveWorker()
        {
            InitializeComponent();
        }

        private string name = "";

        private void btOk_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            Close();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetName()
        {
            return name;
        }


    }
}
