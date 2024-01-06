// DatabaseLogger class implements ILogger interface and writes logs to a database.
using System;

namespace İnterface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Writes log to the database.");
        }
    }
}