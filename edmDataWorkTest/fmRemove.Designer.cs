namespace edmDataWorkTest
{
    partial class fmRemove
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbText.Location = new System.Drawing.Point(21, 23);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(403, 24);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Какое подразделение следует удалить?(Id)";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(25, 63);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(399, 20);
            this.tbText.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(25, 116);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(117, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(295, 116);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(129, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // fmRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 182);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lbText);
            this.Name = "fmRemove";
            this.Text = "fmRemove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}