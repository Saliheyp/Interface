using System;

namespace arayuzler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FİleLogger fİleLogger = new FİleLogger();
            fİleLogger.writeLog();

            DataBaseLogger dataBaseLogger = new();
            dataBaseLogger.writeLog();

            SmsLogger smsLogger = new();
            smsLogger.writeLog();

            LogManager logManager = new LogManager(new FİleLogger());
            logManager.writeLog();
        }
    }
}