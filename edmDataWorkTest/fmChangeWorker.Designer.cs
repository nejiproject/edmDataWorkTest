namespace edmDataWorkTest
{
    partial class fmChangeWorker
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
            this.lbIdWorker = new System.Windows.Forms.Label();
            this.tbOldName = new System.Windows.Forms.TextBox();
            this.lbNewName = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbDivId = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIdWorker
            // 
            this.lbIdWorker.AutoSize = true;
            this.lbIdWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIdWorker.Location = new System.Drawing.Point(23, 21);
            this.lbIdWorker.Name = "lbIdWorker";
            this.lbIdWorker.Size = new System.Drawing.Size(465, 24);
            this.lbIdWorker.TabIndex = 0;
            this.lbIdWorker.Text = "Введите ID работника которого ходите изменить:";
            // 
            // tbOldName
            // 
            this.tbOldName.Location = new System.Drawing.Point(27, 48);
            this.tbOldName.Name = "tbOldName";
            this.tbOldName.Size = new System.Drawing.Size(223, 20);
            this.tbOldName.TabIndex = 1;
            // 
            // lbNewName
            // 
            this.lbNewName.AutoSize = true;
            this.lbNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewName.Location = new System.Drawing.Point(24, 85);
            this.lbNewName.Name = "lbNewName";
            this.lbNewName.Size = new System.Drawing.Size(239, 24);
            this.lbNewName.TabIndex = 2;
            this.lbNewName.Text = "Введите актуальное имя:";
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(28, 112);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(222, 20);
            this.tbNewName.TabIndex = 3;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAge.Location = new System.Drawing.Point(24, 156);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(280, 24);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Введите актуальный возраст:";
            // 
            // lbDivId
            // 
            this.lbDivId.AutoSize = true;
            this.lbDivId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDivId.Location = new System.Drawing.Point(24, 227);
            this.lbDivId.Name = "lbDivId";
            this.lbDivId.Size = new System.Drawing.Size(376, 24);
            this.lbDivId.TabIndex = 5;
            this.lbDivId.Text = "Укажите ID актуального подразделения:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(27, 183);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(223, 20);
            this.tbAge.TabIndex = 6;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(27, 254);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(222, 20);
            this.tbID.TabIndex = 7;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(279, 287);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(96, 36);
            this.btOk.TabIndex = 8;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(390, 287);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 36);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fmChangeWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 346);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lbDivId);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.lbNewName);
            this.Controls.Add(this.tbOldName);
            this.Controls.Add(this.lbIdWorker);
            this.Name = "fmChangeWorker";
            this.Text = "fmChangeWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdWorker;
        private System.Windows.Forms.TextBox tbOldName;
        private System.Windows.Forms.Label lbNewName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbDivId;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}