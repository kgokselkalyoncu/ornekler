using System;
using System.Collections.Generic;
using System.Linq;

namespace recursive_extension_metotlar // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Recursive - ÖZ Yinelemeli
            //3^4 = 3*3*3*3

            int result = 1;
            for(int i = 1; i < 5; i++)
                result = result * 3;
            
            System.Console.WriteLine(result);

            Islemler islemler = new();
            System.Console.WriteLine(islemler.Expo(3,4));

            //Extension Metotlar
            string ifade = "Merhaba Uzaylı ben dünyalı.";
            bool sonuc = ifade.CheckSpaces();
            System.Console.WriteLine(sonuc);
            if(sonuc){
                System.Console.WriteLine(ifade.RemovedWhiteSpaces());
            }

            System.Console.WriteLine(ifade.MakeUpperCase());
            System.Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            System.Console.WriteLine(sayi.IsEvenNumber());

            System.Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler{

        public int Expo(int sayi, int us){
            if(us<2)
                return sayi;
            
            return Expo(sayi, us - 1)*sayi;
        }
    }

    public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }

        public static string RemovedWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param){

            foreach(int item in param){
                System.Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param){
            return param%2 == 0;
        }

        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1);
        }
    }
}