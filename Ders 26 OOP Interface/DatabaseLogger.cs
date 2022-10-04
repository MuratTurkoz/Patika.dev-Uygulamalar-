using System;

namespace Ders_26_OOP_Interface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Databse eklendi"); ;
        }
    }
}