using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList // Note: actual namespace depends on the project name.
{
    public class Menu
    {
        static Dictionary<int,string> menuDic = new Dictionary<int, string>();
        static int mainMenuMin, mainMenuMax = 0;
        public void CreateMainMenu(string mesaj = ""){
            Console.Clear();
            menuDic.Clear();
            menuDic.Add(1,"Board Listelemek");
            menuDic.Add(2,"Board'a Kart Eklemek");
            menuDic.Add(3,"Board'dan Kart Silmek");
            menuDic.Add(4,"Kart Taşımak");

            mainMenuMin = menuDic.Keys.Min();
            mainMenuMax = menuDic.Keys.Max();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Helper.Repater();

            foreach (var menu in menuDic)
            {
                Console.WriteLine("({0}) {1}", menu.Key, menu.Value); 
            }

            if(mesaj != "")
                Console.WriteLine(mesaj);
        }

        public int MainMenuMin(){
            return mainMenuMin;
        }

        public int MainMenuMax(){
            return mainMenuMax;
        }
    }
}