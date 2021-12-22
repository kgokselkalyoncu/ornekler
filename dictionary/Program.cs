using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionary // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using System.Collections.Generic;

            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"Aaa Bbb");
            kullanicilar.Add(12,"Ccc Ddd");
            kullanicilar.Add(18,"Deneme Örnek");
            kullanicilar.Add(20,"Test Test");
            kullanicilar.Add(22,"Adı Soyadı");

            //Dizinin elemanlarına erişim
            System.Console.WriteLine("***** Elemanalara Erişim *****");
            System.Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }

            //Count
            System.Console.WriteLine(kullanicilar.Count);

            //Contains
            System.Console.WriteLine(kullanicilar.ContainsKey(12));
            System.Console.WriteLine(kullanicilar.ContainsValue("Deneme"));

            System.Console.WriteLine("******** Remove ********");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item.Value);
            }

            System.Console.WriteLine("***** Keys *******");
            foreach (var item in kullanicilar.Keys)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("***** Values *******");
            foreach (var item in kullanicilar.Values)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}