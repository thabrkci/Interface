// SmsLogger class implements ILogger interface and writes logs as SMS messages.
using System;

namespace İnterface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Writes log as an SMS.");
        }
    }
}