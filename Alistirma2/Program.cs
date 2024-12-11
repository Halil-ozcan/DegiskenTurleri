using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("Lütfen String bir Karakter Girer Misiniz ? ");
            char karakter = Convert.ToChar(Console.ReadLine()); 

            Console.Clear();

            int asci = Convert.ToInt32(karakter); 

            Console.WriteLine("sonuc : " + asci);
        }
    }
}
