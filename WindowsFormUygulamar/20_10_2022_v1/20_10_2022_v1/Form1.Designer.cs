namespace _20_10_2022_v1
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
            this.btnDegistir = new System.Windows.Forms.Button();
            this.tbxYazi = new System.Windows.Forms.TextBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radOrange = new System.Windows.Forms.RadioButton();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(42, 151);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(100, 23);
            this.btnDegistir.TabIndex = 0;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // tbxYazi
            // 
            this.tbxYazi.Location = new System.Drawing.Point(42, 113);
            this.tbxYazi.Name = "tbxYazi";
            this.tbxYazi.Size = new System.Drawing.Size(100, 20);
            this.tbxYazi.TabIndex = 1;
            this.tbxYazi.TextChanged += new System.EventHandler(this.tbxYazi_TextChanged);
            this.tbxYazi.Validated += new System.EventHandler(this.tbxYazi_Validated);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(13, 13);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(54, 17);
            this.radRed.TabIndex = 2;
            this.radRed.Text = "Kırmızı";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(13, 42);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(48, 17);
            this.radBlue.TabIndex = 3;
            this.radBlue.Text = "Mavi";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radOrange
            // 
            this.radOrange.AutoSize = true;
            this.radOrange.Location = new System.Drawing.Point(13, 71);
            this.radOrange.Name = "radOrange";
            this.radOrange.Size = new System.Drawing.Size(65, 17);
            this.radOrange.TabIndex = 4;
            this.radOrange.Text = "Turuncu";
            this.radOrange.UseVisualStyleBackColor = true;
            this.radOrange.CheckedChanged += new System.EventHandler(this.radOrange_CheckedChanged);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRed.Location = new System.Drawing.Point(102, 10);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 5;
            this.btnRed.Text = "Kırmızı";
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlue.Location = new System.Drawing.Point(102, 39);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 6;
            this.btnBlue.Text = "Mavi";
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrange.Location = new System.Drawing.Point(102, 68);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(75, 23);
            this.btnOrange.TabIndex = 7;
            this.btnOrange.Text = "Turuncu";
            this.btnOrange.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 265);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.radOrange);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radRed);
            this.Controls.Add(this.tbxYazi);
            this.Controls.Add(this.btnDegistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox tbxYazi;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radOrange;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnOrange;
    }
}

