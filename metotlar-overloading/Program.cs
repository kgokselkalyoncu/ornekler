using System;
using System.Collections.Generic;
using System.Linq;

namespace metotlar_overloading // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if(sonuc){
                System.Console.WriteLine("Başarlı!");
                System.Console.WriteLine(outSayi);
            }
            else{
                System.Console.WriteLine("Başarısız!");
            }

            Metotlar met = new Metotlar();
            met.Topla(2,3, out int t);
            System.Console.WriteLine(t);

            int i = 12313;
            met.EkranaYazdir(i);
            met.EkranaYazdir("12414");
            met.EkranaYazdir("test","aaa");
        }
    }

    public class Metotlar{
        public void Topla(int a, int b, out int toplam){
            toplam = a + b;
        }
        public void EkranaYazdir(string veri){
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri){
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2){
            System.Console.WriteLine(veri1 + " " + veri2);
        }
    }
}