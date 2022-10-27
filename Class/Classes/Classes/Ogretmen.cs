using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Ogretmen
    {
        public int ID;
        public string ad;
        public string soyad;
        public List<Ogrenci> ogrenciler;

        public Ogretmen()
        {
            this.ogrenciler = new List<Ogrenci>();
        }

        public void BilgiYaz()
        {
            Console.WriteLine("Öğretmen Adı: "+this.ad);
            Console.WriteLine("Öğretmen Soyadı: "+this.soyad);
        }

        public void OgrenciListele()
        {
            Console.WriteLine(this.ad + " "+this.soyad+" isimli öğretmenin öğrencileri: ");

            foreach (var item in this.ogrenciler)
            {
                Console.WriteLine(item.ad+" "+item.soyad);
            }
        }
    }
}
