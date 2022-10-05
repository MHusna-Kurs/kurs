using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeItFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 5.0, 4.5, 6.5, 7.9 };
            float[] convertedArray = MakeItFloat(array);

            foreach (var item in convertedArray)
                Console.Write(item + " ");
            Console.ReadLine();
        }

        private static float[] MakeItFloat(double[] array)
        {
            float[] convertedArray = new float[array.Length];
            for (int i = 0; i < array.Length; i++)
                convertedArray[i] = (float)array[i];
            return convertedArray;
        }
    }
}
