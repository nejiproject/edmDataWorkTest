namespace edmDataWorkTest
{
    partial class fmRemoveWorker
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
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(34, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(231, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Введите имя работника:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(38, 57);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(227, 20);
            this.tbName.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(38, 112);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(78, 39);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(176, 112);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 39);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fmRemoveWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 186);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "fmRemoveWorker";
            this.Text = "fmRemoveWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}