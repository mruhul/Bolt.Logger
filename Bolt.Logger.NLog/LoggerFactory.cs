using System;

namespace Bolt.Logger.NLog
{
    public class LoggerFactory : ILoggerFactory
    {
        ILogger ILoggerFactory.Create<T>()
        {
            return Create(typeof (T));
        }

        ILogger ILoggerFactory.Create(Type type)
        {
            return Create(type.FullName);
        }

        ILogger ILoggerFactory.Create(string name)
        {
            return new NLogLogger(name);
        }

        // Keep static methods for backword comatibility
        public static ILogger Create<T>()
        {
            return Create(typeof(T));
        }

        public static ILogger Create(Type type)
        {
            return Create(type.FullName);
        }

        public static ILogger Create(string name)
        {
            return new NLogLogger(name);
        }
    }
}