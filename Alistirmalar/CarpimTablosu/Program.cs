using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                    Console.Write(j + " x " + i + ": " + (i * j) + "\t");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
