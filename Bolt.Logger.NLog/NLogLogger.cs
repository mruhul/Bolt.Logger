using System;
using nlog = NLog;

namespace Bolt.Logger.NLog
{
    public class NLogLogger : ILogger
    {
        private readonly nlog.Logger _logger;

        public NLogLogger(string name)
        {
            _logger = nlog.LogManager.GetLogger(name);
        }

        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Trace(string message, params object[] args)
        {
            _logger.Trace(message, args);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.Debug(message, args);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            _logger.Info(message, args);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            _logger.Warn(message, args);
        }

        public void Warn(Exception exception)
        {
            _logger.Warn(exception);
        }

        public void Warn(Exception exception, string message)
        {
            _logger.Warn(exception, message);
        }

        public void Warn(Exception exception, string message, params object[] args)
        {
            _logger.Warn(exception, message, args);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            _logger.Error(message, args);
        }

        public void Error(Exception exception)
        {
            _logger.Error(exception);
        }

        public void Error(Exception exception, string message)
        {
            _logger.Error(exception, message);
        }

        public void Error(Exception exception, string message, params object[] args)
        {
            _logger.Error(exception, message, args);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(string message, params object[] args)
        {
            _logger.Fatal(message, args);
        }

        public void Fatal(Exception exception)
        {
            _logger.Fatal(exception);
        }

        public void Fatal(Exception exception, string message)
        {
            _logger.Fatal(exception, message);
        }

        public void Fatal(Exception exception, string message, params object[] args)
        {
            _logger.Fatal(message, exception, args);
        }

        public bool IsTraceEnabled { get { return _logger.IsTraceEnabled; } }
        public bool IsDebugEnabled { get { return _logger.IsDebugEnabled; } }
        public bool IsInfoEnabled { get { return _logger.IsInfoEnabled; } }
        public bool IsWarnEnabled { get { return _logger.IsWarnEnabled; } }
    }
}
