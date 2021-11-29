using System;
using System.Collections.Generic;
using System.Linq;

namespace donguler_while_foreach // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            
            while (sayac <= sayi)
            {
                 toplam += sayac;
                 sayac++;
            }

            System.Console.WriteLine(toplam/sayi);

            char c = 'a';
            while (c < 'z')
            {
                 System.Console.Write(c);
                 c++;
            }

            System.Console.WriteLine("***** Foreach ******");
            string[] arabalar = {"BMW","Ford", "Toyota","Nissan"};
            foreach (var item in arabalar)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}