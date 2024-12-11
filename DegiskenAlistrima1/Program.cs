using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenAlistrima1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("İsminiz Nedir? ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz Nedir? ");
            string soyisim = Console.ReadLine();

            Console.Write("Yasadığınız Şehri Girin ");
            string sehir = Console.ReadLine();  

            Console.Clear();
            
            Console.WriteLine("isim: " + isim);
            Console.WriteLine("soyism: " + soyisim);
            Console.WriteLine("sehir: " + sehir);

            Console.ReadLine(); 
        }
    }
}
