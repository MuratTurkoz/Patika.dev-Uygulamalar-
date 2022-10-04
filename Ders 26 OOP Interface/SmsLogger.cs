using System;

namespace Ders_26_OOP_Interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms eklendi"); ;
        }
    }
}