using System;
using System.Collections.Generic;
using System.Linq;

namespace arayuzler_ornek // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Focus focus = new Focus();
            System.Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(focus.KacTekerlektenOlusur());
            System.Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new Civic();
            System.Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(civic.KacTekerlektenOlusur());
            System.Console.WriteLine(civic.StandartRengiNe().ToString());
        }
    }
}