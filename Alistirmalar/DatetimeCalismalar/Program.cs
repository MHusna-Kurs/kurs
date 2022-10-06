using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeCalismalar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dogumTarihi = new DateTime(1999, 5, 26);
            DateTime simdikiZaman = DateTime.Now;

            int yil = simdikiZaman.Year - dogumTarihi.Year;
            int ay = simdikiZaman.Month - dogumTarihi.Month;
            int gun = simdikiZaman.Day - dogumTarihi.Day;

            Console.WriteLine("Yıl: "+yil+" Ay: "+ay+" Gün: "+gun);

            Console.ReadLine();
        }
    }
}
