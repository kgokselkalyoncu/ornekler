using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList // Note: actual namespace depends on the project name.
{
    public static class Board
    {
        public static Dictionary<int,Card>  cardDictList = new Dictionary<int, Card>();
        public static List<Person> people = Helper.GetListPerson();
        public static void ListBoard(){
            ToDoLine();
            InProgressLine();
            DoneLine();
            Helper.ReturnMainMenu();
        }

        private static void ToDoLine(){
            Console.Clear();
            Console.WriteLine("TODO Line");
            Helper.Repater();
            var cardList = cardDictList.Where( c => c.Value != null && c.Value.BoardType == Constants.BoardType.ToDo);
            if(!cardList.Any())
                Console.WriteLine("~ BOŞ ~");
            else{
                foreach (var card in cardList)
                {
                    Console.WriteLine("Başlık       : {0}", card.Value.Title);
                    Console.WriteLine("İçerik       : {0}", card.Value.Content);
                    Console.WriteLine("Atanan Kişi  : {0}", card.Value.Person.Name + " " + card.Value.Person.Surname);
                    Console.WriteLine("Büyüklük     : {0}", card.Value.Size);
                    Console.WriteLine("-");
                }
            }
        }

        private static void InProgressLine(){
            Console.WriteLine("IN PROGRESS Line");
            Helper.Repater();
            var cardList = cardDictList.Where( c => c.Value != null && c.Value.BoardType == Constants.BoardType.InProgress);
            if(!cardList.Any())
                Console.WriteLine("~ BOŞ ~");
            else{
                foreach (var card in cardList)
                {
                    Console.WriteLine("Başlık       : {0}", card.Value.Title);
                    Console.WriteLine("İçerik       : {0}", card.Value.Content);
                    Console.WriteLine("Atanan Kişi  : {0}", card.Value.Person.Name + " " + card.Value.Person.Surname);
                    Console.WriteLine("Büyüklük     : {0}", card.Value.Size);
                    Console.WriteLine("-");
                }
            }
        }

        private static void DoneLine(){
            Console.WriteLine("DONE Line");
            Helper.Repater();
            var cardList = cardDictList.Where( c => c.Value != null && c.Value.BoardType == Constants.BoardType.Done);
            if(!cardList.Any())
                Console.WriteLine("~ BOŞ ~");
            else{
                foreach (var card in cardList)
                {
                    Console.WriteLine("Başlık       : {0}", card.Value.Title);
                    Console.WriteLine("İçerik       : {0}", card.Value.Content);
                    Console.WriteLine("Atanan Kişi  : {0}", card.Value.Person.Name + " " + card.Value.Person.Surname);
                    Console.WriteLine("Büyüklük     : {0}", card.Value.Size);
                    Console.WriteLine("-");
                }
            }
        }

        public static void AddCardToBoard(){
            Console.Clear();
            Console.Write("Başlık Giriniz                                       :");
            string? title = Console.ReadLine();
            Console.Write("İçerik giriniz                                       :");
            string? content = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5)   :");
            string? sizeId = Console.ReadLine();
            Console.Write("Kişi Seçiniz                                         :");
            string? personId = Console.ReadLine();

            Person person = GetPerson(personId);
            Menu m = new Menu();

            if(person != null){
                Constants.Size size = GetSize(sizeId);
                if(size != Constants.Size.Empty){
                    Card card = new Card();
                    card.Title = title;
                    card.Content = content;
                    card.Size = size;
                    card.PersonId = Convert.ToInt32(personId);
                    card.Person = person;
                    card.BoardType = Constants.BoardType.ToDo;

                    int i = cardDictList.Count();
                    cardDictList.Add(i + 1, card);

                    m.CreateMainMenu(title + " Kartı " + Constants.BoardType.ToDo + " listesine eklendi.");
                }
                else
                    m.CreateMainMenu(sizeId + " ID'li büyüklük bulunamadı. Ekleme işlemi iptal edildi.");
            }
            else
                m.CreateMainMenu("Personel listeniz boş veya " + personId + " ID'li personel bulunamadı. Ekleme işlemi iptal edildi.");
        }

        public static void DeleteCardToBoard(){
            Menu m = new Menu();
            
            if(!cardDictList.Any()){
                m.CreateMainMenu("Rehber boş. Lütfen kayıt ekleyiniz.");
            }
            else{
                Console.Clear();
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                Console.Write("Lütfen kart başlığını yazınız:");
                string? cartTitle = Console.ReadLine();

                var cardList = cardDictList.Where(k => k.Value != null && k.Value.Title != null && k.Value.Title == cartTitle);
                if(cardList.Any())
                {
                    var deleteCards = "";
                    foreach (var card in cardList)
                    {
                        deleteCards += card.Key + " ID'li " + card.Value.Title + " Başlıklı kart " + card.Value.BoardType + " listesinde silindi.\n";
                        cardDictList.Remove(card.Key);
                    }
                    Console.WriteLine(deleteCards);
                    Helper.ReturnMainMenu();
                }
                else
                {
                    Dictionary<int,string> menuBesAltDic = new Dictionary<int, string>();
                    menuBesAltDic.Add(1,"Silmeyi sonlandırmak için      ");
                    menuBesAltDic.Add(2,"Yeniden denemek için           ");

                    int menuBesAltMin = menuBesAltDic.Keys.Min();
                    int menuBesAltMax = menuBesAltDic.Keys.Max();
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");

                    foreach (var menu in menuBesAltDic)
                    {
                        Console.WriteLine("* {1} : ({0})", menu.Key, menu.Value); 
                    }

                    a2:
                    string? menuBesAltId = Console.ReadLine();

                    switch (menuBesAltId)
                    {
                        case "1":
                            m.CreateMainMenu("Silme işlemini sonlandırdınız.");
                            break;
                        case "2":
                            DeleteCardToBoard();
                            break;
                        default:
                            Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuBesAltMin, menuBesAltMax);
                            goto a2;
                    }
                }
            }
        }

        public static void MoveCardToBoard(){
            Menu m = new Menu();
            
            if(!cardDictList.Any()){
                m.CreateMainMenu("Rehber boş. Lütfen kayıt ekleyiniz.");
            }
            else{
                Console.Clear();
                Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                Console.Write("Lütfen kart başlığını yazınız:");
                string? cartTitle = Console.ReadLine();

                var cardSearch = cardDictList.Where(k => k.Value != null && k.Value.Title != null && k.Value.Title == cartTitle);

                if(cardSearch.Any()){
                    Card card = cardSearch.First().Value;
                    int cardIndex = cardDictList.Where(k => k.Value != null && k.Value.Title != null && k.Value.Title == cartTitle).First().Key;

                    if(card != null){
                        Console.WriteLine("Bulunan Kart Bilgileri:");
                        Helper.Repater();
                        Console.WriteLine("Başlık           : {0}", card.Title);
                        Console.WriteLine("İçerik           : {0}", card.Content);
                        Console.WriteLine("Atanan Kişi      : {0}", card.Person.Name + " " + card.Person.Surname);
                        Console.WriteLine("Büyüklük         : {0}", card.Size);
                        Console.WriteLine("Line             : {0}", card.BoardType);

                        Console.WriteLine("");
                        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");

                        Dictionary<int,string> menuAltDic = new Dictionary<int, string>();
                        menuAltDic.Add(1,"TODO");
                        menuAltDic.Add(2,"IN PROGRESS");
                        menuAltDic.Add(3,"DONE");

                        int menuBesAltMin = menuAltDic.Keys.Min();
                        int menuBesAltMax = menuAltDic.Keys.Max();
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");

                        foreach (var menu in menuAltDic)
                        {
                            Console.WriteLine("({0}) {1}", menu.Key, menu.Value); 
                        }

                        a3:
                        string? menuBesAltId = Console.ReadLine();
                        string mesaj = "";
                        switch (menuBesAltId)
                        {
                            case "1":
                                mesaj = cardIndex + " ID'li " + card.Title + " Başlıklı kart " + card.BoardType + " listesinden " + Constants.BoardType.ToDo + " listesine taşındı.";
                                card.BoardType = Constants.BoardType.ToDo;
                                cardDictList[cardIndex] = card;
                                Console.Clear();
                                ListBoard();
                                break;
                            case "2":
                                mesaj = cardIndex + " ID'li " + card.Title + " Başlıklı kart " + card.BoardType + " listesinden " + Constants.BoardType.InProgress + " listesine taşındı.";
                                card.BoardType = Constants.BoardType.InProgress;
                                cardDictList[cardIndex] = card;
                                ListBoard();
                                break;
                            case "3":
                                mesaj = cardIndex + " ID'li " + card.Title + " Başlıklı kart " + card.BoardType + " listesinden " + Constants.BoardType.Done + " listesine taşındı.";
                                card.BoardType = Constants.BoardType.Done;
                                cardDictList[cardIndex] = card;
                                ListBoard();
                                break;
                            default:
                                Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuBesAltMin, menuBesAltMax);
                                goto a3;
                        }
                    }
                    else{
                        Dictionary<int,string> menuAltDic = new Dictionary<int, string>();
                        menuAltDic.Add(1,"İşlemi sonlandırmak için       ");
                        menuAltDic.Add(2,"Yeniden denemek için           ");

                        int menuBesAltMin = menuAltDic.Keys.Min();
                        int menuBesAltMax = menuAltDic.Keys.Max();
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");

                        foreach (var menu in menuAltDic)
                        {
                            Console.WriteLine("* {1} : ({0})", menu.Key, menu.Value); 
                        }

                        a4:
                        string? menuBesAltId = Console.ReadLine();

                        switch (menuBesAltId)
                        {
                            case "1":
                                m.CreateMainMenu("Taşıma işlemini sonlandırdınız.");
                                break;
                            case "2":
                                DeleteCardToBoard();
                                break;
                            default:
                                Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuBesAltMin, menuBesAltMax);
                                goto a4;
                        }
                    }
                }
                else
                {
                        Dictionary<int,string> menuAltDic = new Dictionary<int, string>();
                        menuAltDic.Add(1,"İşlemi sonlandırmak için       ");
                        menuAltDic.Add(2,"Yeniden denemek için           ");

                        int menuBesAltMin = menuAltDic.Keys.Min();
                        int menuBesAltMax = menuAltDic.Keys.Max();
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");

                        foreach (var menu in menuAltDic)
                        {
                            Console.WriteLine("* {1} : ({0})", menu.Key, menu.Value); 
                        }

                        a5:
                        string? menuBesAltId = Console.ReadLine();

                        switch (menuBesAltId)
                        {
                            case "1":
                                m.CreateMainMenu("Taşıma işlemini sonlandırdınız.");
                                break;
                            case "2":
                                DeleteCardToBoard();
                                break;
                            default:
                                Console.WriteLine("Yanlış menü değeri girdiniz. Lütfen {0} - {1} arası değer giriniz.", menuBesAltMin, menuBesAltMax);
                                goto a5;
                        }
                }
            }
        }

        public static Constants.Size GetSize(string? sizeId = ""){
            switch (sizeId)
            {
                case "1": 
                    return Constants.Size.XS;
                case "2": 
                    return Constants.Size.S;
                case "3": 
                    return Constants.Size.M;
                case "4": 
                    return Constants.Size.L;
                case "5": 
                    return Constants.Size.XL;
                default:
                    return Constants.Size.Empty;
            }
        }

        public static Person GetPerson(string? personId = ""){
            if(people != null){
                IEnumerable<Person> getPerson = from person in people where person.Id == Convert.ToInt32(personId) select person;
                if(getPerson.Any())
                    return getPerson.First();
                else
                    return new Person();
            }
            return new Person();
        }
    }

    public class Card{
        public string? Title { get; set; }   
        public string? Content { get; set; }
        public Constants.Size Size { get; set; } 
        public int PersonId { get; set;}
        public Person Person { get; set; } = new Person();

        public Constants.BoardType BoardType { get; set; }
    }
}