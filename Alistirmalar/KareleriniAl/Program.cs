using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareleriniAl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gelenSayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> kareSayilar = KareAl(gelenSayilar);
            foreach (var item in kareSayilar)
                Console.Write (item+" ");
            Console.ReadLine();
        }
        private static List<int> KareAl(List<int> gelenSayilar)
        {
            List<int> kareSayilar = new List<int>();

            foreach (var item in gelenSayilar)
                kareSayilar.Add((int) Math.Pow(item, 2));

            return kareSayilar;
        }
    }
}
