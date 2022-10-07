using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarekokGetir
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] sayilar = { 8.5D, 6.7D, 9.0D};
            double[] karekokler = SqrtBul(sayilar);

            foreach (var item in karekokler)
                Console.Write(Math.Round(item, 2)+" - ");

            Console.ReadLine();
        }

        private static double[] SqrtBul(double[] sayilar)
        {
            double[] karekokler = new double[sayilar.Length];
            for (int i = 0; i <sayilar.Length; i++)
                karekokler[i] = Math.Sqrt(sayilar[i]);
            return karekokler;
        }
    }
}
