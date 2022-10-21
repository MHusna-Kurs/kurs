namespace _21_10_2022_v2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxLeft1 = new System.Windows.Forms.TextBox();
            this.tbxLeft2 = new System.Windows.Forms.TextBox();
            this.tbxLeft3 = new System.Windows.Forms.TextBox();
            this.tbxLeft4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRight1 = new System.Windows.Forms.TextBox();
            this.tbxRight2 = new System.Windows.Forms.TextBox();
            this.tbxRight3 = new System.Windows.Forms.TextBox();
            this.tbxRight4 = new System.Windows.Forms.TextBox();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxLeft4);
            this.groupBox1.Controls.Add(this.tbxLeft3);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.tbxLeft2);
            this.groupBox1.Controls.Add(this.tbxLeft1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(36, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxLeft1
            // 
            this.tbxLeft1.Location = new System.Drawing.Point(22, 38);
            this.tbxLeft1.Name = "tbxLeft1";
            this.tbxLeft1.Size = new System.Drawing.Size(100, 20);
            this.tbxLeft1.TabIndex = 0;
            // 
            // tbxLeft2
            // 
            this.tbxLeft2.Location = new System.Drawing.Point(22, 64);
            this.tbxLeft2.Name = "tbxLeft2";
            this.tbxLeft2.Size = new System.Drawing.Size(100, 20);
            this.tbxLeft2.TabIndex = 1;
            // 
            // tbxLeft3
            // 
            this.tbxLeft3.Location = new System.Drawing.Point(22, 90);
            this.tbxLeft3.Name = "tbxLeft3";
            this.tbxLeft3.Size = new System.Drawing.Size(100, 20);
            this.tbxLeft3.TabIndex = 2;
            // 
            // tbxLeft4
            // 
            this.tbxLeft4.Location = new System.Drawing.Point(22, 116);
            this.tbxLeft4.Name = "tbxLeft4";
            this.tbxLeft4.Size = new System.Drawing.Size(100, 20);
            this.tbxLeft4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete2);
            this.groupBox2.Controls.Add(this.tbxRight4);
            this.groupBox2.Controls.Add(this.tbxRight3);
            this.groupBox2.Controls.Add(this.tbxRight2);
            this.groupBox2.Controls.Add(this.tbxRight1);
            this.groupBox2.Location = new System.Drawing.Point(181, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbxRight1
            // 
            this.tbxRight1.Location = new System.Drawing.Point(22, 30);
            this.tbxRight1.Name = "tbxRight1";
            this.tbxRight1.Size = new System.Drawing.Size(100, 20);
            this.tbxRight1.TabIndex = 0;
            // 
            // tbxRight2
            // 
            this.tbxRight2.Location = new System.Drawing.Point(22, 56);
            this.tbxRight2.Name = "tbxRight2";
            this.tbxRight2.Size = new System.Drawing.Size(100, 20);
            this.tbxRight2.TabIndex = 1;
            // 
            // tbxRight3
            // 
            this.tbxRight3.Location = new System.Drawing.Point(22, 83);
            this.tbxRight3.Name = "tbxRight3";
            this.tbxRight3.Size = new System.Drawing.Size(100, 20);
            this.tbxRight3.TabIndex = 2;
            // 
            // tbxRight4
            // 
            this.tbxRight4.Location = new System.Drawing.Point(22, 109);
            this.tbxRight4.Name = "tbxRight4";
            this.tbxRight4.Size = new System.Drawing.Size(100, 20);
            this.tbxRight4.TabIndex = 3;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(35, 135);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(75, 23);
            this.btnDelete2.TabIndex = 3;
            this.btnDelete2.Text = "Sil";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 211);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxLeft4;
        private System.Windows.Forms.TextBox tbxLeft3;
        private System.Windows.Forms.TextBox tbxLeft2;
        private System.Windows.Forms.TextBox tbxLeft1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxRight4;
        private System.Windows.Forms.TextBox tbxRight3;
        private System.Windows.Forms.TextBox tbxRight2;
        private System.Windows.Forms.TextBox tbxRight1;
        private System.Windows.Forms.Button btnDelete2;
    }
}

