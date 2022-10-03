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
            string strGirilen = Console.ReadLine();
            int intGirilen;
            int toplam = 0;

            bool isNumber = int.TryParse(strGirilen, out intGirilen);

            while (isNumber)
            {
                toplam += intGirilen;
                Console.Write("Bir sayı girin (Çıkmak için 'bitir'):");
                strGirilen = Console.ReadLine();
                isNumber = int.TryParse(strGirilen, out intGirilen);

            }
            Console.WriteLine("Toplam: " + toplam + ". Program bitti.");
            Console.ReadLine();
        }

        private static void ikiVeUc()
        {
            int i = 1;
            string sonuc;
            while (i <= 100)
            {
                if (i % 2 == 0)
                    sonuc = i + " çifttir.";
                else
                    sonuc = i + " tektir";
                if (i % 3 == 0)
                    sonuc += " Ve üçe bölünebilir.";

                Console.WriteLine(sonuc);
                i++;
            }

            Console.ReadLine();
        }

        private static void sayiYaz()
        {
            int sayi = 1;

        yapi:
            Console.WriteLine(sayi);
            sayi++;

            if (sayi < 10)
            {
                if (sayi != 7)
                {
                    if (sayi == 9)
                        sayi = sayi + 2;
                    else
                        goto yapi;
                }
                else
                {
                    sayi++;
                    goto yapi;
                }

            }
            Console.ReadLine();
        }

        private static void girisKontrol()
        {
            string mail;
            string sifre;
            bool dogruMu = false;

            do
            {
                Console.Write("E-mail girin: ");
                mail = Console.ReadLine();

                Console.Write("Şifre girin: ");
                sifre = Console.ReadLine();

                if (mail == "smart@pro.net" && sifre == "SP123")
                    dogruMu = true;

            } while (dogruMu == false);

            Console.WriteLine("Giriş başarılı.");
            Console.ReadLine();
        }

        private static void araliktakileriYaz()
        {
            Console.Write("1. sayıyı girin: ");
            int ilkSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı girin: ");
            int ikinciSayi = Convert.ToInt32(Console.ReadLine());

            if (ilkSayi > ikinciSayi)
                for (int i = ikinciSayi; i <= ilkSayi; i++)
                    Console.Write(i + " ");
            else if (ikinciSayi > ilkSayi)
                for (int i = ilkSayi; i <= ikinciSayi; i++)
                    Console.Write(i + " ");
            else
                Console.WriteLine("İki sayı birbirine eşittir.");

            Console.ReadLine();
        }

        private static void kdvliFiyatHesapla()
        {
            double toplamKdvli = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ürünün fiyatını girin: ");
                double fiyat = Convert.ToDouble(Console.ReadLine());
                double geciciKdvli = fiyat + (fiyat * 0.18);
                Console.WriteLine("Kdv'li fiyat: " + geciciKdvli);
                toplamKdvli += geciciKdvli;
            }

            Console.WriteLine("Toplam fiyat: " + toplamKdvli);
            Console.ReadLine();
        }

        private static void degerAl()
        {
            int nToplam = 0, pToplam = 0, ucunToplamlari = 0;
            int giris;
            for (; ; )
            {
                try
                {
                    Console.Write("Sayı girin: ");
                    giris = Convert.ToInt32(Console.ReadLine());
                    if (giris == 0)
                    {
                        Console.WriteLine("Geçersiz sayı girdiniz...");
                        break;
                    }
                    else if (giris == 34 || giris == -34)
                    {
                        Console.WriteLine("Geçersiz sayı girdiniz...");
                        continue;
                    }
                    else if (giris > 0)
                    {
                        pToplam += giris;
                        if (giris % 3 == 0)
                            ucunToplamlari += giris;
                    }
                    else
                    {
                        nToplam += giris;
                        if (giris % 3 == 0)
                            ucunToplamlari += giris;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Hatalı giriş: " + e.Message);
                }
            }

            Console.WriteLine("*******************************");
            Console.WriteLine("Negatif sayıların toplamı: " + nToplam);
            Console.WriteLine("Pozitif sayıların toplamı: " + pToplam);
            Console.WriteLine("Üçün katlarının toplamı: " + ucunToplamlari);
            Console.WriteLine("*******************************");
            Console.ReadLine();
        }

        private static void girilenleriBirlestir()
        {
            string girilenler = "";
            for (; ; )
            {
                Console.Write("Yazılacak: ");
                string girilen = Console.ReadLine();
                if (girilen == "bitti")
                    break;
                else
                    girilenler += "\n" + girilen;
            }

            Console.WriteLine(girilenler);
            Console.ReadLine();
        }

        private static void faktoriyel()
        {
            int fakToplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                int geciciFak = 1;
                for (int j = 1; j <= i; j++)
                    geciciFak *= j;

                fakToplam += geciciFak;
                Console.WriteLine(i + "!: " + geciciFak);
            }

            Console.WriteLine("Faktoriyellerin toplamı: " + fakToplam);
            Console.ReadLine();
        }

        private static void kareBul()
        {
            int kareToplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                int kare = i * i;
                kareToplam += kare;
                Console.WriteLine(i + " * " + i + ": " + kare);
            }
            Console.WriteLine("Karelerin toplamı: " + kareToplam);
            Console.ReadLine();
        }

        private static void rastgeleSayilar()
        {

            Random rastgele = new Random();
            int[] dizi = new int[10];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(0, 100);
            }
            Console.WriteLine("************************");
            foreach (var sayi in dizi)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
        }

        private static void diziKopyala()
        {
            int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] dizi2 = new int[10];
            Array.Copy(dizi1, 3, dizi2, 1, 5);
            foreach (int sayi in dizi2)
            {
                Console.Write(sayi + " ");
            }
            Console.ReadLine();
        }

        private static void matrisCiz()
        {
            int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0 || j == 4)
                        dizi[i, j] = 2;

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(dizi[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void matrisCiz2()
        {
            int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i + j == 4)
                        dizi[i, j] = 1;

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(dizi[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void matrisCiz3()
        {
            int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                        dizi[i, j] = 1;

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(dizi[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void matrisCiz4()
        {
            int[,] dizi = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || i + j == 4)
                        dizi[i, j] = 1;

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(dizi[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void listeler1()
        {
            List<int> liste1 = new List<int>();
            List<int> liste2 = new List<int>();
            List<int> ortakOlmayan = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                liste1.Add(rnd.Next(10));
                liste2.Add(rnd.Next(10));
            }


            for (int i = 0; i < 5; i++)
            {
                if (!(liste2.Contains(liste1[i])) && !ortakOlmayan.Contains(liste1[i]))
                    ortakOlmayan.Add(liste1[i]);

                if (!(liste1.Contains(liste2[i])) && !ortakOlmayan.Contains(liste2[i]))
                    ortakOlmayan.Add(liste2[i]);
            }

            Console.WriteLine("**********************");
            Console.WriteLine("LİSTE 1'IN ELEMANLARI");
            foreach (var item in liste1)
                Console.Write(item + " ");

            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("LİSTE 2'NIN ELEMANLARI");
            foreach (var item in liste2)
                Console.Write(item + " ");

            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("ORTAK OLMAYAN LİSTENİN ELEMANLARI");
            foreach (var item in ortakOlmayan)
                Console.Write(item + " ");

            Console.ReadLine();
        }

        private static void listeler2()
        {
            List<int> liste = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
                liste.Add(rnd.Next(1, 20));

            foreach (var item in liste)
                Console.Write(item + " ");

            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.Write("Tahmininiz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            if (liste.Contains(tahmin))
                Console.WriteLine(tahmin + " sayısının indexi: " + liste.IndexOf(tahmin));

            else
                Console.WriteLine("Sayı bulunamadı.");


            Console.ReadLine();
        }

        private static void odev1()
        {
            Random rnd = new Random();
            int randomSayi = rnd.Next(0, 1000);
            Console.WriteLine(randomSayi);

            int tahminSayisi = 0;
            int[] tahminler = new int[15];
            bool bulunduMu = false;

            do
            {
                Console.Write("Tahmininiz: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                tahminler[tahminSayisi] = tahmin;

                if (tahmin < randomSayi)
                    Console.WriteLine("Düşük sayı girdiniz. Daha yüksek bir sayı girin...");
                else if (tahmin > randomSayi)
                    Console.WriteLine("Büyük sayı girdiniz. Daha küçük bir sayı girin...");
                else
                {
                    bulunduMu = true;
                    Console.WriteLine("Tebrikler !! Bildiniz.... ");
                    Console.Write("Tahminler: ");
                    foreach (int sayi in tahminler)
                    {
                        Console.Write(sayi + " - ");
                    }
                    break;
                }

                tahminSayisi++;
            } while (tahminSayisi < 15);

            if (!bulunduMu)
                Console.WriteLine("Tahmin haklarınız doldu... 15 hak içerisinde sayıyı bulamadınız.");
        }

        private static void diziUret()
        {
            int[] dizi = new int[5];

            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = (i + 1) * 10;

            foreach (int sayi in dizi)
                Console.Write(sayi + " ");

            Console.ReadLine();
        }

        private static void elemanIndexBul()
        {
            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Adıyaman" };
            List<int> indexPositions = new List<int>();
            int index = 0;

            foreach (var sehir in sehirler)
            {
                if (sehir == "Adıyaman")
                    indexPositions.Add(index);
                index++;
            }

            Console.Write("Indexler: ");
            foreach (var item in indexPositions)
                Console.Write(item + " - ");


            Console.ReadLine();

        }

        private static void randomMatrisOlustur()
        {
            int[,] matris = new int[2, 3];
            Random rnd = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    matris[i, j] = rnd.Next(1, 15);
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(string.Format("{0, 2}", matris[i, j]) + " ");

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void matrisOlustur()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*************ÖRNEK 1*****************");
            Console.WriteLine("*************************************");
            int[,] matris = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (((j == i) || (i + j == 4)) && (j >= 2))
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            Console.WriteLine("*************************************");
            Console.WriteLine("*************ÖRNEK 2*****************");
            Console.WriteLine("*************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i < 4 && j < 4)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            Console.WriteLine("*************************************");
            Console.WriteLine("*************ÖRNEK 3*****************");
            Console.WriteLine("*************************************");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || i == 4 || j == 0 || j == 4)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        private static void isimAlVeSirala()
        {
            List<string> isimler = new List<string>();
            int i = 0;
            do
            {
                Console.Write("İsim: ");
                isimler.Add(Console.ReadLine());
                i++;
            } while (i < 5);

            isimler.Sort();
            foreach (var item in isimler)
                Console.Write(item + " ");

            Console.ReadLine();

        }
        
    }
}
