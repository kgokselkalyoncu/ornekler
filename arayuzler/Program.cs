using System;
using System.Collections.Generic;
using System.Linq;

namespace arayuzler // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileLogger fileLogger = new();
            SmsLogger smsLogger = new();
            DatabaseLogger databaseLogger = new();

            fileLogger.WriteLog();
            smsLogger.WriteLog();
            databaseLogger.WriteLog();

            LogManager logManager = new LogManager(fileLogger);
            logManager.WriteLog();

        }
    }

}