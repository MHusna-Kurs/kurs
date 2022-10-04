using System;
using System.Collections.Generic;

namespace Ders7_MetotlarTekrar
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {

            //PERSONEL EKLEME
            PersonelEkle(7173678734, "Mehmet Demir", "istanbul...", "0546...");
            PersonelEkle(77777777777, "Hasan Emir", "istanbul...", "0532...");
            PersonelEkle(88888888888, "Ahmet Çelik", "istanbul...", "0533...");
            PersonelEkle(66666666666, "Hüseyin Temiz", "istanbul...", "0505...");
            PersonelEkle(99999999999, "Onur Bakır", "istanbul...", "0506...");

            string bulunan = PersonelAra(adSoyad: "Ahmet Çelik");
            Console.WriteLine("Bulunan:" + bulunan);

            Console.ReadLine();

            Console.WriteLine("*******************");
            PersonelSil(99999999999);
            PersonelYazdir();

            Console.ReadLine();

            Console.WriteLine("*******************");
            Console.Write("Tc girin: ");
            PersonelGuncelle(Convert.ToInt64(Console.ReadLine()));
            PersonelYazdir();

            Console.ReadLine();

        }

        private static string PersonelAra(long tc = 0, string adSoyad = "")
        {
            string personel = "";
            int personelIndex = -1;

            if (adSoyad != "")
            {
                if (adSoyadlar.Contains(adSoyad) == true)
                    personelIndex = adSoyadlar.IndexOf(adSoyad);
            }
            else if (tc != 0)
            {
                if (TCler.Contains(tc) == true)
                    personelIndex = TCler.IndexOf(tc);
            }
            if (personelIndex != -1)
            {
                personel = Convert.ToString(TCler[personelIndex]) + " " +
                           adSoyadlar[personelIndex] + " " +
                           adresler[personelIndex] + " " +
                           telefonlar[personelIndex] + "\n";
            }
            return personel;
        }

        private static void PersonelEkle(long tc, string adSoyad = "", string adres = "", string telefon = "")
        {
            if (tc != 0)
            {
                TCler.Add(tc);
                adSoyadlar.Add(adSoyad);
                adresler.Add(adres);
                telefonlar.Add(telefon);
            }
        }

        private static void PersonelSil(long tc)
        {
            int personelIndex = -1;
            if (tc != 0)
            {
                personelIndex = TCler.IndexOf(tc);

                if (personelIndex != -1)  // Personel bulundu ise
                {
                    TCler.RemoveAt(personelIndex);
                    adSoyadlar.RemoveAt(personelIndex);
                    adresler.RemoveAt(personelIndex);
                    telefonlar.RemoveAt(personelIndex);

                }
            }
        }

        private static void PersonelGuncelle(long tc)
        {
            if (TCler.Contains(tc))
            {
                int personelIndex = TCler.IndexOf(tc);
                Console.Write("Ad - Soyad: ");
                adSoyadlar[personelIndex] = Console.ReadLine();

                Console.Write("Adres: ");
                adresler[personelIndex] = Console.ReadLine();

                Console.Write("Telefon: ");
                telefonlar[personelIndex] = Console.ReadLine();
                
            }
        }

        private static void PersonelYazdir()
        {
            for (int i = 0; i < TCler.Count; i++)
                Console.WriteLine(TCler[i] + " - " + adSoyadlar[i] + " - " + adresler[i] + " - " + telefonlar[i]);
        }
    }
}


