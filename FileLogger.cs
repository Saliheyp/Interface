using System;

namespace arayuzler
{
    public class FİleLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya log yazar");
        }
    }
}