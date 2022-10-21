using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_10_2022_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lbxMultiplyTable.Items.Clear();

            //int sayi = cmbNumbers.SelectedIndex + 1;
            int sayi = Convert.ToInt32(cmbNumbers.Text);

            if(sayi != -1)
            {
                for (int i = 1; i <= 10; i++)
                    lbxMultiplyTable.Items.Add(sayi + "x" + i + ": " + (i * sayi));
            }
            else
            {
                MessageBox.Show("Bir değer seçiniz !!!");
            }
            
        }
    }
}
