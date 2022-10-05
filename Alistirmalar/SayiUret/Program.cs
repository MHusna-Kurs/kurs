using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiUret
{
    class Program
    {
        static void Main(string[] args)
        {
            int kucukSayi, buyukSayi, sayiAdet;
            Console.Write("Küçük sayıyı girin: ");
            kucukSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Büyük sayıyı girin: ");
            buyukSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayı adedini girin: ");
            sayiAdet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************");
            List<int> rastgeleSayilar = SayiUret(kucukSayi, buyukSayi, sayiAdet);
            foreach (var item in rastgeleSayilar)
                Console.Write(item+" ");
            
            Console.ReadLine();
        }
        
        private static List<int> SayiUret(int kucuk, int buyuk, int sayiAdet)
        {
            Random rnd = new Random();
            List<int> sayilar = new List<int>();
            for (int i = 0; i < sayiAdet; i++)
                sayilar.Add(rnd.Next(kucuk, buyuk));

            return sayilar;
        }
    }
}
