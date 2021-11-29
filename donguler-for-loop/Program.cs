using System;
using System.Collections.Generic;
using System.Linq;

namespace donguler_for_loop // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if(i%2 == 1)
                    System.Console.WriteLine(i);
            }

            //1-1000 tek ve çift sayıların toplamı
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }

            System.Console.WriteLine("Tek Toplam :" + tekToplam);
            System.Console.WriteLine("Çift Toplam :" + ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    break;
                System.Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue;
                System.Console.WriteLine(i);
            }
        }
    }
}