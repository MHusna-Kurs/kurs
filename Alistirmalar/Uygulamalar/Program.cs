using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi = Uret(sayiListesi);

            foreach (var item in sayiListesi)
                Console.Write(item + " ");
            Console.ReadLine();


        }

        private static List<int> Uret(List<int> sayiListesi)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                sayiListesi.Add(rnd.Next(0, 100));

            return sayiListesi;
        }
    }
}
