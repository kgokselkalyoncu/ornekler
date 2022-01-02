using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberi // Note: actual namespace depends on the project name.
{

    public static class Rehber{
        static Dictionary<int, Kisi> rehberDis = new Dictionary<int, Kisi>();
        public static void AddPerson(){
            Console.Clear();
            Console.Write("Lütfen isim giriniz                  :");
            string? isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz               :");
            string? soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz      :");
            string? telefon = Console.ReadLine();

            Kisi kisi = new Kisi();
            kisi.Isim = isim;
            kisi.Soyisim = soyisim;
            kisi.Telefon = telefon;

            int sira = rehberDis.Count() + 1;
            rehberDis.Add(sira, kisi);

            string mesaj = $"{isim} {soyisim} kişisi başarıyla eklendi.";
            Menu.MainMenuCreate(mesaj);
        }

        public static void RemovePerson(){

            if(!rehberDis.Any()){
                Menu.MainMenuCreate("Rehber boş. Lütfen kayıt ekleyiniz.");
            }
            else{
                Console.Clear();
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string? isimSoyisim = Console.ReadLine();

                Kisi kisi = rehberDis.Where(k => k.Value != null && (k.Value.Isim != null || k.Value.Soyisim != null) && (k.Value.Isim == isimSoyisim || k.Value.Soyisim == isimSoyisim)).FirstOrDefault().Value;
                int kisiIndex = rehberDis.Where(k => k.Value != null && (k.Value.Isim != null || k.Value.Soyisim != null) && (k.Value.Isim == isimSoyisim || k.Value.Soyisim == isimSoyisim)).FirstOrDefault().Key;
    
                if(kisi != null){
                    
                    a3:
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", kisi.Isim, kisi.Soyisim);
                    string? yesNo = Console.ReadLine();
                    if(yesNo == "y"){
                        rehberDis.Remove(kisiIndex);
                        string? mesaj = $"{kisi.Isim} {kisi.Soyisim} rehberden silindi.";
                        Menu.MainMenuCreate(mesaj);
                    }
                    else if(yesNo == "n"){
                        string? mesaj = "Silme işlemi iptal edildi.";
                        Menu.MainMenuCreate(mesaj);
                    }
                    else{
                        Console.WriteLine("Lütfen silmek için y iptal etmek için n değeri giriniz.");
                        goto a3;
                    }
                }
                else{
                    Dictionary<int,string> menuIkiDic = new Dictionary<int, string>();
                    menuIkiDic.Add(1,"Silmeyi sonlandırmak için ");
                    menuIkiDic.Add(2,"Yeniden denemek için      ");

                    int menuIkiMin = menuIkiDic.Keys.Min();
                    int menuIkiMax = menuIkiDic.Keys.Max();
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");

                    foreach (var menu in menuIkiDic)
                    {
                        Console.WriteLine("* {1} : ({0})", menu.Key, menu.Value); 
                    }

                    a4:
                    string? menuIkiId = Console.ReadLine();

                    switch (menuIkiId)
                    {
                        case "1":
                            Menu.MainMenuCreate("Silme işlemini sonlandırdınız.");
                            break;
                        case "2":
                            RemovePerson();
                            break;
                        default:
                            Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuIkiMin, menuIkiMax);
                            goto a4;
                    }

                }
            }
        }

        public static void UpdatePerson(){
            if(!rehberDis.Any()){
                Menu.MainMenuCreate("Rehber boş. Lütfen kayıt ekleyiniz.");
            }
            else
            {
                Console.Clear();
                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin ismini ya da soyismini giriniz:");
                string? isimSoyisim = Console.ReadLine();

                Kisi kisi = rehberDis.Where(k => k.Value != null && (k.Value.Isim != null || k.Value.Soyisim != null) && (k.Value.Isim == isimSoyisim || k.Value.Soyisim == isimSoyisim)).FirstOrDefault().Value;
                int kisiIndex = rehberDis.Where(k => k.Value != null && (k.Value.Isim != null || k.Value.Soyisim != null) && (k.Value.Isim == isimSoyisim || k.Value.Soyisim == isimSoyisim)).FirstOrDefault().Key;

                if(kisi != null)
                {
                    Console.Clear();
                    Console.WriteLine("Boş bıraktığınız alan değeri değişmeyecektir.");
                    Console.Write($"Lütfen {kisi.Isim} kişisinin yeni ismini giriniz               :");
                    string? isim = Console.ReadLine();
                    Console.Write($"Lütfen {kisi.Soyisim} kişisinin yeni soyismini giriniz          :");
                    string? soyisim = Console.ReadLine();
                    Console.Write($"Lütfen {kisi.Telefon} kişisinin yeni telefon numarası giriniz   :");
                    string? telefon = Console.ReadLine();

                    Kisi guncelKisi = new Kisi();
                    guncelKisi.Isim = isim != "" ? isim : kisi.Isim;
                    guncelKisi.Soyisim = soyisim != "" ? soyisim : kisi.Soyisim;
                    guncelKisi.Telefon = telefon != "" ? telefon : kisi.Telefon;

                    rehberDis[kisiIndex] = guncelKisi;

                    string mesaj = $"{kisi.Isim} {kisi.Soyisim} kişisi {guncelKisi.Isim} {guncelKisi.Soyisim} olarak başarıyla güncellendi.";
                    Menu.MainMenuCreate(mesaj);
                }
                else{
                    Dictionary<int,string> menuUcDic = new Dictionary<int, string>();
                    menuUcDic.Add(1,"Güncellemeyi sonlandırmak için ");
                    menuUcDic.Add(2,"Yeniden denemek için           ");

                    int menuUcMin = menuUcDic.Keys.Min();
                    int menuUcMax = menuUcDic.Keys.Max();
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");

                    foreach (var menu in menuUcDic)
                    {
                        Console.WriteLine("* {1} : ({0})", menu.Key, menu.Value); 
                    }

                    a5:
                    string? menuUcId = Console.ReadLine();

                    switch (menuUcId)
                    {
                        case "1":
                            Menu.MainMenuCreate("Güncelleme işlemini sonlandırdınız.");
                            break;
                        case "2":
                            UpdatePerson();
                            break;
                        default:
                            Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuUcMin, menuUcMax);
                            goto a5;
                    }

                }
            }
        }

        public static void ListPerson(){

            if(!rehberDis.Any()){
                Menu.MainMenuCreate("Rehber boş. Lütfen kayıt ekleyiniz.");
            }
            else
            {
                Console.Clear();

                Dictionary<int,string> menuDortDic = new Dictionary<int, string>();
                menuDortDic.Add(1,"İsim A-Z Sıralama");
                menuDortDic.Add(2,"İsim Z-A Sıralama");
                menuDortDic.Add(3,"Soyisim A-Z Sıralama");
                menuDortDic.Add(4,"Soyisim Z-A Sıralama");

                int menuDortMin = menuDortDic.Keys.Min();
                int menuDortMax = menuDortDic.Keys.Max();

                Console.WriteLine("Sıralama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine(new string('*',43));

                foreach (var menu in menuDortDic)
                {
                    Console.WriteLine("{1}: ({0})", menu.Key, menu.Value); 
                }

                a6:
                string? menuDortId = Console.ReadLine();
                
                switch (menuDortId)
                {
                    case "1":
                        rehberDis = rehberDis.OrderBy(k => k.Value.Isim).ToDictionary(x => x.Key, x => x.Value);
                        break;
                    case "2":
                        rehberDis = rehberDis.OrderByDescending(k => k.Value.Isim).ToDictionary(x => x.Key, x => x.Value);
                        break;
                    case "3":
                        rehberDis = rehberDis.OrderBy(k => k.Value.Soyisim).ToDictionary(x => x.Key, x => x.Value);
                        break;
                    case "4":
                        rehberDis = rehberDis.OrderByDescending(k => k.Value.Soyisim).ToDictionary(x => x.Key, x => x.Value);
                        break;
                    default:
                        Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuDortMin, menuDortMax);
                        goto a6;
                }
                Console.Clear();
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine(new string('*',43));
                foreach (var rehber in rehberDis)
                {
                    Console.WriteLine("isim: {0}", rehber.Value.Isim);
                    Console.WriteLine("Soyisim: {0}", rehber.Value.Soyisim);
                    Console.WriteLine("Telefon Numarası: {0}", rehber.Value.Telefon);
                    Console.WriteLine("-");
                }
                Console.WriteLine("Lütfen Ana Menü için herhangi bir tuşa basınız.");
                string? key = Console.ReadLine();

                if(key != null)
                    Menu.MainMenuCreate();

            }

        }

        public static void SearchPerson(){
            
            if(!rehberDis.Any()){
                Menu.MainMenuCreate("Rehber boş. Lütfen kayıt ekleyiniz.");
            }
            else{
                Console.Clear();
                
                Dictionary<int,string> menuBesDic = new Dictionary<int, string>();
                menuBesDic.Add(1,"İsim veya soyisime göre arama yapmak için");
                menuBesDic.Add(2,"Telefon numarasına göre arama yapmak için");

                int menuBesMin = menuBesDic.Keys.Min();
                int menuBesMax = menuBesDic.Keys.Max();
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine(new string('*',43));

                foreach (var menu in menuBesDic)
                {
                    Console.WriteLine("{1}: ({0})", menu.Key, menu.Value); 
                }

                a2:
                string? menuBesId = Console.ReadLine();

                switch (menuBesId)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Lütfen aramak istediğiniz kişinin ismini ya da soyismini giriniz:");
                        string? isimSoyisim = Console.ReadLine();

                        var isimSoyisimList = rehberDis.Where(k => k.Value != null && (k.Value.Isim != null || k.Value.Soyisim != null) && (k.Value.Isim == isimSoyisim || k.Value.Soyisim == isimSoyisim));

                        if(isimSoyisimList.Any()){
                            foreach (var arama in isimSoyisimList)
                            {
                                Console.WriteLine("isim: {0}", arama.Value.Isim);
                                Console.WriteLine("Soyisim: {0}", arama.Value.Soyisim);
                                Console.WriteLine("Telefon Numarası: {0}", arama.Value.Telefon);
                                Console.WriteLine("-");
                            }

                            Console.WriteLine("Lütfen Ana Menü için herhangi bir tuşa basınız.");
                            string? key = Console.ReadLine();

                            if(key != null)
                                Menu.MainMenuCreate();
                        }
                        else{
                            Dictionary<int,string> menuBesAltDic = new Dictionary<int, string>();
                            menuBesAltDic.Add(1,"Aramayı sonlandırmak için      ");
                            menuBesAltDic.Add(2,"Yeniden denemek için           ");

                            int menuBesAltMin = menuBesAltDic.Keys.Min();
                            int menuBesAltMax = menuBesAltDic.Keys.Max();
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");

                            foreach (var menu in menuBesAltDic)
                            {
                                Console.WriteLine("* {1} : ({0})", menu.Key, menu.Value); 
                            }

                            a7:
                            string? menuBesAltId = Console.ReadLine();

                            switch (menuBesAltId)
                            {
                                case "1":
                                    Menu.MainMenuCreate("Arama işlemini sonlandırdınız.");
                                    break;
                                case "2":
                                    SearchPerson();
                                    break;
                                default:
                                    Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuBesAltMin, menuBesAltMax);
                                    goto a7;
                            }
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz:");
                        string? telefon = Console.ReadLine();

                        var telefonList = rehberDis.Where(k => k.Value != null && k.Value.Telefon != null && k.Value.Telefon == telefon);

                        if(telefonList.Any()){
                            foreach (var arama in telefonList)
                            {
                                Console.WriteLine("isim: {0}", arama.Value.Isim);
                                Console.WriteLine("Soyisim: {0}", arama.Value.Soyisim);
                                Console.WriteLine("Telefon Numarası: {0}", arama.Value.Telefon);
                                Console.WriteLine("-");
                            }

                            Console.WriteLine("Lütfen Ana Menü için herhangi bir tuşa basınız.");
                            string? key = Console.ReadLine();

                            if(key != null)
                                Menu.MainMenuCreate();
                        }
                        else{
                            Dictionary<int,string> menuBesAltDic = new Dictionary<int, string>();
                            menuBesAltDic.Add(1,"Aramayı sonlandırmak için      ");
                            menuBesAltDic.Add(2,"Yeniden denemek için           ");

                            int menuBesAltMin = menuBesAltDic.Keys.Min();
                            int menuBesAltMax = menuBesAltDic.Keys.Max();
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");

                            foreach (var menu in menuBesAltDic)
                            {
                                Console.WriteLine("* {1} : ({0})", menu.Key, menu.Value); 
                            }

                            a8:
                            string? menuBesAltId = Console.ReadLine();

                            switch (menuBesAltId)
                            {
                                case "1":
                                    Menu.MainMenuCreate("Arama işlemini sonlandırdınız.");
                                    break;
                                case "2":
                                    SearchPerson();
                                    break;
                                default:
                                    Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuBesAltMin, menuBesAltMax);
                                    goto a8;
                            }
                        }

                        break;
                    default:
                        Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuBesMin, menuBesMax);
                        goto a2;
                }
            }
        }
    
    }

}