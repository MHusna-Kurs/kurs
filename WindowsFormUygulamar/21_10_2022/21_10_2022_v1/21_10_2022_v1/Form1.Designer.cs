namespace _21_10_2022_v1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbNumbers = new System.Windows.Forms.ComboBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.lbxMultiplyTable = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbNumbers
            // 
            this.cmbNumbers.FormattingEnabled = true;
            this.cmbNumbers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumbers.Location = new System.Drawing.Point(50, 36);
            this.cmbNumbers.Name = "cmbNumbers";
            this.cmbNumbers.Size = new System.Drawing.Size(121, 21);
            this.cmbNumbers.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(177, 34);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Getir";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lbxMultiplyTable
            // 
            this.lbxMultiplyTable.FormattingEnabled = true;
            this.lbxMultiplyTable.Location = new System.Drawing.Point(50, 72);
            this.lbxMultiplyTable.Name = "lbxMultiplyTable";
            this.lbxMultiplyTable.Size = new System.Drawing.Size(202, 134);
            this.lbxMultiplyTable.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 240);
            this.Controls.Add(this.lbxMultiplyTable);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.cmbNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNumbers;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ListBox lbxMultiplyTable;
    }
}

