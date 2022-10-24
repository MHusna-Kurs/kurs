using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_10_2022_v1
{
    class CustomerProvider
    {
        SqlConnection connection = new SqlConnection(@"Data Source=405-03;Initial Catalog=Northwind;User ID=sa;Password=1234");
        SqlCommand command;
        SqlDataReader dataReader;

        public List<Customer> customers { get; set; }

        public CustomerProvider()
        {
            customers = new List<Customer>();
            GetCustomers();
        }

        private void GetCustomers()
        {
            connection.Open();
            command = new SqlCommand("select * from Customers", connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerId = dataReader[0].ToString();
                customer.CompanyName = dataReader[1].ToString();
                customer.ContactName = dataReader[2].ToString();
                customer.ContactTitle = dataReader[3].ToString();
                customer.Address = dataReader[4].ToString();
                customer.City = dataReader[5].ToString();
                customer.Region = dataReader[6].ToString();
                customer.PostalCode = dataReader[7].ToString();
                customer.Country = dataReader[8].ToString();
                customer.Phone = dataReader[9].ToString();
                customer.Fax = dataReader[10].ToString();
                customers.Add(customer);
            }
            dataReader.Close();
            connection.Close();
        }

        public List<string> FillComboBox()
        {
            return customers.Select(x => x.Country).Distinct().ToList();
        }

        public List<Customer> FilterCustomer(string country)
        {
            return customers.Where(x => x.Country == country).ToList();
        }
    }
}
