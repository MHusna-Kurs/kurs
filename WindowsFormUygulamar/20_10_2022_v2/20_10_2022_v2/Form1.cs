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

namespace _20_10_2022_v2
{
    public partial class Form1 : Form
    {

        static SqlConnection connection;
        //SqlCommand command;
        SqlDataReader dataReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=405-03;Initial Catalog=DB_Test;User ID=sa;Password=1234");
            connection.Open();
            kayitlariGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into ogrenci (ogrenci_no, ogrenci_ad, ogrenci_soyad, ogrenci_sehir)" +
                "values (@ogrNo, @ogrAd, @ogrSoyad, @ogrSehir)";
            SqlCommand addCommand = new SqlCommand(sorgu, connection);

            addCommand.Parameters.AddWithValue("@ogrNo", tbxOgrNo.Text);
            addCommand.Parameters.AddWithValue("@ogrAd", tbxOgrAd.Text);
            addCommand.Parameters.AddWithValue("@ogrSoyad", tbxOgrSoyad.Text);
            addCommand.Parameters.AddWithValue("@ogrSehir", tbxOgrSehir.Text);

            addCommand.ExecuteNonQuery();
            kayitlariGetir();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            kayitlariGetir();
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update ogrenci set (ogrenci_no = @ogrNo, ogrenci_ad = @ogrAd, ogrenci_soyad = @ogrSoyad, ogrenci_sehir = @ogrSehir)";
            SqlCommand updateCommand = new SqlCommand(sorgu, connection);

            updateCommand.Parameters.AddWithValue("@ogrNo", tbxOgrNo.Text);
            updateCommand.Parameters.AddWithValue("@ogrAd", tbxOgrAd.Text);
            updateCommand.Parameters.AddWithValue("@ogrSoyad", tbxOgrSoyad.Text);
            updateCommand.Parameters.AddWithValue("@ogrSehir", tbxOgrSehir.Text);

            updateCommand.ExecuteNonQuery();
            kayitlariGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from ogrenci where ogrenci_no = @ogrNo";
            SqlCommand deleteCommand = new SqlCommand(sorgu, connection);

            deleteCommand.Parameters.AddWithValue("@ogrNo", tbxOgrNo.Text);

            deleteCommand.ExecuteNonQuery();
            kayitlariGetir();
        }

        private void kayitlariGetir()
        {
            string sorgu = "Select * From ogrenci";
            SqlCommand getRegister = new SqlCommand(sorgu, connection);
            
            dataReader = getRegister.ExecuteReader();

            if (dataReader.FieldCount != 0)
            {
                while (dataReader.Read())
                    dgvOgrenci.Rows.Add(dataReader["ogrenci_no"], dataReader["ogrenci_ad"], dataReader["ogrenci_soyad"], dataReader["ogrenci_sehir"]);
            }
            else
                MessageBox.Show("Veri tabanında hiçbir kayıt bulunamadı.");
            
            dataReader.Close();
        }
        
    }
}
