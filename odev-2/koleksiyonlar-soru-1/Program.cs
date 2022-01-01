using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace koleksiyonlar_soru_1 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 20 adet Pozitif sayı giriniz");
            int count = 1;
            ArrayList asalSayilarArrayList = new ArrayList();
            ArrayList asalOlmayanSayilarArrayList = new ArrayList();

            while (count < 4)
            {
                 a1:
                 Console.WriteLine("Lütfen {0}. sayıyı giriniz : ", count);
                 string? _sayiStr = Console.ReadLine();
                 int _sayi = 0;
                 if(int.TryParse(_sayiStr, out _sayi)){
                     if(_sayi > 0){
                            int sayininYarisi = _sayi/2 ;
                            bool asalSayiChecked = true;
                            for(int i = 2; i <= sayininYarisi; i++){
                                if(_sayi%i == 0){
                                    asalOlmayanSayilarArrayList.Add(_sayi);
                                    asalSayiChecked = false;
                                    break;
                                }
                            }

                            if(asalSayiChecked)
                                asalSayilarArrayList.Add(_sayi);
                     }
                     else{
                         //Negatif sayi hatası
                         Console.WriteLine("Lütfen {0}. sayıyı için Pozitif bir sayı giriniz. ", count);
                         goto a1;
                     }
                 }
                 else{
                     // Numeric hata
                     Console.WriteLine("Lütfen {0}. sayıyı için bir sayı giriniz. ", count);
                     goto a1;
                 }
                 
                count++;
            }

            asalSayilarArrayList.Sort();
            asalOlmayanSayilarArrayList.Sort();

            int asalSayilarCount = asalSayilarArrayList.Count;
            int asalSayilarToplam = 0;
            System.Console.WriteLine("---- Asal Sayıların Sıralı hali ----");
            foreach (int sayi in asalSayilarArrayList)
            {
                asalSayilarToplam += sayi;
                System.Console.WriteLine(sayi);
            }
            System.Console.WriteLine("---- Asal Sayıların Sıralı hali ----");

            System.Console.WriteLine("Asal Sayıların Eleman Sayisi : {0}", asalSayilarCount);
            System.Console.WriteLine("Asal Sayıların Ortalaması : {0}", asalSayilarToplam/asalSayilarCount);

            int asalOlmayanSayilarCount = asalOlmayanSayilarArrayList.Count;
            int asalOlmayanSayilarToplam = 0;
            System.Console.WriteLine("---- Asal Olmayan Sayıların Sıralı hali ----");
            foreach (int sayi in asalOlmayanSayilarArrayList)
            {
                asalOlmayanSayilarToplam += sayi;
                System.Console.WriteLine(sayi);
            }
            System.Console.WriteLine("---- Asal Olmayan Sayıların Sıralı hali ----");
            System.Console.WriteLine("Asal Olmayan Sayıların Eleman Sayisi : {0}", asalOlmayanSayilarCount);
            System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması : {0}", asalOlmayanSayilarToplam/asalOlmayanSayilarCount);
        }
    }
}