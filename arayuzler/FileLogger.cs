using System;

namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            System.Console.WriteLine("Dosyaya log yazar.");
        }
    }
}