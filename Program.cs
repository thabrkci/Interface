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

        Logmanager logmanager = new Logmanager(new FileLogger());
        logmanager.WriteLog();
        
    }
}
