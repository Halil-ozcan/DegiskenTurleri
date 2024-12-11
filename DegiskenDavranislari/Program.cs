using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenDavranislari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string degisken1 = "Halil Özcan";

            string degisken2 = "Hasan Polat";

            degisken1 = degisken2;

            degisken2 = "Erol Sevinç";

            Console.WriteLine(degisken1);

            Console.WriteLine(degisken2);
        }
    }
}
