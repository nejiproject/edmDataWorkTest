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
    public partial class fmChangeWorker : Form
    {
        public fmChangeWorker()
        {
            InitializeComponent();
        }

        private string oldName = "";
        private string newName = "";
        private int Age = 0;
        private int divID = 0;

        private void btOk_Click(object sender, EventArgs e)
        {
            oldName = tbOldName.Text;
            newName = tbNewName.Text;
            Age = Convert.ToInt32(tbAge.Text);
            divID = Convert.ToInt32(tbID.Text);


            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        public string GetOldName()
        {
            return oldName;
        }

        public string GetNewName()
        {
            return newName;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetDivId()
        {
            return divID;
        }







    }
}
