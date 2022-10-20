namespace _20_10_2022_v2
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
            this.dgvOgrenci = new System.Windows.Forms.DataGridView();
            this.ogrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnlOgrNo = new System.Windows.Forms.Label();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrSehir = new System.Windows.Forms.Label();
            this.tbxOgrNo = new System.Windows.Forms.TextBox();
            this.tbxOgrAd = new System.Windows.Forms.TextBox();
            this.tbxOgrSehir = new System.Windows.Forms.TextBox();
            this.tbxOgrSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenci
            // 
            this.dgvOgrenci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrNo,
            this.ogrFirstName,
            this.ogrLastName,
            this.ogrSehir});
            this.dgvOgrenci.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOgrenci.Location = new System.Drawing.Point(12, 153);
            this.dgvOgrenci.Name = "dgvOgrenci";
            this.dgvOgrenci.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvOgrenci.Size = new System.Drawing.Size(585, 164);
            this.dgvOgrenci.TabIndex = 0;
            // 
            // ogrNo
            // 
            this.ogrNo.HeaderText = "Öğrenci No";
            this.ogrNo.Name = "ogrNo";
            // 
            // ogrFirstName
            // 
            this.ogrFirstName.HeaderText = "Öğrenci Adı";
            this.ogrFirstName.Name = "ogrFirstName";
            // 
            // ogrLastName
            // 
            this.ogrLastName.HeaderText = "Öğrenci Soyad";
            this.ogrLastName.Name = "ogrLastName";
            // 
            // ogrSehir
            // 
            this.ogrSehir.HeaderText = "Şehir";
            this.ogrSehir.Name = "ogrSehir";
            // 
            // lnlOgrNo
            // 
            this.lnlOgrNo.AutoSize = true;
            this.lnlOgrNo.Location = new System.Drawing.Point(24, 20);
            this.lnlOgrNo.Name = "lnlOgrNo";
            this.lnlOgrNo.Size = new System.Drawing.Size(64, 13);
            this.lnlOgrNo.TabIndex = 1;
            this.lnlOgrNo.Text = "Öğrenci No:";
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Location = new System.Drawing.Point(25, 45);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(63, 13);
            this.lblOgrAd.TabIndex = 2;
            this.lblOgrAd.Text = "Öğrenci Ad:";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Location = new System.Drawing.Point(8, 72);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(80, 13);
            this.lblOgrSoyad.TabIndex = 3;
            this.lblOgrSoyad.Text = "Öğrenci Soyad:";
            // 
            // lblOgrSehir
            // 
            this.lblOgrSehir.AutoSize = true;
            this.lblOgrSehir.Location = new System.Drawing.Point(54, 102);
            this.lblOgrSehir.Name = "lblOgrSehir";
            this.lblOgrSehir.Size = new System.Drawing.Size(34, 13);
            this.lblOgrSehir.TabIndex = 4;
            this.lblOgrSehir.Text = "Şehir:";
            // 
            // tbxOgrNo
            // 
            this.tbxOgrNo.Location = new System.Drawing.Point(94, 12);
            this.tbxOgrNo.Name = "tbxOgrNo";
            this.tbxOgrNo.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrNo.TabIndex = 5;
            // 
            // tbxOgrAd
            // 
            this.tbxOgrAd.Location = new System.Drawing.Point(94, 38);
            this.tbxOgrAd.Name = "tbxOgrAd";
            this.tbxOgrAd.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrAd.TabIndex = 6;
            // 
            // tbxOgrSehir
            // 
            this.tbxOgrSehir.Location = new System.Drawing.Point(94, 95);
            this.tbxOgrSehir.Name = "tbxOgrSehir";
            this.tbxOgrSehir.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrSehir.TabIndex = 7;
            // 
            // tbxOgrSoyad
            // 
            this.tbxOgrSoyad.Location = new System.Drawing.Point(94, 65);
            this.tbxOgrSoyad.Name = "tbxOgrSoyad";
            this.tbxOgrSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrSoyad.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(259, 15);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "&Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(259, 45);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "&Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(259, 74);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(259, 102);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 329);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxOgrSoyad);
            this.Controls.Add(this.tbxOgrSehir);
            this.Controls.Add(this.tbxOgrAd);
            this.Controls.Add(this.tbxOgrNo);
            this.Controls.Add(this.lblOgrSehir);
            this.Controls.Add(this.lblOgrSoyad);
            this.Controls.Add(this.lblOgrAd);
            this.Controls.Add(this.lnlOgrNo);
            this.Controls.Add(this.dgvOgrenci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSehir;
        private System.Windows.Forms.Label lnlOgrNo;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrSehir;
        private System.Windows.Forms.TextBox tbxOgrNo;
        private System.Windows.Forms.TextBox tbxOgrAd;
        private System.Windows.Forms.TextBox tbxOgrSehir;
        private System.Windows.Forms.TextBox tbxOgrSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
    }
}

