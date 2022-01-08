using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList // Note: actual namespace depends on the project name.
{
    public class Helper
    {
        public static void Repater(char c = '*', int count = 43){
            Console.WriteLine(new string(c,count));
        }

        public static void ReturnMainMenu(string message = ""){
            WaitAction();
            Menu m = new Menu();
            m.CreateMainMenu(message);
        }

        private static void WaitAction(){
            Console.WriteLine("Lütfen Ana Menü için herhangi bir tuşa basınız.");
            string? key = Console.ReadLine();
        }

        public static List<Person> GetListPerson(){
            List<Person> personList = new List<Person>();

            Person person1 = new Person(){Id = 1, Name = "Personel", Surname = "Bir", Departman = "IK"};
            Person person2 = new Person(){Id = 2, Name = "Personel", Surname = "İki", Departman = "IT"};
            Person person3 = new Person(){Id = 3, Name = "Personel", Surname = "Üç", Departman = "Teknik"};
            Person person4 = new Person(){Id = 4, Name = "Personel", Surname = "Dört", Departman = "Satın Alma"};
            Person person5 = new Person(){Id = 5, Name = "Personel", Surname = "Beş", Departman = "Satın Alma"};

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);

            return personList;  
        }
    }
}