using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenAlistirmalar2
{
    internal class Program
    {
    
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba");

            Console.Write("İsiminizi Giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminizi Giriniz: ");
            string soyisim = Console.ReadLine();

            Console.Write("Şehrinizi Giriniz: ");
            string sehir = Console.ReadLine();


            Console.Write("Yaşınızı Giriniz: ");
            
            int yas = Convert.ToInt32(Console.ReadLine());

            
            Console.Clear();


            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Şehir : " + sehir);
            Console.WriteLine("Yaş : " + yas);

            Console.ReadLine();

        }
    }
}
