using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string metin1 = "100";

            int s1 = int.Parse(metin1);
            int s2 = Convert.ToInt32(metin1); 

            // Parse ile convert arasındaki en temel fark parse de null değer algılandığında yada farklı bir değer olduğunda hata verir. Convertte ise default değer neyse onu ekrana gösterir.

            string metin2 = "true";
            bool b1 = bool.Parse(metin2);
            bool b2 = Convert.ToBoolean(metin2);

            string metin3 = null;

            //decimal d1 = decimal.Parse(metin3); 
            decimal d2 = Convert.ToDecimal(metin3); 
        }
    }
}
