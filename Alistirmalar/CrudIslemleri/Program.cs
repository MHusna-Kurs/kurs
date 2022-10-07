using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudIslemleri
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> kutuphane = new List<string>() { };
            string secenek;

            do
            {
                Console.WriteLine("####### Menu #######");
                Console.WriteLine("### 1- Goruntule ###");
                Console.WriteLine("### 2- Ekle      ###");
                Console.WriteLine("### 3- Sil       ###");
                Console.WriteLine("### 4- Çıkış     ###");
                Console.WriteLine("####################");

                Console.WriteLine();
                Console.Write("Seçenek: ");
                secenek = Console.ReadLine();

                string kitap;
                switch (secenek)
                {
                    case "1":
                        Console.WriteLine("Kütüphane görüntüleme işlemini seçtiniz. İşleminiz yürütülüyor...\n");
                        Goruntule(kutuphane);
                        break;

                    case "2":
                        Console.WriteLine("Kitap ekleme işlemini seçtiniz. Lütfen bir kitap ismi giriniz.");
                        Console.Write("Kitap ismi: ");
                        kitap = Console.ReadLine();
                        Ekle(kutuphane, kitap);
                        break;

                    case "3":
                        if (kutuphane.Count == 0)
                            Console.WriteLine("Kütüphane boş, önce ekleme yapmalısınız.");
                        else
                        {
                            Console.WriteLine("Kitap silme işlemini seçtiniz. Lütfen bir kitap ismi giriniz.");
                            Console.Write("Kitap ismi: ");
                            kitap = Console.ReadLine();
                            Sil(kutuphane, kitap);
                        }
                        break;

                    default:
                        Console.WriteLine("Yanlış işlem seçimi yapıldı. Ana menüye yönlendiriliyorsunuz...\n");
                        break;
                }

            } while (secenek != "4");

            Console.WriteLine("Program sonlandırılıyor....");
            Console.ReadLine();
        }

        private static void Goruntule(List<string> kutuphane)
        {
            Console.WriteLine("############################################################");
            Console.Write("Kütüphaneniz: ");
            if (kutuphane.Count == 0)
            {
                Console.WriteLine("Boş.");
                Console.WriteLine("Kütüphanenizde kitap bulunmamaktadır. Ana menüye yönlendiriliyorsunuz...\n");
            }

            else
            {
                foreach (var item in kutuphane)
                    Console.Write(item + " # ");
                Console.WriteLine("\n");
            }
        }

        private static void Ekle(List<string> kutuphane, string kitap)
        {
            if (kutuphane.Contains(kitap))
                Console.WriteLine("Kütüphanede zaten ekli. Ana menüye yönlendiriliyorsunuz...\n");

            else
            {
                kutuphane.Add(kitap);
                Console.WriteLine("Kitap başarıyla eklendi. Ana menüye yönlendiriliyorsunuz...\n");
            }
        }

        private static void Sil(List<string> kutuphane, string kitap)
        {

            if (kutuphane.Contains(kitap))
                kutuphane.Remove(kitap);
            else
                Console.WriteLine("Kütüphanede böyle bir kitap bulunmamaktadır. Ana menüye yönlendiriliyorsunuz...\n");


        }
    }
}
