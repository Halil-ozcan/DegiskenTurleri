using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenFaaliyetAlanlari
{
    internal class Program
    {

        static string s2 = "Hasan";
        static void Main(string[] args)
        {
             string s1 = "Halil";
            s1 = "Yakup";

            s2 = s1;

        }

        static void Test()
        {
            s2 = "Yavuz";
            // s2 değeri gloabal değişken olduğu için her iki metotda kullanabildik. ama s1 sadece bir metota ait bir yerde tanımlı olduğu için test metodunda çağıramadık.
        }
    }
}
