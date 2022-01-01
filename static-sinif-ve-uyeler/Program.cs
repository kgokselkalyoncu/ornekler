using System;
using System.Collections.Generic;
using System.Linq;

namespace static_sinif_ve_uyeler // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Ali","Veli","Bilgi İşlem");
            
            System.Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan2 = new Calisan("AAA","xxx","Bilgi İşlem");
            Calisan calisan3 = new Calisan("CCC","yyy","Bilgi İşlem");

            System.Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            System.Console.WriteLine("Toplama işlemi sonucu: {0}" , Islemler.Topla(100,200));
            System.Console.WriteLine("Çıkarma işlemi sonucu: {0}" , Islemler.Cikar(400,50));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }
        
        private string? Isim;
        private string? Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
        }

    }

    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2){
            return sayi1 + sayi2;
        }

        public static long Cikar (int sayi1, int sayi2){
            return sayi1 - sayi2;
        }
    }
}