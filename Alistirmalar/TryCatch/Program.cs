using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolen = 0;
            try
            {
                int sayi = (20 / bolen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
