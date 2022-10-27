using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Araba araba = new Araba();
            //araba.Marka = "Mazda";
            //araba.Model = "6";
            //araba.BilgiYaz();

            //Araba araba2 = new Araba();
            //araba2.Marka = "BMW";
            //araba2.Model = "XS";
            //araba2.BilgiYaz();

            //Araba araba3 = new Araba(3, "Mercedes", "GTR");
            //araba3.BilgiYaz();

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.ad = "Ahmet";
            ogretmen.soyad = "Derdev";

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "Deren";
            ogrenci.soyad = "Kartal";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.ad = "Maksudov";
            ogrenci2.soyad = "Malabov";

            ogretmen.ogrenciler = new List<Ogrenci>()
            {
                ogrenci,
                ogrenci2
            };

            ogretmen.BilgiYaz();
            ogretmen.OgrenciListele();
            Console.ReadLine();

        }
    }
}
