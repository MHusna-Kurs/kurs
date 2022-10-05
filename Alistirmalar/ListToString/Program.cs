using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kelimeListesi = new List<string>() { "mehmet","hüsna","kışla"};
            string kelimeBirlesik = listToString(kelimeListesi);

            Console.WriteLine(kelimeBirlesik);
            Console.ReadLine();
        }

        private static string listToString(List<string> kelimeListesi)
        {
            string kelime = "";
            foreach (string item in kelimeListesi)
                kelime += item+" ";

            return kelime;
        }
    }
}
