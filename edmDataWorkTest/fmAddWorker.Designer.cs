namespace edmDataWorkTest
{
    partial class fmAddWorker
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lbDivision = new System.Windows.Forms.Label();
            this.tbDivision = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(13, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(131, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Введите имя работника:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(227, 20);
            this.tbName.TabIndex = 1;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAge.Location = new System.Drawing.Point(14, 60);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(108, 13);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Возраст работника:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(16, 76);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(227, 20);
            this.tbAge.TabIndex = 3;
            // 
            // lbDivision
            // 
            this.lbDivision.AutoSize = true;
            this.lbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDivision.Location = new System.Drawing.Point(12, 110);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(141, 13);
            this.lbDivision.TabIndex = 4;
            this.lbDivision.Text = "Название подразделения:";
            // 
            // tbDivision
            // 
            this.tbDivision.Location = new System.Drawing.Point(15, 126);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.Size = new System.Drawing.Size(226, 20);
            this.tbDivision.TabIndex = 5;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(85, 168);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(166, 168);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fmAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 214);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbDivision);
            this.Controls.Add(this.lbDivision);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "fmAddWorker";
            this.Text = "Добавить работника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lbDivision;
        private System.Windows.Forms.TextBox tbDivision;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}