using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Ogrenci
    {
        public string tcKimlikNo;
        public string okulNo;
        public string ad;
        public string soyad;
        public Ogretmen sinifOgretmeni;
        
        public void SinifOgretmeniDegistir(Ogretmen ogretmen)
        {
            sinifOgretmeni = ogretmen;
        }
        public Ogrenci()
        {

        }

        public Ogrenci(string tcKimlikNo, string okulNo, string ad, string soyad, Ogretmen sinifOgretmeni)
        {
            this.tcKimlikNo = tcKimlikNo;
            this.okulNo = okulNo;
            this.ad = ad;
            this.soyad = soyad;
            this.sinifOgretmeni = sinifOgretmeni;
        }
        
        public void BilgiYaz()
        {
            Console.WriteLine("TC: "+this.tcKimlikNo+"\n"+
                "Okul no: "+this.okulNo+
                "Ad: "+this.ad+
                "Soyad: "+this.soyad+
                "Ogretmen Ad - Soyad: "+this.sinifOgretmeni.ad+" "+this.sinifOgretmeni.soyad);
        }
    }
}
