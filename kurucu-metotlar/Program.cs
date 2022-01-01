using System;
using System.Collections.Generic;
using System.Linq;

namespace kurucu_metotlar // Note: actual namespace depends on the project name.
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

            System.Console.WriteLine("*----- Çalışan 1 -----*");

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 12345678;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            System.Console.WriteLine("*----- Çalışan 2 -----*");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 87654321;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            System.Console.WriteLine("*----- Çalışan 3 -----*");

            Calisan calisan3 = new Calisan("Ali","Veli",12341234,"Bilgi İşlem");
            calisan3.CalisanBilgileri();

            System.Console.WriteLine("*----- Çalışan 4 -----*");

            Calisan calisan4 = new Calisan("AAA","BBB");
            calisan4.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string? Ad;
        public string? Soyad;
        public int No;
        public string? Departman;

        public Calisan()
        {}

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışanın Adı:{0}", Ad);
            System.Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            System.Console.WriteLine("Çalışanın Numarası:{0}", No);
            System.Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
            
        }
    }
}