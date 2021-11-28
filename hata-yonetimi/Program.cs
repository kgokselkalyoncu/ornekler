using System;
using System.Collections.Generic;
using System.Linq;

namespace hata_yonetimi // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş olduğunuz sayı :" + sayi);    
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Hata :" + ex.Message);
            }
            finally
            {
                System.Console.WriteLine("İşlem tamalandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000000");
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Boş değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Veri tipi uygun değil");
                System.Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
                System.Console.WriteLine(ex);
            }
        }
    }
}