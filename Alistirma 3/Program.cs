using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("Liütfen bir sayi değeri girin : ");
            string sayi1 = Console.ReadLine();

            Console.Write("Lütfen ikinci sayi değerini girin : ");
            string sayi2 = Console.ReadLine();

            Console.Clear();

            string toplam = sayi1 + sayi2;

            Console.WriteLine("sonuc : " + toplam);

            
        }
    }
}
