using System;

namespace Bolt.Logger
{
    public class NullLogger : ILogger
    {
        public bool IsTraceEnabled { get { return false; } }
        public bool IsDebugEnabled { get { return false; } }
        public bool IsInfoEnabled { get { return false; } }
        public bool IsWarnEnabled { get { return false; } }
        
        public void Trace(string message)
        {   
        }

        public void Trace(string message, params object[] args)
        {
        }

        public void Debug(string message)
        {
        }

        public void Debug(string message, params object[] args)
        {
        }

        public void Info(string message)
        {
        }

        public void Info(string message, params object[] args)
        {
        }

        public void Warn(string message)
        {
        }

        public void Warn(string message, params object[] args)
        {
        }

        public void Warn(Exception exception)
        {
        }

        public void Warn(Exception exception, string message)
        {
        }

        public void Warn(Exception exception, string message, params object[] args)
        {
        }

        public void Error(string message)
        {
        }

        public void Error(string message, params object[] args)
        {
        }

        public void Error(Exception exception)
        {
        }

        public void Error(Exception exception, string message)
        {
        }

        public void Error(Exception exception, string message, params object[] args)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Fatal(string message, params object[] args)
        {
        }

        public void Fatal(Exception exception)
        {
        }

        public void Fatal(Exception exception, string message)
        {
        }

        public void Fatal(Exception exception, string message, params object[] args)
        {
        }
    }
}