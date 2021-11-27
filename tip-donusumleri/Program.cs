using System;

namespace tip_donusumleri
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            System.Console.WriteLine("****** Implicit Conversion ******");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            System.Console.WriteLine("d:"+d);

            long h = d;
            System.Console.WriteLine("h:"+h);

            float i = h;
            System.Console.WriteLine("i:"+i);

            string e = "Deneme";
            char f = 'a';
            object g = e + f + d;
            System.Console.WriteLine("g:"+g);

            // Explicit Conversion (Blinçli Dönüşüm)
            System.Console.WriteLine("****** Explicit Conversion ******");

            int x = 4;
            byte y = (byte)x;
            System.Console.WriteLine("y:"+y);

            int z = 100;
            byte t = (byte)z;
            System.Console.WriteLine("t:"+t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("y:"+v);

            // ToString Methodu
            System.Console.WriteLine("****** ToString Methodu ******");

            int xx = 6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy:"+yy);

            string zz = (12.5f).ToString();
            System.Console.WriteLine("zz:"+zz);

            // System.Convert
            System.Console.WriteLine("****** System.Convert ******");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            System.Console.WriteLine("Toplam:"+Toplam);

            // Parse
            System.Console.WriteLine("****** Parse Method ******");
            ParseMethod();

        }

        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            System.Console.WriteLine("rakam1 :" + rakam1);
            System.Console.WriteLine("double1 :" + double1);
        }
    }
}
