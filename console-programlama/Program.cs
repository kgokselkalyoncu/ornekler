using System;

namespace console_programalama
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? name = "";
            string? surname = "";

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please Name enter");
            name = Console.ReadLine();
            Console.WriteLine("Please Surname enter");
            surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
