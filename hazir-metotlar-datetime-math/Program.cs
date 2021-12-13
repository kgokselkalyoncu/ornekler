using System;
using System.Collections.Generic;
using System.Linq;

namespace hazir_metotlar_datetime_math // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(DateTime.Now); // günün tarhini getiri
            System.Console.WriteLine(DateTime.Now.Date);
            System.Console.WriteLine(DateTime.Now.Day);
            System.Console.WriteLine(DateTime.Now.Month);
            System.Console.WriteLine(DateTime.Now.Year);
            System.Console.WriteLine(DateTime.Now.Hour);
            System.Console.WriteLine(DateTime.Now.Minute);
            System.Console.WriteLine(DateTime.Now.Second);

            System.Console.WriteLine(DateTime.Now.DayOfWeek);
            System.Console.WriteLine(DateTime.Now.DayOfYear);
            
            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Console.WriteLine(DateTime.Now.ToLongTimeString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddDays(2));
            System.Console.WriteLine(DateTime.Now.AddHours(3));
            System.Console.WriteLine(DateTime.Now.AddSeconds(30));
            System.Console.WriteLine(DateTime.Now.AddMonths(5));
            System.Console.WriteLine(DateTime.Now.AddYears(10));
            System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime Format
            System.Console.WriteLine(DateTime.Now.ToString("dd")); // Gün sayı
            System.Console.WriteLine(DateTime.Now.ToString("ddd")); // Haftanın Günü Kısa
            System.Console.WriteLine(DateTime.Now.ToString("dddd")); // Haftanın Günü Uzun

            System.Console.WriteLine(DateTime.Now.ToString("MM")); // Ay sayı
            System.Console.WriteLine(DateTime.Now.ToString("MMM")); // Ay'ın Adı kısa
            System.Console.WriteLine(DateTime.Now.ToString("MMMM")); // Ay'ın Adı Uzun

            System.Console.WriteLine(DateTime.Now.ToString("yy")); // Yıl sayı kısa
            System.Console.WriteLine(DateTime.Now.ToString("yyyy")); // Yıl sayı Uzun


            System.Console.WriteLine("********** Math Kütüphanesi **********");
            //Math Kütüphanesi

            System.Console.WriteLine(Math.Abs(-25)); // 25;
            System.Console.WriteLine(Math.Sin(10));
            System.Console.WriteLine(Math.Cos(10));
            System.Console.WriteLine(Math.Tan(10));

            System.Console.WriteLine(Math.Ceiling(22.3)); // 23
            System.Console.WriteLine(Math.Round(22.3)); // 22
            System.Console.WriteLine(Math.Round(22.7)); // 23
            System.Console.WriteLine(Math.Floor(22.7)); // 23

            System.Console.WriteLine(Math.Max(2,6));
            System.Console.WriteLine(Math.Min(2,6));

            System.Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir. 81
            System.Console.WriteLine(Math.Sqrt(9)); // Karakök 9 = 3
            System.Console.WriteLine(Math.Log(9)); // Log 9
            System.Console.WriteLine(Math.Exp(3)); // e^3 
            System.Console.WriteLine(Math.Log10(10)); // 10 tabanın da log 10  1
            
        }
    }
}