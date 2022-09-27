using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void kucukBuyukBul()
        {
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
                Console.WriteLine(sayi1);
            else if (sayi2 > sayi1)
                Console.WriteLine(sayi2);
            else
                Console.WriteLine(sayi1 + " = " + sayi2);
            Console.ReadLine();
        }

        private static void sayiAlma()
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 5)
                Console.WriteLine(sayi);
            else
                Console.WriteLine(Math.Pow(sayi, 2));

            Console.ReadLine();
        }

        private static void toplama()
        {
            Console.Write("Kaç sayı girilecek: ");
            int girisSayisi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int sayi;

        yapi:
            Console.Write("Bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 100)
                toplam += sayi;
            girisSayisi--;

            if (girisSayisi > 0)
                goto yapi;

            Console.WriteLine(toplam);
            Console.ReadLine();
        }

        private static void dortIslem()
        {
            Console.Write("İlk sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n**********************************");
            Console.WriteLine("Toplama // İşlem numarası: 1");
            Console.WriteLine("Çıkartma // İşlem numarası: 2");
            Console.WriteLine("Çarpma // İşlem numarası: 3");
            Console.WriteLine("Bölme // İşlem numarası: 4");
            Console.WriteLine("**********************************");
            Console.Write("İşlem girin:");
            int islem = Convert.ToInt32(Console.ReadLine());
            double sonuc = 0;

            switch (islem)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    sonuc = (double)sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Yanlış işlem seçtiniz...");
                    break;
            }
            Console.WriteLine("İşlem Sonucu: " + sonuc);
            Console.ReadLine();
        }

        private static void harf()
        {
        giris:
            Console.Write("Notunuzu giriniz: ");
            double not = Convert.ToDouble(Console.ReadLine());

            if (not >= 0 && not <= 49.9)
                Console.WriteLine("Harf notunuz: FF");
            else if (not >= 50 && not <= 64.9)
                Console.WriteLine("Harf notunuz: DD");
            else if (not >= 65 && not <= 74.9)
                Console.WriteLine("Harf notunuz: CC");
            else if (not >= 75 && not <= 84.9)
                Console.WriteLine("Harf notunuz: BB");
            else if (not >= 85 && not <= 100)
                Console.WriteLine("Harf notunuz: AA");
            else
            {
                Console.WriteLine("Yanlış not girdiniz.");
                goto giris;
            }
            Console.ReadLine();
        }

        private static void bilgiAl()
        {
            string ad;
            string soyad;
            string mail;
            int yas;

            Console.Write("Ad: ");
            ad = Console.ReadLine();

            Console.Write("Soyad: ");
            soyad = Console.ReadLine();

            Console.Write("E-posta: ");
            mail = Console.ReadLine();

            Console.Write("Yas: ");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine();
            Console.WriteLine("Ad: " + ad + "\nSoyad: " + soyad + "\nE-posta: " + mail + "\nYas: " + yas);
            Console.ReadLine();
        }

        private static void bolunuyorMu()
        {
            Console.Write("Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine(sayi + " 2'ye tam bölünüyor.");
            else if (sayi % 3 == 0)
                Console.WriteLine(sayi + " 3'e tam bölünüyor.");
            else if (sayi % 5 == 0)
                Console.WriteLine(sayi + " 5'e tam bölünüyor.");
            else
                Console.WriteLine(sayi + " 2, 3 veya 5'e bölünmüyor.");
            Console.ReadLine();
        }

        private static void kacKati()
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine(sayi + " ikinin katıdır.");
            }
            else if (sayi % 3 == 0)
            {
                Console.WriteLine("Kaç katı ?: " + (sayi / 3));
            }
            else
            {
                Console.WriteLine(sayi % 3);
            }

            Console.ReadLine();
        }

        private static void pozitifNegatif()
        {
            int girilenAdet = 0, pozitifAdet = 0, negatifAdet = 0, pozitifToplam = 0, negatifToplam = 0;

        yapi:
            Console.WriteLine("Sayı girin: ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            girilenAdet++;

            if (sayi > 0)
            {
                pozitifAdet++;
                pozitifToplam += sayi;
            }
            else if (sayi < 0)
            {
                negatifAdet++;
                negatifToplam += sayi;
            }

            if (girilenAdet < 5)
                goto yapi;

            Console.WriteLine("Negatif sayı adedi: " + negatifAdet);
            Console.WriteLine("Negatif sayı toplamı: " + negatifToplam);
            Console.WriteLine("**********************");
            Console.WriteLine("Pozitif sayı adedi: " + pozitifAdet);
            Console.WriteLine("Pozitif sayı toplamı: " + pozitifToplam);

            Console.ReadLine();
        }

        private static void faktoriyelBul()
        {
        yapi:
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int girilen = sayi;
            int faktoriyel = 1;
            if (sayi == 0 || sayi == 1)
            {
                Console.WriteLine(sayi + "!: " + faktoriyel + ".");
                Console.WriteLine("Program sonlandı. Kapatmak için bir tuşa basınız...");
            }

            else if (sayi < 0)
            {
                Console.WriteLine("Yanlış değer girdiniz... Lütfen pozitif bir sayı girin.");
                goto yapi;
            }
            else
            {
            faktoriyelAlma:
                faktoriyel *= sayi;
                sayi--;
                if (sayi >= 1)
                    goto faktoriyelAlma;
                Console.WriteLine(girilen + "!: " + faktoriyel + ".");
                Console.WriteLine("Program sonlandı. Kapatmak için bir tuşa basınız...");
            }
            Console.ReadLine();
        }

        private static void usAlma()
        {
            Console.Write("Tabanı giriniz: ");
            int taban = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üssü giriniz: ");
            int us = Convert.ToInt32(Console.ReadLine());
            int orgUs = us;

            int kuvvet = 1;
            if (us == 0)
                Console.WriteLine(taban + " ^ " + us + ": " + kuvvet);
            else
            {
            usAlma:
                kuvvet *= taban;
                us--;
                if (us >= 1)
                    goto usAlma;
                Console.WriteLine(taban + " ^ " + orgUs + ": " + kuvvet);
            }
            Console.ReadLine();
        }

        private static void aritmetikOrt()
        {
            int toplam = 0, giris = 0;
            int sayi;

        sayiAl:
            Console.Write("Bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            giris++;

            if (sayi > 0 && sayi <= 100)
            {
                toplam += sayi;
            }
            else
            {
                Console.WriteLine("Girilen sayı 0-100 aralığında değil...");
                giris--;
                goto sayiAl;
            }
            if (giris < 3)
                goto sayiAl;
            Console.WriteLine("Girilen sayıların aritmetik ortalaması: " + (double)((toplam) / giris));
            Console.ReadLine();
        }

        private static void whileOrnek1()
        {
            Console.WriteLine("Birşey girin (Çıkmak için 'kapat' yazın): ");
            string giris = Console.ReadLine();

            while (giris.ToLower() != "kapat")
            {
                Console.WriteLine(giris);
                Console.WriteLine("Birşey girin (Çıkmak için 'kapat' yazın): ");
                giris = Console.ReadLine();
            }
        }

        private static void whileOrnek2()
        {
            Console.Write("Bir sayı girin (Çıkmak için 'bitir'):");
            string girilen = Console.ReadLine();
            int toplam = 0;

            while (girilen != "bitir")
            {
                int sayi = Convert.ToInt32(girilen);
                toplam += sayi;
                Console.Write("Bir sayı girin (Çıkmak için 'bitir'):");
                girilen = Console.ReadLine();

            }

            Console.WriteLine("Toplam: " + toplam + ". Program bitti.");
            Console.ReadLine();
        }
    }
}
