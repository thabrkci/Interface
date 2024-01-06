using System;


namespace İnterface;
class Program
{
    static void Main(string[] args)
    {
        FileLogger fileLogger = new();
        fileLogger.WriteLog();
        DatabaseLogger databaseLogger = new();
        databaseLogger.WriteLog();
        SmsLogger smsLogger = new();
        smsLogger.WriteLog();

        LogManager logmanager = new LogManager(new FileLogger());
        logmanager.WriteLog();
        
    }
}
