using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberi // Note: actual namespace depends on the project name.
{
    public static class Menu
    {
        static Dictionary<int,string> menuDic = new Dictionary<int, string>();
        static int mainMenuMin, mainMenuMax = 0;
        public static void MainMenuCreate(string mesaj = ""){
            Console.Clear();
            menuDic.Clear();
            menuDic.Add(1,"Yeni Numara Kaydetmek");
            menuDic.Add(2,"Varolan Numarayı Silmek");
            menuDic.Add(3,"Varolan Numarayı Güncelleme");
            menuDic.Add(4,"Rehberi Listelemek");
            menuDic.Add(5,"Rehberde Arama Yapmak");

            mainMenuMin = menuDic.Keys.Min();
            mainMenuMax = menuDic.Keys.Max();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine(new string('*',43));

            foreach (var menu in menuDic)
            {
                Console.WriteLine("({0}) {1}", menu.Key, menu.Value); 
            }

            if(mesaj != null)
                Console.WriteLine(mesaj);
        }

        public static int MainMenuMin(){
            return mainMenuMin;
        }

        public static int MainMenuMax(){
            return mainMenuMax;
        }
    }

}