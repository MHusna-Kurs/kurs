using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxBul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayı: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayı: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int max = IkilidenBuyugu(sayi1, sayi2);
            Console.WriteLine(max+"");

            Console.WriteLine(EnBuyugu(10,20,34,12,15,3,2,1,9,8,76));
            Console.ReadLine();
        }

        private static int IkilidenBuyugu(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
                return sayi1;
            else if(sayi2 > sayi1)
                return sayi2;
            else
                return sayi1;
        }

        private static int EnBuyugu(params int[] sayilar)
        {
            int enBuyuk = 0;
        
            foreach (int sayi in sayilar)
            {
                if (sayi > enBuyuk)
                    enBuyuk = sayi;
            }

            return enBuyuk;
        }
    }
}
