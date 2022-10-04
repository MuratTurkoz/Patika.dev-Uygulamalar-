using System;

namespace Ders_26_OOP_Interface
{
    public class FireBaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("FireBase eklendi"); ;
        }
    }
}