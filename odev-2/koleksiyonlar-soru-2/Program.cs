using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace koleksiyonlar_soru_2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 20 adet Pozitif sayı giriniz");
            int count = 0;
            int[] sayilarArray = new int[20];

            while (count < 20)
            {
                 a1:
                 Console.WriteLine("Lütfen {0}. sayıyı giriniz : ", count+1);
                 string? _sayiStr = Console.ReadLine();
                 int _sayi = 0;
                 if(int.TryParse(_sayiStr, out _sayi)){
                     if(_sayi > 0){
                         sayilarArray[count] = _sayi;
                     }
                     else{
                         //Negatif sayi hatası
                         Console.WriteLine("Lütfen {0}. sayıyı için Pozitif bir sayı giriniz. ", count+1);
                         goto a1;
                     }
                 }
                 else{
                     // Numeric hata
                     Console.WriteLine("Lütfen {0}. sayıyı için bir sayı giriniz. ", count+1);
                     goto a1;
                 }
                 
                count++;
            }

            Array.Sort(sayilarArray);
            double smallestAverage = sayilarArray.Take(3).Average();

            Array.Reverse(sayilarArray);
            double biggestAverage = sayilarArray.Take(3).Average();

            Console.WriteLine("En Büyük sayıların Ortalamaları : {0}", biggestAverage.ToString());
            Console.WriteLine("En Küçük sayıların Ortalamaları : {0}", smallestAverage.ToString());
            Console.WriteLine("Ortalamaların Toplamı : {0}", (smallestAverage + biggestAverage).ToString());
            
        }
    }
}