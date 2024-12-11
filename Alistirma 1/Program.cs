using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.WriteLine("Bana bir mesaj notu yazar mısınız?");

            string mesaj = Console.ReadLine();

            int mesajdonusum = Convert.ToInt32(mesaj.Length);

            decimal sonuc = mesajdonusum * 10;

            Console.WriteLine("sonuc : " + sonuc);
            
            Console.ReadLine();
        }
    }
}
