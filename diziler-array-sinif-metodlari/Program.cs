using System;
using System.Collections.Generic;
using System.Linq;

namespace diziler_array_sinifi_metodlari // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            System.Console.WriteLine("***** Sırasız Dizi ******");
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            System.Console.WriteLine("***** Sıralı Dizi ******");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //Clear
            System.Console.WriteLine("***** Array Clear ******");
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            //Reverse
            System.Console.WriteLine("***** Array Revers ****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

            //IndexOf
            System.Console.WriteLine("***** Array IndexOf ****");
            System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            System.Console.WriteLine("***** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8]=99;

            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);

        }
    }
}