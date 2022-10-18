namespace _18_10_2022_uygulama
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
            this.tbxBirinciSayi = new System.Windows.Forms.TextBox();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIkinciSayi = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tbxSonuc = new System.Windows.Forms.TextBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnAlan = new System.Windows.Forms.Button();
            this.btnCevre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxBirinciSayi
            // 
            this.tbxBirinciSayi.Location = new System.Drawing.Point(94, 27);
            this.tbxBirinciSayi.Name = "tbxBirinciSayi";
            this.tbxBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.tbxBirinciSayi.TabIndex = 0;
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(27, 30);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(61, 13);
            this.lblBirinciSayi.TabIndex = 1;
            this.lblBirinciSayi.Text = "Birinci Sayı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İkinci Sayı:";
            // 
            // tbxIkinciSayi
            // 
            this.tbxIkinciSayi.Location = new System.Drawing.Point(94, 65);
            this.tbxIkinciSayi.Name = "tbxIkinciSayi";
            this.tbxIkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.tbxIkinciSayi.TabIndex = 3;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(94, 122);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(100, 23);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(44, 96);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // tbxSonuc
            // 
            this.tbxSonuc.CausesValidation = false;
            this.tbxSonuc.Location = new System.Drawing.Point(94, 96);
            this.tbxSonuc.Name = "tbxSonuc";
            this.tbxSonuc.ReadOnly = true;
            this.tbxSonuc.Size = new System.Drawing.Size(100, 20);
            this.tbxSonuc.TabIndex = 6;
            this.tbxSonuc.Text = "________________";
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(94, 151);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(100, 23);
            this.btnCikar.TabIndex = 7;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(200, 122);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(100, 23);
            this.btnCarp.TabIndex = 8;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(201, 150);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(99, 23);
            this.btnBol.TabIndex = 9;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnAlan
            // 
            this.btnAlan.Location = new System.Drawing.Point(306, 122);
            this.btnAlan.Name = "btnAlan";
            this.btnAlan.Size = new System.Drawing.Size(99, 23);
            this.btnAlan.TabIndex = 10;
            this.btnAlan.Text = "Alan";
            this.btnAlan.UseVisualStyleBackColor = true;
            this.btnAlan.Click += new System.EventHandler(this.btnAlan_Click);
            // 
            // btnCevre
            // 
            this.btnCevre.Location = new System.Drawing.Point(306, 151);
            this.btnCevre.Name = "btnCevre";
            this.btnCevre.Size = new System.Drawing.Size(99, 23);
            this.btnCevre.TabIndex = 11;
            this.btnCevre.Text = "Çevre";
            this.btnCevre.UseVisualStyleBackColor = true;
            this.btnCevre.Click += new System.EventHandler(this.btnCevre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alan:";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(287, 27);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(73, 13);
            this.lblAlan.TabIndex = 13;
            this.lblAlan.Text = "___________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Çevre:";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(287, 54);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(73, 13);
            this.lblCevre.TabIndex = 15;
            this.lblCevre.Text = "___________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCevre);
            this.Controls.Add(this.btnAlan);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.tbxSonuc);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.tbxIkinciSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBirinciSayi);
            this.Controls.Add(this.tbxBirinciSayi);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBirinciSayi;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIkinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox tbxSonuc;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnAlan;
        private System.Windows.Forms.Button btnCevre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCevre;
    }
}

