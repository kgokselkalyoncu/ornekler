using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace koleksiyonlar_soru_3 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz");
            string? cumle = Console.ReadLine();
            List<char> vowelList = new List<char>();

            foreach (var c in cumle)
            {
                if(IsVowel(Convert.ToChar(c)))
                    vowelList.Add(Convert.ToChar(c));
            }

            vowelList.Sort();

            vowelList.ForEach(x => Console.Write(x));            
        }

        public static bool IsVowel(char charValue){
            char[] vowelList = {'a', 'e', 'o', 'ı', 'u', 'ö', 'i', 'ü','A', 'E', 'O', 'I', 'U', 'Ö', 'İ', 'Ü'};
            foreach (var vowel in vowelList)
            {
                if(vowel == charValue)
                    return true;
            }
            return false;
        }
    }
}