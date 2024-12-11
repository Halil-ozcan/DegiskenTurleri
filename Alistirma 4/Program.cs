using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistirma_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir string tarih değeri alarak bunu DateTime tipine dönüştürüp haftanın hangi gününe denk geldiğini gösterin.

            Console.WriteLine("Merhaba");

            Console.Write("Lütfen bir tarih değeri giriniz : ");
            string date = Console.ReadLine();

            Console.Clear();

            DateTime date1 = Convert.ToDateTime(date);

            Console.WriteLine("sonuc : " + date1.DayOfWeek);
        }
    }
}
