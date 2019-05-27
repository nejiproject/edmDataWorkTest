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
    public partial class fmAddWorker : Form
    {
        public fmAddWorker()
        {
            InitializeComponent();
        }


        private string name = "";
        private int age = 1;
        private string division = "";


        private void btOk_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            age = Convert.ToInt16(tbAge.Text);
            division = tbDivision.Text;



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

        public int GetAge()
        {
            return age;
        }

        public string GetDivision()
        {
            return division;
        }

    }
}
