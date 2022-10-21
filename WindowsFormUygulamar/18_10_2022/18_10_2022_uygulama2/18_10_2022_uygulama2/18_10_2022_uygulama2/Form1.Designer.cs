namespace _18_10_2022_uygulama2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxGiris1 = new System.Windows.Forms.TextBox();
            this.tbxGiris2 = new System.Windows.Forms.TextBox();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giriş 2:";
            // 
            // tbxGiris1
            // 
            this.tbxGiris1.Location = new System.Drawing.Point(77, 41);
            this.tbxGiris1.Name = "tbxGiris1";
            this.tbxGiris1.Size = new System.Drawing.Size(100, 20);
            this.tbxGiris1.TabIndex = 2;
            this.tbxGiris1.TextChanged += new System.EventHandler(this.tbxGiris1_TextChanged);
            // 
            // tbxGiris2
            // 
            this.tbxGiris2.Location = new System.Drawing.Point(77, 80);
            this.tbxGiris2.Name = "tbxGiris2";
            this.tbxGiris2.Size = new System.Drawing.Size(100, 20);
            this.tbxGiris2.TabIndex = 3;
            this.tbxGiris2.TextChanged += new System.EventHandler(this.tbxGiris2_TextChanged);
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(77, 106);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(100, 23);
            this.btnKarsilastir.TabIndex = 4;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(250, 67);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 340);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.tbxGiris2);
            this.Controls.Add(this.tbxGiris1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxGiris1;
        private System.Windows.Forms.TextBox tbxGiris2;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.Label lblSonuc;
    }
}

