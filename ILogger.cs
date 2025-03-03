using System;

namespace CSharp1
{
    interface ILogger
    {
        void Log(string message);
    }
    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to file: " + message);
        }
    }
    class TimestampLogger : ILogger
    {
        private readonly ILogger _logger;
        public TimestampLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log($"[{DateTime.Now}] {message}");
        }
    }
    class ErrorCategoryLogger : ILogger
    {
        private readonly ILogger _logger;
        public ErrorCategoryLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log($"[ERROR] {message}");
        }
    }
}