using System;
using System.Collections.Generic;
using System.Linq;

namespace metotlar // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            System.Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            System.Console.WriteLine(sonuc);

            metotlar met = new metotlar();
            met.EkranaYazdir(sonuc.ToString());

            int sonuc2 = met.ArttirVeToplaRef(ref a, ref b);
            met.EkranaYazdir(sonuc2.ToString());
            met.EkranaYazdir((a+b).ToString());
        }

        public static int Topla(int deger1, int deger2){
            return (deger1 + deger2);
        }
    }

    public class metotlar{
        public void EkranaYazdir(string veri){
            System.Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;

            return deger1+deger2;
        }

        public int ArttirVeToplaRef(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;

            return deger1+deger2;
        }
    }
}