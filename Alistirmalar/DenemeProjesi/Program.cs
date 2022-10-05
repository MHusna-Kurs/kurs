using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static double Hesaplama(double sayi1, double sayi2, char islem)
        {
            double sonuc = 0;

            if (islem == '+')
                sonuc = sayi1 + sayi2;

            else if (islem == '-')
                sonuc = sayi1 - sayi2;

            else if (islem == '*')
                sonuc = sayi1 * sayi2;

            else if (islem == '/')
                sonuc = sayi1 / sayi2;
            else
                Console.WriteLine("Yanlış işlem seçimi");

            return sonuc;
        }
    }
}
