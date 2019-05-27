namespace edmDataWorkTest
{
    partial class fmChangeDivision
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
            this.lbText = new System.Windows.Forms.Label();
            this.tbOldName = new System.Windows.Forms.TextBox();
            this.lbNewName = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbText.Location = new System.Drawing.Point(25, 28);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(398, 24);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Введите старое название подразделение:";
            // 
            // tbOldName
            // 
            this.tbOldName.Location = new System.Drawing.Point(29, 55);
            this.tbOldName.Name = "tbOldName";
            this.tbOldName.Size = new System.Drawing.Size(385, 20);
            this.tbOldName.TabIndex = 1;
            // 
            // lbNewName
            // 
            this.lbNewName.AutoSize = true;
            this.lbNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewName.Location = new System.Drawing.Point(25, 105);
            this.lbNewName.Name = "lbNewName";
            this.lbNewName.Size = new System.Drawing.Size(389, 24);
            this.lbNewName.TabIndex = 2;
            this.lbNewName.Text = "Введите новое название подразделения:";
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(29, 132);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(385, 20);
            this.tbNewName.TabIndex = 3;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOk.Location = new System.Drawing.Point(29, 183);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 42);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(295, 183);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(119, 42);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fmChangeDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 270);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.lbNewName);
            this.Controls.Add(this.tbOldName);
            this.Controls.Add(this.lbText);
            this.Name = "fmChangeDivision";
            this.Text = "fmChangeDivision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbOldName;
        private System.Windows.Forms.Label lbNewName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}