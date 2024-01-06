ILogger arayüzü: Bir log yazma metodunu içeren bir arayüz tanımlanır.

FileLogger sınıfı: ILogger arayüzünü uygular ve logları dosyaya yazar.

DatabaseLogger sınıfı: ILogger arayüzünü uygular ve logları bir veritabanına yazar.

LogManager sınıfı: ILogger arayüzünü uygular ve içinde bir ILogger nesnesi tutar. Constructor aracılığıyla bir ILogger nesnesi alır ve WriteLog metodunu çağırarak log yazma işlevselliğini bu nesneye devreder.

SmsLogger sınıfı: ILogger arayüzünü uygular ve logları SMS olarak yazar.

Bu tasarım, farklı loglama stratejilerini bir arayüzle soyutlar ve bu stratejileri birbirinden bağımsız hale getirir. LogManager sınıfı, farklı loglama stratejileriyle çalışabilir, çünkü hangi strateji kullanılacağı runtime'da belirlenebilir.
------------------------------------------
ILogger interface: An interface containing a log writing method is defined.

FileLogger class: Implements the ILogger interface and writes logs to a file.

DatabaseLogger class: Implements the ILogger interface and writes logs to a database.

LogManager class: Implements the ILogger interface and maintains an ILogger object inside. It gets an ILogger object via a constructor and delegates log writing functionality to it by calling the WriteLog method.

SmsLogger class: Implements the ILogger interface and writes logs as SMS.

This design abstracts the different logging strategies with an interface and makes them independent of each other. The LogManager class can work with different logging strategies, because which strategy to use can be determined at runtime.
------------------------------------------
