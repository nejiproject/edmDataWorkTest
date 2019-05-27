namespace edmDataWorkTest
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btAddDivision = new System.Windows.Forms.Button();
            this.dataWorkDataSet = new edmDataWorkTest.DataWorkDataSet();
            this.divisionSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divisionSetTableAdapter = new edmDataWorkTest.DataWorkDataSetTableAdapters.DivisionSetTableAdapter();
            this.tableAdapterManager = new edmDataWorkTest.DataWorkDataSetTableAdapters.TableAdapterManager();
            this.workerSetTableAdapter = new edmDataWorkTest.DataWorkDataSetTableAdapters.WorkerSetTableAdapter();
            this.divisionSetGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.workerSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerSetGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btChanfeDivision = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAddWorker = new System.Windows.Forms.Button();
            this.btChangeWorker = new System.Windows.Forms.Button();
            this.RemoveWorker = new System.Windows.Forms.Button();
            this.lbTableNameDivision = new System.Windows.Forms.Label();
            this.lbTableNameWorker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddDivision
            // 
            this.btAddDivision.Location = new System.Drawing.Point(114, 474);
            this.btAddDivision.Name = "btAddDivision";
            this.btAddDivision.Size = new System.Drawing.Size(75, 23);
            this.btAddDivision.TabIndex = 3;
            this.btAddDivision.Text = "Добавить...";
            this.btAddDivision.UseVisualStyleBackColor = true;
            this.btAddDivision.Click += new System.EventHandler(this.btAddDivision_Click);
            // 
            // dataWorkDataSet
            // 
            this.dataWorkDataSet.DataSetName = "DataWorkDataSet";
            this.dataWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // divisionSetBindingSource
            // 
            this.divisionSetBindingSource.DataMember = "DivisionSet";
            this.divisionSetBindingSource.DataSource = this.dataWorkDataSet;
            // 
            // divisionSetTableAdapter
            // 
            this.divisionSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DivisionSetTableAdapter = this.divisionSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = edmDataWorkTest.DataWorkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerSetTableAdapter = this.workerSetTableAdapter;
            // 
            // workerSetTableAdapter
            // 
            this.workerSetTableAdapter.ClearBeforeFill = true;
            // 
            // divisionSetGridControl
            // 
            this.divisionSetGridControl.DataSource = this.divisionSetBindingSource;
            this.divisionSetGridControl.Location = new System.Drawing.Point(12, 40);
            this.divisionSetGridControl.MainView = this.gridView1;
            this.divisionSetGridControl.Name = "divisionSetGridControl";
            this.divisionSetGridControl.Size = new System.Drawing.Size(339, 410);
            this.divisionSetGridControl.TabIndex = 6;
            this.divisionSetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.divisionSetGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // workerSetBindingSource
            // 
            this.workerSetBindingSource.DataMember = "WorkerSet";
            this.workerSetBindingSource.DataSource = this.dataWorkDataSet;
            // 
            // workerSetGridControl
            // 
            this.workerSetGridControl.DataSource = this.workerSetBindingSource;
            this.workerSetGridControl.Location = new System.Drawing.Point(375, 40);
            this.workerSetGridControl.MainView = this.gridView2;
            this.workerSetGridControl.Name = "workerSetGridControl";
            this.workerSetGridControl.Size = new System.Drawing.Size(591, 410);
            this.workerSetGridControl.TabIndex = 6;
            this.workerSetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.workerSetGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // btChanfeDivision
            // 
            this.btChanfeDivision.Location = new System.Drawing.Point(195, 474);
            this.btChanfeDivision.Name = "btChanfeDivision";
            this.btChanfeDivision.Size = new System.Drawing.Size(75, 23);
            this.btChanfeDivision.TabIndex = 7;
            this.btChanfeDivision.Text = "Изменить подразделение";
            this.btChanfeDivision.UseVisualStyleBackColor = true;
            this.btChanfeDivision.Click += new System.EventHandler(this.btChanfeDivision_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(276, 474);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 8;
            this.btRemove.Text = "Удалить подразделение";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAddWorker
            // 
            this.btAddWorker.Location = new System.Drawing.Point(729, 474);
            this.btAddWorker.Name = "btAddWorker";
            this.btAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btAddWorker.TabIndex = 9;
            this.btAddWorker.Text = "Добавить...";
            this.btAddWorker.UseVisualStyleBackColor = true;
            this.btAddWorker.Click += new System.EventHandler(this.btAddWorker_Click);
            // 
            // btChangeWorker
            // 
            this.btChangeWorker.Location = new System.Drawing.Point(810, 474);
            this.btChangeWorker.Name = "btChangeWorker";
            this.btChangeWorker.Size = new System.Drawing.Size(75, 23);
            this.btChangeWorker.TabIndex = 10;
            this.btChangeWorker.Text = "Изменить";
            this.btChangeWorker.UseVisualStyleBackColor = true;
            this.btChangeWorker.Click += new System.EventHandler(this.btChangeWorker_Click);
            // 
            // RemoveWorker
            // 
            this.RemoveWorker.Location = new System.Drawing.Point(891, 474);
            this.RemoveWorker.Name = "RemoveWorker";
            this.RemoveWorker.Size = new System.Drawing.Size(75, 23);
            this.RemoveWorker.TabIndex = 11;
            this.RemoveWorker.Text = "Удалить";
            this.RemoveWorker.UseVisualStyleBackColor = true;
            this.RemoveWorker.Click += new System.EventHandler(this.RemoveWorker_Click);
            // 
            // lbTableNameDivision
            // 
            this.lbTableNameDivision.AutoSize = true;
            this.lbTableNameDivision.Location = new System.Drawing.Point(12, 24);
            this.lbTableNameDivision.Name = "lbTableNameDivision";
            this.lbTableNameDivision.Size = new System.Drawing.Size(90, 13);
            this.lbTableNameDivision.TabIndex = 12;
            this.lbTableNameDivision.Text = "Подразделения:";
            // 
            // lbTableNameWorker
            // 
            this.lbTableNameWorker.AutoSize = true;
            this.lbTableNameWorker.Location = new System.Drawing.Point(372, 24);
            this.lbTableNameWorker.Name = "lbTableNameWorker";
            this.lbTableNameWorker.Size = new System.Drawing.Size(64, 13);
            this.lbTableNameWorker.TabIndex = 13;
            this.lbTableNameWorker.Text = "Работники:";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 507);
            this.Controls.Add(this.lbTableNameWorker);
            this.Controls.Add(this.lbTableNameDivision);
            this.Controls.Add(this.RemoveWorker);
            this.Controls.Add(this.btChangeWorker);
            this.Controls.Add(this.btAddWorker);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btChanfeDivision);
            this.Controls.Add(this.workerSetGridControl);
            this.Controls.Add(this.divisionSetGridControl);
            this.Controls.Add(this.btAddDivision);
            this.Name = "fmMain";
            this.Text = "Тестовое приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAddDivision;
        private DataWorkDataSet dataWorkDataSet;
        private System.Windows.Forms.BindingSource divisionSetBindingSource;
        private DataWorkDataSetTableAdapters.DivisionSetTableAdapter divisionSetTableAdapter;
        private DataWorkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataWorkDataSetTableAdapters.WorkerSetTableAdapter workerSetTableAdapter;
        private DevExpress.XtraGrid.GridControl divisionSetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource workerSetBindingSource;
        private DevExpress.XtraGrid.GridControl workerSetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btChanfeDivision;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAddWorker;
        private System.Windows.Forms.Button btChangeWorker;
        private System.Windows.Forms.Button RemoveWorker;
        private System.Windows.Forms.Label lbTableNameDivision;
        private System.Windows.Forms.Label lbTableNameWorker;
    }
}

