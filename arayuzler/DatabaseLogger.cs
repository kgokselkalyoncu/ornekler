using System;

namespace arayuzler
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            System.Console.WriteLine("Veri tabanı olarak log yazar.");
        }
    }
}