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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tabSil = new System.Windows.Forms.TabPage();
            this.tabGuncelle = new System.Windows.Forms.TabPage();
            this.tabListele = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbOgr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.tabSil.SuspendLayout();
            this.gbxInfo.SuspendLayout();
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
            this.tabEkle.Controls.Add(this.gbxInfo);
            this.tabEkle.Location = new System.Drawing.Point(4, 22);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(295, 201);
            this.tabEkle.TabIndex = 0;
            this.tabEkle.Text = "Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(48, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(18, 94);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(24, 13);
            this.lblTc.TabIndex = 7;
            this.lblTc.Text = "TC:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(1, 68);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(46, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Telefon:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(7, 42);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(19, 16);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad:";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(48, 91);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 3;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(48, 65);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(48, 39);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(48, 13);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // tabSil
            // 
            this.tabSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabSil.Controls.Add(this.label1);
            this.tabSil.Controls.Add(this.cmbOgr);
            this.tabSil.Controls.Add(this.btnDelete);
            this.tabSil.Location = new System.Drawing.Point(4, 22);
            this.tabSil.Name = "tabSil";
            this.tabSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabSil.Size = new System.Drawing.Size(295, 201);
            this.tabSil.TabIndex = 1;
            this.tabSil.Text = "Sil";
            // 
            // tabGuncelle
            // 
            this.tabGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tabGuncelle.Name = "tabGuncelle";
            this.tabGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuncelle.Size = new System.Drawing.Size(295, 201);
            this.tabGuncelle.TabIndex = 2;
            this.tabGuncelle.Text = "Güncelle";
            // 
            // tabListele
            // 
            this.tabListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabListele.Location = new System.Drawing.Point(4, 22);
            this.tabListele.Name = "tabListele";
            this.tabListele.Size = new System.Drawing.Size(295, 201);
            this.tabListele.TabIndex = 3;
            this.tabListele.Text = "Listele";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(82, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbOgr
            // 
            this.cmbOgr.FormattingEnabled = true;
            this.cmbOgr.Location = new System.Drawing.Point(82, 66);
            this.cmbOgr.Name = "cmbOgr";
            this.cmbOgr.Size = new System.Drawing.Size(121, 21);
            this.cmbOgr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek Öğeyi Seçiniz:";
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.txtAd);
            this.gbxInfo.Controls.Add(this.btnEkle);
            this.gbxInfo.Controls.Add(this.txtSoyad);
            this.gbxInfo.Controls.Add(this.lblTc);
            this.gbxInfo.Controls.Add(this.txtNumara);
            this.gbxInfo.Controls.Add(this.lblTel);
            this.gbxInfo.Controls.Add(this.txtTc);
            this.gbxInfo.Controls.Add(this.lblSoyad);
            this.gbxInfo.Controls.Add(this.lblAd);
            this.gbxInfo.Location = new System.Drawing.Point(6, 6);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(168, 156);
            this.gbxInfo.TabIndex = 9;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Bilgiler";
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
            this.tabSil.ResumeLayout(false);
            this.tabSil.PerformLayout();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOgr;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxInfo;
    }
}

