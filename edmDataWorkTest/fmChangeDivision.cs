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
    public partial class fmChangeDivision : Form
    {
        public fmChangeDivision()
        {
            InitializeComponent();
        }

        private string OldName = "";
        private string NewName = "";

        private void btOk_Click(object sender, EventArgs e)
        {
            OldName = tbOldName.Text;
            NewName = tbNewName.Text;


            Close();
        }



        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetOldName()
        {
            return OldName;
        }

        public string GetNewName()
        {
            return NewName;
        }

    }
}
