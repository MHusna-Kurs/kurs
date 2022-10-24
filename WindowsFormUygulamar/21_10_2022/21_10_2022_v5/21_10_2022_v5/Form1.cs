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
        SqlDataReader dataReader;
        string[] strIndex;
        int intIndex, tempIndex;
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=405-03;Initial Catalog=DB_Test;User ID=sa;Password=1234");

            string query = "select * from tb_ogrenci";
            command = new SqlCommand(query, connection);
            connection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
                cmbOgr.Items.Add(dataReader[0].ToString() + "- " + dataReader[1].ToString());
            
                
            connection.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_OgrenciEkle", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@telefon", txtNumara.Text);
            command.Parameters.AddWithValue("@tc", txtTc.Text);
            connection.Open();
            int id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            tbxClear((Button)sender);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            strIndex = cmbOgr.SelectedItem.ToString().Split('-');
            tempIndex = cmbOgr.SelectedIndex;
            intIndex = Convert.ToInt32(strIndex[0]);

            string sorgu = "delete from tb_ogrenci where ID=@id";
            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@id", intIndex);

            string name = cmbOgr.SelectedItem.ToString();
            DialogResult result = MessageBox.Show(name+" silmek istediğinizden emin misiniz ?","Silme Onayı",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                connection.Open();
                int effected = command.ExecuteNonQuery();

                if (effected > 0)
                {
                    MessageBox.Show("Silme işlemi başarıyla gerçekleşti.");
                    cmbOgr.Items.RemoveAt(tempIndex);
                }
                else
                    MessageBox.Show("Herhangi bir kayıt silinmedi.");

                connection.Close();
            }
            
        }

        private void tbxClear(Button sender)
        {
            MessageBox.Show("Çalıştı");
            foreach (Control item in this.Controls)
            {
                MessageBox.Show(""+(item));
                if (item is TabControl && item. == sender.Parent)
                {
                    MessageBox.Show(item.Name.ToString());
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2 is TextBox)
                            (item2 as TextBox).Clear();
                    }
                }
            }
        }
    }
}
