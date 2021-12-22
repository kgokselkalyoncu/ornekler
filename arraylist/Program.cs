using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace arrayList // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Deneme");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //içerisinde verilere erişim
            //System.Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //AddRange
            System.Console.WriteLine("****** Add Range ******");
            string[] renkler = {"kırmızı","sarı","yesil"};
            List<int> sayilar = new List<int>(){10,25,6,19,9,12,65,4,8,1};

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Sort

            System.Console.WriteLine("******* Sort *******");
            liste.Sort();

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //Binary Search
            System.Console.WriteLine("****** Binary Search ******");

            System.Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            System.Console.WriteLine("***** Revers *****");
            liste.Reverse();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            //clear
            liste.Clear();
            System.Console.WriteLine("***** Clear ******");
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}