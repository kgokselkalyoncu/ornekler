using System;
using System.Collections.Generic;
using System.Linq;

namespace Diziler // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);

            System.Console.WriteLine("Lütfen dizi elemanaları sayısı giriniz: ");
            string? diziUznStr = Console.ReadLine();
            string _u = diziUznStr != null ? diziUznStr : "0";
            int diziUzunluğu = int.Parse(_u);
            int[] sayiDizisi = new int[diziUzunluğu];
            
            for(int i=0; i < diziUzunluğu; i++){
                System.Console.WriteLine("Lütfen {0}. sayıyı giriniz :", i+1);
                string? diziValue = Console.ReadLine();
                string _v = diziValue != null ? diziValue : "0";
                sayiDizisi[i] =  int.Parse(_v);
            }

            int toplam = 0;
            foreach(var sayi in sayiDizisi)
                toplam += sayi;
            
            System.Console.WriteLine("Ortalama :" + toplam/diziUzunluğu);
        }
    }
}