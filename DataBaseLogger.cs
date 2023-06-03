using System;

namespace arayuzler
{
    public class DataBaseLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Database'e yazar");
        }
    }

}