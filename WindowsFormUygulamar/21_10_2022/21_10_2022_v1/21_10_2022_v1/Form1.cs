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
            string strNumber = cmbNumbers.Text;

            if(strNumber != "")
            {
                int intNumber = Convert.ToInt32(strNumber);

                for (int i = 1; i <= 10; i++)
                    lbxMultiplyTable.Items.Add(intNumber + "x" + i + ": " + (i * intNumber));
            }
            else
                MessageBox.Show("Bir değer seçiniz !!!");
            
        }
    }
}
