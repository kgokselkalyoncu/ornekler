using System;
using System.Collections.Generic;
using System.Linq;

namespace inheritance // Note: actual namespace depends on the project name.
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon(){
            System.Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            System.Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }

        public void SurunerekHaraketEtmek(){
            System.Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        }
        public void Ucmak(){
            System.Console.WriteLine("Kuşlar uçar.");
        }
    }

}