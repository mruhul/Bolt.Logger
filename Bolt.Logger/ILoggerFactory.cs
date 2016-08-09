using System;

namespace Bolt.Logger
{
    public interface ILoggerFactory
    {
        ILogger Create<T>();
        ILogger Create(Type type);
        ILogger Create(string name);
    }
}