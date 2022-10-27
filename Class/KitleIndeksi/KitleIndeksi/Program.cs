using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitleIndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            double boy = Convert.ToDouble(Console.ReadLine());
            double kilo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(kilo/(boy*boy));
            Console.ReadLine();
        }
    }
}
