namespace _21_10_2022_v4
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMinous = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 39);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 21);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(65, 39);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 21);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(117, 38);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 21);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 66);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 21);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(65, 66);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 21);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(117, 66);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 21);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(117, 93);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 21);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(65, 120);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(46, 21);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 93);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 21);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumEvent);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(65, 93);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 21);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumEvent);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(169, 39);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(46, 21);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnMinous
            // 
            this.btnMinous.Location = new System.Drawing.Point(169, 66);
            this.btnMinous.Name = "btnMinous";
            this.btnMinous.Size = new System.Drawing.Size(46, 21);
            this.btnMinous.TabIndex = 0;
            this.btnMinous.Text = "-";
            this.btnMinous.UseVisualStyleBackColor = true;
            this.btnMinous.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(169, 93);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(46, 21);
            this.btnMultiply.TabIndex = 0;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperandEvent);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(169, 120);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(46, 21);
            this.btnDivide.TabIndex = 0;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperandEvent);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(14, 13);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(201, 20);
            this.tbxResult.TabIndex = 1;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(13, 120);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(46, 21);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(117, 120);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(46, 21);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(14, 147);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(201, 23);
            this.btnEqual.TabIndex = 2;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 192);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinous);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.NumEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMinous;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnEqual;
    }
}

