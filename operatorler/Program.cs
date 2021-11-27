using System;

namespace operatorler
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("****** Atama ve İşlemli Atama Operatörler ******"); 
            // Atama ve İşlemli Atama
            int x = 3;
            int y = 3;
            
            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);

            System.Console.WriteLine("****** Mantıksal Operatörler ******"); 
            // Mantıksal Operatörler
            // ||(or), &&(and), !(not)

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                System.Console.WriteLine("Perfect!"); 
            
            if(isSuccess || isCompleted)
                System.Console.WriteLine("Greate!"); 
            
            if(isSuccess && !isCompleted)
                System.Console.WriteLine("Fine!"); 

            System.Console.WriteLine("****** İlişkisel Operatörler ******"); 
            // İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            System.Console.WriteLine(sonuc);

            sonuc = a > b;
            System.Console.WriteLine(sonuc);

            sonuc = a >= b;
            System.Console.WriteLine(sonuc);

            sonuc = a <= b;
            System.Console.WriteLine(sonuc);

            sonuc = a == b;
            System.Console.WriteLine(sonuc);

            sonuc = a != b;
            System.Console.WriteLine(sonuc);

            System.Console.WriteLine("****** Aritmatik Operatörler ******"); 
            // Aritmatik Operatörler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            System.Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            System.Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;
            System.Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            System.Console.WriteLine(sonuc1);

            sonuc1 = ++sayi1;
            System.Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20%3;
            System.Console.WriteLine(sonuc2);

            double meal_cost = 12.00;
            int tip_percent = 20;

            double tip_cost = ((double)tip_percent/100);
            Console.WriteLine(tip_cost);
        }
    }
}
