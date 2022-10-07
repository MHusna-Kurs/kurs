using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomSayi = rnd.Next(0, 1000);
            int tahminHakki = 1;
            List<int> tahminler = new List<int>();
            while(tahminHakki <= 15)
            {
                Console.Write("Tahmin: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                tahminler.Add(tahmin);

                if(tahmin < randomSayi)
                    Console.WriteLine("Daha büyük sayı girin.");
                else if(tahmin > randomSayi)
                    Console.WriteLine("Daha küçük sayı girin");
                else
                {
                    Console.WriteLine("Tebrikler buldunuz..");
                    break;
                }
            }

            Console.Write("Tahminler: ");
            foreach (var item in tahminler)
                Console.Write(item +" - ");

            Console.ReadLine();

        }
    }
}
