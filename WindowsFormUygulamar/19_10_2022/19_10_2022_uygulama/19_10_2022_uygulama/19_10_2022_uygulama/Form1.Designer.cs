namespace _19_10_2022_uygulama
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
            this.radMavi = new System.Windows.Forms.RadioButton();
            this.radKirmizi = new System.Windows.Forms.RadioButton();
            this.radTuruncu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radMavi
            // 
            this.radMavi.AutoSize = true;
            this.radMavi.Location = new System.Drawing.Point(134, 59);
            this.radMavi.Name = "radMavi";
            this.radMavi.Size = new System.Drawing.Size(48, 17);
            this.radMavi.TabIndex = 0;
            this.radMavi.Text = "Mavi";
            this.radMavi.UseVisualStyleBackColor = false;
            this.radMavi.Click += new System.EventHandler(this.radMavi_Click);
            // 
            // radKirmizi
            // 
            this.radKirmizi.AutoSize = true;
            this.radKirmizi.Location = new System.Drawing.Point(134, 83);
            this.radKirmizi.Name = "radKirmizi";
            this.radKirmizi.Size = new System.Drawing.Size(54, 17);
            this.radKirmizi.TabIndex = 1;
            this.radKirmizi.Text = "Kırmızı";
            this.radKirmizi.UseVisualStyleBackColor = true;
            this.radKirmizi.Click += new System.EventHandler(this.radKirmizi_Click);
            // 
            // radTuruncu
            // 
            this.radTuruncu.AutoSize = true;
            this.radTuruncu.Location = new System.Drawing.Point(134, 107);
            this.radTuruncu.Name = "radTuruncu";
            this.radTuruncu.Size = new System.Drawing.Size(65, 17);
            this.radTuruncu.TabIndex = 2;
            this.radTuruncu.Text = "Turuncu";
            this.radTuruncu.UseVisualStyleBackColor = true;
            this.radTuruncu.Click += new System.EventHandler(this.radTuruncu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 263);
            this.Controls.Add(this.radTuruncu);
            this.Controls.Add(this.radKirmizi);
            this.Controls.Add(this.radMavi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radMavi;
        private System.Windows.Forms.RadioButton radKirmizi;
        private System.Windows.Forms.RadioButton radTuruncu;
    }
}

