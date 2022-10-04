using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazdir
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Yazdir(sayilar);
            Console.ReadLine();
        }

        private static void Yazdir(List<int> sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
                toplam += item;
            }

            Console.WriteLine("\nToplam: " + toplam);
        }
    }
}
