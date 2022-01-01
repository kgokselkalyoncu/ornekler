using System;
using System.Collections.Generic;
using System.Linq;

namespace struct_kavrami // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Diktortgen diktortgen = new Diktortgen();
            diktortgen.KisaKenar = 3;
            diktortgen.UzunKenar = 4;

            System.Console.WriteLine("Class Alan Hesabı     :{0}", diktortgen.AlanHesapla());

            Diktortgen_Struct diktortgen_Struct = new();
            diktortgen_Struct.KisaKenar = 3;
            diktortgen_Struct.UzunKenar = 5;

            System.Console.WriteLine("Struct Alan Hesabı    :{0}", diktortgen_Struct.AlanHesapla());
        }
    }

    class Diktortgen
    {
        public int KisaKenar { get; set; }  
        public int UzunKenar { get; set; }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Diktortgen_Struct
    {
        public int KisaKenar { get; set; }  
        public int UzunKenar { get; set; }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}