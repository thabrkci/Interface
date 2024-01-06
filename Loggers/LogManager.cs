// LogManager class implements ILogger interface and contains an instance of ILogger.
// It delegates the log writing functionality to the contained ILogger instance.
using System;

namespace İnterface
{
    public class LogManager : ILogger
    {
        public ILogger _logger;

        // Constructor that takes an instance of ILogger during creation.
        public  LogManager(ILogger logger)
        {
            _logger = logger;
        }

        // Implements the WriteLog method of the ILogger interface.
        // Delegates the log writing to the _logger instance.
        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}