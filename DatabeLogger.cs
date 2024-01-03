using System;


namespace İnterface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dataya Log Yazar.");
        }
    }
}