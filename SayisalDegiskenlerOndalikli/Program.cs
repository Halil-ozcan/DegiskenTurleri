using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalDegiskenlerOndalikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Double

            double doubleVal1 = 10.2;
            double doubleVal2 = 10;
            double doubleVal3 = 20.5d;

            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;

            // Decimal

            decimal decimalVal = 10.2M;

            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;

            // Float

            float floatVal = 20.5f;
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.WriteLine(floatMin);
            Console.WriteLine(floatMax);
        }
    }
}
