using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareleriDondur
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> sayilarinKareleri = new List<int>();

            sayilarinKareleri = kareDondur(sayilar, sayilarinKareleri);

            foreach (int sayi in sayilarinKareleri)
                Console.Write(sayi + " ");
            Console.ReadLine();
        }

        private static List<int> kareDondur(List<int> sayilar, List<int> sayilarinKareleri)
        {
            foreach (int sayi in sayilar)
                sayilarinKareleri.Add((int)Math.Pow(sayi, 2));

            return sayilarinKareleri;
        }
    }
}
