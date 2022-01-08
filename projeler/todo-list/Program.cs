using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static Menu menu = new Menu();
        public static void Main(string[] args)
        {
            menu.CreateMainMenu();
            a1:
            string? menuId = Console.ReadLine();

            if(menuId != ""){
                switch (menuId)
                {
                    case "1":
                        Board.ListBoard();
                        goto a1;
                    case "2":
                        Board.AddCardToBoard();
                        goto a1;
                    case "3":
                        Board.DeleteCardToBoard();
                        goto a1;
                    case "4":
                        Board.MoveCardToBoard();
                        goto a1;
                    default:
                        string _mesaj = $"Yanlış menü değeri girdiniz. Lütfen {menu.MainMenuMin()} - {menu.MainMenuMax()} arası değer giriniz.";
                        menu.CreateMainMenu(_mesaj);
                        goto a1;
                }
            }
            else{
                string _mesaj = $"Boş değer girdiniz. Lütfen {menu.MainMenuMin()} - {menu.MainMenuMax()} arası değer giriniz.";
                menu.CreateMainMenu(_mesaj);
                goto a1;
            }
        }
    }
}