using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizlardanUcgen
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void normalUcgenCiz()
        {
            for (int i = 1; i <= 20; i++)
            {
                
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void normalUcgeninTersiniCiz()
        {
            for (int i = 20; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }


}
