// FileLogger class implements ILogger interface and writes logs to a file.
using System;

namespace İnterface 
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Writes log to the file.");
        }
    }
}