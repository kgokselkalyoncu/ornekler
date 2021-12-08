using System;
using System.Collections.Generic;
using System.Linq;

namespace odev_1 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuestionTitle(1);
            Soru1();

            QuestionTitle(2);
            Soru2();

            QuestionTitle(3);
            Soru3();

            QuestionTitle(4);
            Soru4();

        }

        public static void Soru1(){

            #region n değeri

                a1:
                Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                string? nStr = Console.ReadLine();
                if(nStr == null || nStr == "")
                    goto a1;

                int n = 0;

                try
                {
                    n = Convert.ToInt32(nStr);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Girdiğiniz değer sayı değildir.");
                    goto a1;
                }

                if(n < 0){
                    Console.WriteLine("Girdiğiniz sayı pozitif değildir.");
                    //return Soru1();
                    goto a1;
                }

            #endregion
            
            #region ciftSayilar

                string ciftSayilar = "";

                for(int i = 1; i <= n; i++){
                    a2:
                    Console.WriteLine("Lütfen {0}. pozitif sayınızı giriniz.", i);
                    string? sayiStr = Console.ReadLine();

                    if(sayiStr == null || sayiStr == "")
                    goto a2;
                    
                    int sayi = 0;

                    try
                    {
                        sayi = Convert.ToInt32(sayiStr); 
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Girdiğiniz {0}. değer sayı değildir.", i);
                        goto a2;
                    }

                    if(sayi < 0){
                        Console.WriteLine("Girdiğiniz {0}. sayı pozitif değildir.", i);
                        goto a2;
                    }

                    if(sayi%2 == 0){
                        ciftSayilar += sayi + " ";
                    }

                }

            #endregion
            
            Console.WriteLine(ciftSayilar);
            QuestionEnd(1);
        }

        public static void Soru2(){

            #region  n değeri
            
                a1:
                Console.WriteLine("Lütfen n değeri için pozitif bir sayı giriniz.");
                string? nStr = Console.ReadLine();
                if(nStr == null || nStr == "")
                    goto a1;

                int n = 0;

                try
                {
                    n = Convert.ToInt32(nStr);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("n değeri için girdiğiniz değer sayı değildir.");
                    goto a1;
                }

                if(n < 0){
                    Console.WriteLine("n değeri için girdiğiniz sayı pozitif değildir.");
                    //return Soru1();
                    goto a1;
                }

            #endregion

            #region m değeri

                a2:
                Console.WriteLine("Lütfen m değeri için pozitif bir sayı giriniz.");
                string? mStr = Console.ReadLine();
                if(mStr == null || mStr == "")
                    goto a2;

                int m = 0;

                try
                {
                    m = Convert.ToInt32(mStr);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("m değeri için girdiğiniz değer sayı değildir.");
                    goto a2;
                }

                if(m < 0){
                    Console.WriteLine("m değeri için girdiğiniz sayı pozitif değildir.");
                    //return Soru1();
                    goto a2;
                }

            #endregion

            #region mEsitTamBolenler

                string mEsitTamBolenler = "";

                for(int i = 1; i <= n; i++){
                    a3:
                    Console.WriteLine("Lütfen {0}. pozitif sayınızı giriniz.", i);
                    string? sayiStr = Console.ReadLine();

                    if(sayiStr == null || sayiStr == "")
                    goto a3;
                    
                    int sayi = 0;

                    try
                    {
                        sayi = Convert.ToInt32(sayiStr); 
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Girdiğiniz {0}. değer sayı değildir.", i);
                        goto a3;
                    }

                    if(sayi < 0){
                        Console.WriteLine("Girdiğiniz {0}. sayı pozitif değildir.", i);
                        goto a3;
                    }

                    if(sayi%m == 0 || sayi == m){
                        mEsitTamBolenler += sayi + " ";
                    }

                }
            
            #endregion
            
            Console.WriteLine(mEsitTamBolenler);
            QuestionEnd(2);
        }

        public static void Soru3(){
            
            #region n değeri

                a1:
                Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
                string? nStr = Console.ReadLine();
                if(nStr == null || nStr == "")
                    goto a1;

                int n = 0;

                try
                {
                    n = Convert.ToInt32(nStr);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Girdiğiniz değer sayı değildir.");
                    goto a1;
                }

                if(n < 0){
                    Console.WriteLine("Girdiğiniz sayı pozitif değildir.");
                    //return Soru1();
                    goto a1;
                }

            #endregion
            
            #region kelimeler

                string kelimeler = "";

                for(int i = 1; i <= n; i++){
                    a2:
                    Console.WriteLine("Lütfen {0}. kelimenizi sayınızı giriniz.", i);
                    string? kelime = Console.ReadLine();

                    if(kelime == null || kelime == "")
                        goto a2;
                    
                    kelimeler = kelime + " " + kelimeler;
                
                }

            #endregion

            Console.WriteLine(kelimeler);
            QuestionEnd(3);
        }

        public static void Soru4(){
            #region cümler girişi
                a1:
                Console.WriteLine("Lütfen bir cümle yazınız.");
                string? cumle = Console.ReadLine();
                if(cumle == null || cumle == "")
                    goto a1;
            #endregion

            #region işlemler
                int toplamKelimeSayisi = cumle.Split(" ").Count();
                int cumleHarfSayisi = string.Join("",cumle.Split(" ")).Length;
            #endregion
            
            Console.WriteLine("Orjinal cümlenin boyu : " + cumle.Length);
            Console.WriteLine("Toplam kelime sayısı : " + toplamKelimeSayisi);
            Console.WriteLine("Toplam harf sayısı : " + cumleHarfSayisi);

            QuestionEnd(4);
        }

        public static void QuestionTitle(int questionNo){
            string beginTitle = new string('*', 36) + " Soru " + questionNo + " " + new string('*', 36);           
            string endTitle = new string('*', 80);
            string question = "";
            Console.WriteLine(beginTitle);
            Console.Write("* ");
            
            switch (questionNo)
            {
                case 1:
                    question = "Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.";
                break;
                case 2:
                    question = "Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.";
                break;
                case 3:
                    question = "Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.";
                break;
                case 4:
                    question = "Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.";
                break;
            }
            
            int length = question.Length;
            for(int i = 0; i < length; i++){
                Console.Write(question.Substring(i,1));
                if(i%75 == 0 && i != 0){
                    Console.WriteLine(" *");
                    Console.Write("* ");
                }
            }

            Console.Write("\n");
            Console.WriteLine(endTitle);
        }

        public static void QuestionEnd(int questionNo){
            string beginTitle = new string('*', 33) + " Soru " + questionNo + " Bitti " + new string('*', 33);           
            string endTitle = new string('*', 80);

            Console.WriteLine(endTitle);
            Console.WriteLine(beginTitle);
            Console.WriteLine(endTitle);
        }
    }
}