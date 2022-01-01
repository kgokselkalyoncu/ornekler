using System;
using System.Collections.Generic;
using System.Linq;

namespace inheritance // Note: actual namespace depends on the project name.
{
    public class Canlilar
    {
        protected void Beslenme(){
            System.Console.WriteLine("Canlılar beslenir.");
        }

        protected void Solunum(){
            System.Console.WriteLine("Canlılar solunum yapar.");
        }

        protected void Bosaltim(){
            System.Console.WriteLine("Canlılar boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki(){
            System.Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }

}