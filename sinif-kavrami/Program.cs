using System;
using System.Collections.Generic;
using System.Linq;

namespace sinif_kavrami // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //     {
            //         //Metot Komutları
            //     }
            // }

            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 12345678;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            System.Console.WriteLine("************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 87654321;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string? Ad;
        public string? Soyad;
        public int No;
        public string? Departman;

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışanın Adı:{0}", Ad);
            System.Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            System.Console.WriteLine("Çalışanın Numarası:{0}", No);
            System.Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
            
        }
    }
}