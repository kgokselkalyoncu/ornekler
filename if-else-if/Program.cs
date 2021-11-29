using System;
using System.Collections.Generic;
using System.Linq;

namespace if_else_if // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >= 6 && time < 11)
                System.Console.WriteLine("Günaydın!");
            else if(time <= 18)
                System.Console.WriteLine("İyi Günler!");
            else
                System.Console.WriteLine("iyi Geceler!");

            string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";

            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler!" : "İyi geceler!";

            System.Console.WriteLine(sonuc);
        }
    }
}