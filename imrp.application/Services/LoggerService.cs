
using Serilog;

namespace imrp.application.Services
{
    public interface ILoggerService
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message, Exception? ex);
        void LogDebug(string message);
    }

    public class LoggerService: ILoggerService
    {
        private readonly ILogger _logger;

        public LoggerService()
        {
            _logger = Log.Logger;
        }

        public void LogInformation(string message)
        {
            _logger.Information(message);
        }

        public void LogWarning(string message)
        {
            _logger.Warning(message);
        }

        public void LogError(string message, Exception? ex)
        {
            if (ex != null)
            {
                _logger.Error(ex, message);
            }
            else
            {
                _logger.Error(message);
            }
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }
    }
}
