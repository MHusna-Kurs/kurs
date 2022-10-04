using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekSayilariDondur
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] tekSayilar = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = rnd.Next(0, 50);
            
            tekSayilar = TekSayilariDondur(sayilar, tekSayilar);

            foreach (int sayi in tekSayilar)
                Console.Write(sayi+" ");

            Console.ReadLine();
        }

        private static int[] TekSayilariDondur(int[] sayilar, int[] tekSayilar)
        {
            int j = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 1)
                {
                    tekSayilar[j] += sayilar[i];
                    j++;
                }
                    
            }
            return tekSayilar;
        }
    }
}
