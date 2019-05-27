using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edmDataWorkTest
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void divisionSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataWorkDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataWorkDataSet.WorkerSet' table. You can move, or remove it, as needed.
            this.workerSetTableAdapter.Fill(this.dataWorkDataSet.WorkerSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.DivisionSet' table. You can move, or remove it, as needed.
            this.divisionSetTableAdapter.Fill(this.dataWorkDataSet.DivisionSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.WorkerSet' table. You can move, or remove it, as needed.
            this.workerSetTableAdapter.Fill(this.dataWorkDataSet.WorkerSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.DivisionSet' table. You can move, or remove it, as needed.
            this.divisionSetTableAdapter.Fill(this.dataWorkDataSet.DivisionSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.WorkerSet' table. You can move, or remove it, as needed.
            this.workerSetTableAdapter.Fill(this.dataWorkDataSet.WorkerSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.DivisionSet' table. You can move, or remove it, as needed.
            this.divisionSetTableAdapter.Fill(this.dataWorkDataSet.DivisionSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.DivisionSet' table. You can move, or remove it, as needed.
            this.divisionSetTableAdapter.Fill(this.dataWorkDataSet.DivisionSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.WorkerSet' table. You can move, or remove it, as needed.
            this.workerSetTableAdapter.Fill(this.dataWorkDataSet.WorkerSet);
            // TODO: This line of code loads data into the 'dataWorkDataSet.DivisionSet' table. You can move, or remove it, as needed.
            this.divisionSetTableAdapter.Fill(this.dataWorkDataSet.DivisionSet);

        }

        private void divisionSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataWorkDataSet);

        }

        private void divisionSetBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataWorkDataSet);

        }

        private void divisionSetBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataWorkDataSet);

        }

        private void divisionSetBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.divisionSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataWorkDataSet);

        }



        private void btAddDivision_Click(object sender, EventArgs e)
        {
            var fmAddDivision = new fmAddDivision();
            fmAddDivision.ShowDialog();
            using (Model1Container db = new Model1Container())
            {
                Division div1 = new Division();
                div1.Name = fmAddDivision.GetResult();
                db.DivisionSet.Add(div1);
                db.SaveChanges();
            }
        }


        private void btRemove_Click(object sender, EventArgs e)
        {
           fmRemove fmRemove = new fmRemove();
           fmRemove.ShowDialog();


           Model1Container db = new Model1Container();
           Division div1 = new Division
           {
               DivisionId = fmRemove.GetResult()
           };


           db.DivisionSet.Attach(div1);
           db.DivisionSet.Remove(div1);
           db.SaveChanges();
        }

        private void btChanfeDivision_Click(object sender, EventArgs e)
        {
            fmChangeDivision fmChangeDivision = new fmChangeDivision();
            fmChangeDivision.ShowDialog();

            string OldName = fmChangeDivision.GetOldName();
            string NewName = fmChangeDivision.GetNewName();


            Model1Container db = new Model1Container();
            Division div1 = db.DivisionSet.Where(n => n.Name == OldName).FirstOrDefault();

            div1.Name = NewName;

            db.SaveChanges();


        }

        private void btAddWorker_Click(object sender, EventArgs e)
        {
            fmAddWorker fmAddWorker = new fmAddWorker();
            fmAddWorker.ShowDialog();

            string name = fmAddWorker.GetName();
            int Age = fmAddWorker.GetAge();
            string division = fmAddWorker.GetDivision();



            Model1Container db = new Model1Container();
            Division div = db.DivisionSet.Where(n => n.Name == division).FirstOrDefault();



            Worker wk1 = new Worker
            {

                Name = name,
                Age = (short) Age,
                Division = div

            };

                db.WorkerSet.Add(wk1);
                db.SaveChanges();

        }

        private void RemoveWorker_Click(object sender, EventArgs e)
        {

            fmRemoveWorker fmRemoveWorker = new fmRemoveWorker();
            fmRemoveWorker.ShowDialog();

            string name = fmRemoveWorker.GetName();

            Model1Container db = new Model1Container();

            Worker wk1 = db.WorkerSet.Where(n => n.Name == name).FirstOrDefault();

 
            db.WorkerSet.Remove(wk1);
            db.SaveChanges();


        }

        private void btChangeWorker_Click(object sender, EventArgs e)
        {

            fmChangeWorker fmChangeWorker = new fmChangeWorker();
            fmChangeWorker.ShowDialog();

            string OldName = fmChangeWorker.GetOldName();
            string NewName = fmChangeWorker.GetNewName();
            short age = (short) fmChangeWorker.GetAge();
            int divId = fmChangeWorker.GetDivId();


            Model1Container db = new Model1Container();


            Division div1 = db.DivisionSet.Where(n => n.DivisionId == divId).FirstOrDefault();

            Worker wk1 = db.WorkerSet.Where(n => n.WorkerId == divId).FirstOrDefault();



                wk1.Name = NewName;
                wk1.Age = age;


                wk1.Division = div1;
            db.SaveChanges();


        }
    }
}
