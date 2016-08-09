using System;

namespace Bolt.Logger
{
    public interface ILogger
    {
        bool IsTraceEnabled { get; }
        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsWarnEnabled { get; }

        void Trace(string message);
        void Trace(string message, params object[] args);

        void Debug(string message);
        void Debug(string message, params object[] args);
        
        void Info(string message);
        void Info(string message, params object[] args);
        
        void Warn(string message);
        void Warn(string message, params object[] args);
        void Warn(Exception exception);
        void Warn(Exception exception, string message);
        void Warn(Exception exception, string message, params object[] args);
        
        void Error(string message);
        void Error(string message, params object[] args);
        void Error(Exception exception);
        void Error(Exception exception, string message);
        void Error(Exception exception, string message, params object[] args);
        
        void Fatal(string message);
        void Fatal(string message, params object[] args);
        void Fatal(Exception exception);
        void Fatal(Exception exception, string message);
        void Fatal(Exception exception, string message, params object[] args);
    }
}
