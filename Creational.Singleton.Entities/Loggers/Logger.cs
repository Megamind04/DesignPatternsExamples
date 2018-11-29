using System;

namespace Creational.Singleton.Entities.Loggers
{
    internal abstract class Logger<T> : ILogger where T : class
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);

        public static T Instance { get { return _instance.Value; } }

        protected Logger() { }

        public abstract void Log(string message);

    }
}
