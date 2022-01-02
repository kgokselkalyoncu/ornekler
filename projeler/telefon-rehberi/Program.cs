using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberi // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu.MainMenuCreate();
            a1:
            string? menuId = Console.ReadLine();

            if(menuId != null){
                switch (menuId)
                {
                    case "1":
                        Rehber.AddPerson();
                        goto a1;
                    case "2":
                        Rehber.RemovePerson();
                        goto a1;
                    case "3":
                        Rehber.UpdatePerson();
                        goto a1;
                    case "4":
                        Rehber.ListPerson();
                        goto a1;
                    case "5":
                        Rehber.SearchPerson();
                        goto a1;
                    default:
                        string mesaj = $"Yanlış menü değeri girdiniz. Lütfen {Menu.MainMenuMin()} - {Menu.MainMenuMax()} arası değer giriniz.";
                        Menu.MainMenuCreate(mesaj);
                        goto a1;
                }
            }
            else{
                Console.WriteLine("Boş değer girdiniz lütfen menü listesindeki değerlerden birini giriniz.");
                goto a1;
            }
        
        } 

    }
}