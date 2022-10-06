using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCalismalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PuanTopla("mehmet", 15, 100, 60, 70, 80, 90));
            Console.ReadLine();
        }

        private static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
                toplam += item;
            Console.WriteLine("Params parametreli metod çağırıldı.");
            return toplam;
        }

        private static int Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Normal parametreli metod çağırıldı.");
            return sayi1 + sayi2;
        }

        private static int PuanTopla(string isim, int yas, params int[] puanlar)
        {
            Console.WriteLine("Adı: " + isim);
            Console.WriteLine("Yaşı: " + yas);

            return Topla(puanlar);
        }
    }
}
