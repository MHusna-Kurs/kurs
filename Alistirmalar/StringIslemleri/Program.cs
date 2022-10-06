using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(TersYaz("lol"));
            Console.ReadLine();
        }

        private static int kelimeSay(string cumle)
        {
            int kelimeSayici = 0;
            string[] dizi = cumle.Split(' ');
            foreach (string item in dizi)
            {
                if (item != " " && item != "")
                    kelimeSayici++;
            }
            return kelimeSayici;
        }

        private static string TersYaz(string kelime)
        {
            string tersKelime = "";

            for (int i = kelime.Length - 1; i >= 0; i--)
                tersKelime += kelime[i];
            return tersKelime;
        }
    }
}
