namespace _21_10_2022_v5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.tabSil = new System.Windows.Forms.TabPage();
            this.tabGuncelle = new System.Windows.Forms.TabPage();
            this.tabListele = new System.Windows.Forms.TabPage();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEkle);
            this.tabControl1.Controls.Add(this.tabSil);
            this.tabControl1.Controls.Add(this.tabGuncelle);
            this.tabControl1.Controls.Add(this.tabListele);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 227);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEkle
            // 
            this.tabEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabEkle.Controls.Add(this.btnEkle);
            this.tabEkle.Controls.Add(this.lblTc);
            this.tabEkle.Controls.Add(this.lblTel);
            this.tabEkle.Controls.Add(this.lblSoyad);
            this.tabEkle.Controls.Add(this.lblAd);
            this.tabEkle.Controls.Add(this.txtTc);
            this.tabEkle.Controls.Add(this.txtNumara);
            this.tabEkle.Controls.Add(this.txtSoyad);
            this.tabEkle.Controls.Add(this.txtAd);
            this.tabEkle.Location = new System.Drawing.Point(4, 22);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(295, 201);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Ekle";
            // 
            // tabSil
            // 
            this.tabSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabSil.Location = new System.Drawing.Point(4, 22);
            this.tabSil.Name = "tabSil";
            this.tabSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabSil.Size = new System.Drawing.Size(585, 288);
            this.tabSil.TabIndex = 1;
            this.tabSil.Text = "Sil";
            // 
            // tabGuncelle
            // 
            this.tabGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuncelle.Size = new System.Drawing.Size(585, 288);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Güncelle";
            // 
            // tabListele
            // 
            this.tabListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabListele.Location = new System.Drawing.Point(4, 22);
            this.tabListele.Name = "tabListele";
            this.tabListele.Size = new System.Drawing.Size(585, 288);
            this.tabListele.TabIndex = 3;
            this.tabListele.Text = "Listele";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(55, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(55, 32);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(55, 58);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 2;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(55, 84);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(26, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(14, 35);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(8, 61);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(46, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Telefon:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(25, 87);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(24, 13);
            this.lblTc.TabIndex = 7;
            this.lblTc.Text = "TC:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(55, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 242);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.tabEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TabPage tabSil;
        private System.Windows.Forms.TabPage tabGuncelle;
        private System.Windows.Forms.TabPage tabListele;
    }
}

