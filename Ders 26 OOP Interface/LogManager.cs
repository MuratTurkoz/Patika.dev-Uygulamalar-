namespace Ders_26_OOP_Interface
{
    public class LogManager : ILogger
    {
        public ILogger _Ilogger;
        public LogManager(ILogger Ilogger)
        {
            _Ilogger = Ilogger;
        }

        public void WriteLog()
        {
            _Ilogger.WriteLog();
        }
    }
}