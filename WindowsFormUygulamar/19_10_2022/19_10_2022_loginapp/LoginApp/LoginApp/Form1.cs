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

namespace LoginApp
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        static SqlDataReader dataReader;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=405-03;Initial Catalog=DbLogin;User ID=sa;Password=1234");
            connection.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From tblUser  where usr=@user AND pwd=@pass";
            
            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@user", tbxUser.Text);
            command.Parameters.AddWithValue("@pass", tbxPass.Text);
            
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
                dgvTablo.Rows.Add(dataReader["usr"], dataReader["name"]);
            else
                MessageBox.Show("Kullanıcı adı ve şifrenizi kontrol ediniz.");

            dataReader.Close();
            //connection.Close();
        }
    }
}
