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

namespace SISApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=405-03;Initial Catalog=SIS;User ID=sa;Password=1234");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sorgu = "select count(*) from Calisanlar where Eposta=@user and Parola=@password";

            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@user", tbxUser.Text);
            command.Parameters.AddWithValue("@password", tbxPassword.Text);
            
            connection.Open();
            int effected = Convert.ToInt32(command.ExecuteScalar().ToString());

            if (effected > 0)
                MessageBox.Show("Giriş yapıldı.");
            else
                MessageBox.Show("Giriş yapılamadı.");

            connection.Close();

        }
    }
}
