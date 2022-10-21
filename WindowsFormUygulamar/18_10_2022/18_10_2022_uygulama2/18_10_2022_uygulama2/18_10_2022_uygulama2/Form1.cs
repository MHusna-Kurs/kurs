using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_10_2022_uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Karsilastir()
        {

            int result = string.Compare(tbxGiris1.Text, tbxGiris2.Text, true);

            if (result < 0)
                lblSonuc.Text = "Birinci string ikinci stringden küçük.";
            else if(result > 0)
                lblSonuc.Text = "Birinci string ikinci stringden büyük.";
            else
                lblSonuc.Text = "İki string birbirine eşit.";
        }

        private void tbxGiris1_TextChanged(object sender, EventArgs e)
        {
            Karsilastir();
        }

        private void tbxGiris2_TextChanged(object sender, EventArgs e)
        {
            Karsilastir();
        }
    }
}
