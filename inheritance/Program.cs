using System;
using System.Collections.Generic;
using System.Linq;

namespace inheritance // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            System.Console.WriteLine("**************");

            Kuslar marti = new Kuslar();
            marti.Ucmak();

            System.Console.WriteLine("**************");

        }
    }

}