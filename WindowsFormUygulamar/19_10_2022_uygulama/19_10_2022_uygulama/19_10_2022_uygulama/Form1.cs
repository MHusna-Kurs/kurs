using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_10_2022_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radMavi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mavi");
            this.BackColor = Color.Blue;
        }

        private void radKirmizi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı");
            this.BackColor = Color.Red;
        }

        private void radTuruncu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turuncu");
            this.BackColor = Color.Orange;
        }
    }
}
