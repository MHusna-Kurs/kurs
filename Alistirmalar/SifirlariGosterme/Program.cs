using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifirlariGosterme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> orgSayilar = new List<int> { 1, 2, 3, 4, 5, 0, 6, 0, 7, 0, 8, 9, 0, 10 };
            SifirlariGosterme(orgSayilar, true);
            Console.ReadLine();
        }

        private static void SifirlariGosterme(List<int> sayilar, bool sifirlariGoster)
        {
            if (sifirlariGoster == true)
            {
                foreach (int sayi in sayilar)
                {
                    if (sayi != 0)
                        Console.Write(sayi + " ");
                }
            }
            else
            {
                foreach (int sayi in sayilar)
                    Console.Write(sayi + " ");

            }


        }
    }
}
