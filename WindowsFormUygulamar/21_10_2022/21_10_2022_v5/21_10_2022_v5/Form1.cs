using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_10_2022_v5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=405-03;Initial Catalog=DB_Test;User ID=sa;Password=1234");     
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           command  = new SqlCommand("SP_OgrenciEkle", connection);
           command.CommandType = CommandType.StoredProcedure;
           command.Parameters.AddWithValue("@ad", txtAd.Text);
           command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
           command.Parameters.AddWithValue("@telefon", txtNumara.Text);
           command.Parameters.AddWithValue("@tc", txtTc.Text);
           connection.Open();
           command.ExecuteNonQuery();
           connection.Close();
        }
    }
}
