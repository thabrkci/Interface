using System;


namespace İnterface 
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya Log yazar.");
        }
    }



}