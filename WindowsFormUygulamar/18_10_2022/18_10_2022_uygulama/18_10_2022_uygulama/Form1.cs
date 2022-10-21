using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_10_2022_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                int toplam = Convert.ToInt32(tbxBirinciSayi.Text) + Convert.ToInt32(tbxIkinciSayi.Text);
                tbxSonuc.Text = Convert.ToString(toplam);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                int sonuc = Convert.ToInt32(tbxBirinciSayi.Text) - Convert.ToInt32(tbxIkinciSayi.Text);
                tbxSonuc.Text = Convert.ToString(sonuc);
            }
            catch (Exception x)
            {
               MessageBox.Show(x.Message);
            }
            
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                int sonuc = Convert.ToInt32(tbxBirinciSayi.Text) * Convert.ToInt32(tbxIkinciSayi.Text);
                tbxSonuc.Text = Convert.ToString(sonuc);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                double sonuc = Convert.ToDouble(tbxBirinciSayi.Text) / Convert.ToDouble(tbxIkinciSayi.Text);
                tbxSonuc.Text = Convert.ToString(sonuc);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAlan_Click(object sender, EventArgs e)
        {
            try
            {
                double uzunluk = Convert.ToDouble(tbxBirinciSayi.Text);
                double genislik = Convert.ToDouble(tbxIkinciSayi.Text);

                lblAlan.Text = Convert.ToString(uzunluk * genislik);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnCevre_Click(object sender, EventArgs e)
        {
            try
            {
                double uzunluk = Convert.ToDouble(tbxBirinciSayi.Text);
                double genislik = Convert.ToDouble(tbxIkinciSayi.Text);

                lblCevre.Text = Convert.ToString(uzunluk*2 + genislik*2);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
