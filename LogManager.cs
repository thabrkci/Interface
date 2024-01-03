using System;


namespace İnterface
{
  public class Logmanager : ILogger
  {
    public ILogger _logger;
    public  Logmanager(ILogger logger)
    {
        _logger = logger;
    }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
/*ILogger arabirimi: ILogger adında bir interface tanımlanmıştır. Bu arabirim, WriteLog adında bir metot içerir.

LogManager sınıfı: Bu sınıf, ILogger arabirimini uygular (LogManager : ILogger). Bu sınıf, bir ILogger arabirimine sahip bir örneği içinde tutar.

_logger: Bir ILogger arabirimine ait bir nesneyi tutan özel bir alan (field). Bu alan, LogManager sınıfının ILogger arabirimini uygulayan başka sınıfları içinde tutmasını sağlar.

LogManager constructor'ı: Bu sınıfın bir örneği oluşturulurken, bir ILogger arabirimini uygulayan bir nesne alır ve bu nesneyi _logger alanına atar.

WriteLog metodu: ILogger arabiriminde tanımlanan WriteLog metotunu uygular. Ancak, bu metot içinde _logger alanındaki WriteLog metotunu çağırarak aslında loglama işlemini _logger nesnesine devreder. Bu sayede, LogManager sınıfı farklı ILogger implementasyonlarıyla çalışabilir.

Bu tasarım, sınıflar arasında bağımlılığı azaltmaya ve soyutlamaya yönelik bir örnektir. LogManager sınıfı, loglama işlevselliğini içermez, sadece bu işlevselliği gerçekleştirecek olan ILogger implementasyonlarına bir arayüz sağlar.
*/