using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkiSayiBirIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************");
            Console.WriteLine("***********İŞLEM SEÇİN**********");
            Console.WriteLine("**********+ -> Toplama**********");
            Console.WriteLine("**********- -> Çıkarma**********");
            Console.WriteLine("**********/ -> Çarpma***********");
            Console.WriteLine("*********** -> Bölme************");
            Console.WriteLine("********************************");

            Console.Write("İşlem seçin: ");
            string islem = Console.ReadLine();

            Console.WriteLine(islemler(sayi1, sayi2, islem));

            Console.ReadLine();
        }

        private static double islemler(int sayi1, int sayi2, string islem)
        {
            double sonuc;
            switch (islem)
            {
                case "+":
                    return Convert.ToDouble(sayi1 + sayi2);
                    
                case "-":
                    return Convert.ToDouble(sayi1 - sayi2);
                    
                case "/":
                    return Convert.ToDouble(sayi1 / sayi2);
                   
                case "*":
                    return Convert.ToDouble(sayi1 * sayi2);
                default:
                    Console.WriteLine("Yanlış işlem seçtiniz.");
                    return 0.0;
                
            }
            
        }
    }
}
