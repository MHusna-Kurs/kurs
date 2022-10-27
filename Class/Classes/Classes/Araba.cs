using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Araba
    {
        int ID;
        public string Marka;
        public string Model;

        public Araba()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }

        public Araba(int id, string marka, string model)
        {
            this.ID = id;
            this.Marka = marka;
            this.Model = model;
        }

        public void BilgiYaz()
        {
            Console.Write("Marka: "+this.Marka);
            Console.WriteLine(" Model: "+this.Model);
        }
    }
}
