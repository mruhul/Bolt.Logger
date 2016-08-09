using System;

namespace Bolt.Logger
{
    public class NullLoggerFactory : ILoggerFactory
    {
        private static readonly ILogger Instance = new NullLogger();

        public ILogger Create<T>()
        {
            return Instance;
        }

        public ILogger Create(Type type)
        {
            return Instance;
        }

        public ILogger Create(string name)
        {
            return Instance;
        }
    }
}