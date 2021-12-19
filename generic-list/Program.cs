using System;
using System.Collections.Generic;
using System.Linq;

namespace generic_list // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            foreach(var sayi in sayiListesi)
                System.Console.WriteLine(sayi);
            
            foreach(var renk in renkListesi)
                System.Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));

            //Listeden elemen çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));

            //Liste içerisinde Arama
            if(sayiListesi.Contains(10))
                System.Console.WriteLine("10 Liste içersinde bulundu!");
            
            //Eleman ile index'e erişme
            System.Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            hayvanlarListesi.ForEach(hayvan => System.Console.WriteLine(hayvan));

            //Listeyi nasıl temizleriz
            hayvanlarListesi.Clear();

            //List içerisinde nese tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "AAA";
            kullanici1.Soyisim = "BBB";
            kullanici1.Yas = 45;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "ccc";
            kullanici2.Soyisim = "ddd";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();


            yeniListe.Add(new Kullanıcılar(){
                Isim = "Ad",
                Soyisim = "Soyad",
                Yas = 19
            });

            foreach (var kullanici in kullaniciListesi)
            {
                System.Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                System.Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                System.Console.WriteLine("Kullanıcı Yas: " + kullanici.Yas);
            }

            kullaniciListesi.Clear();
        }
    }

    public class Kullanıcılar{
        private string isim = "";
        private string soyisim = "";
        private int yas;

        public string Isim { get => isim; set=> isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; } 
        public int Yas { get => yas; set => yas = value; }
    }
}
