using Creational.Singleton.Entities.Loggers;

namespace Creational.Singleton.Entities
{
    /// <summary>
    /// Type of Logger.
    /// </summary>
    public enum LoggerType
    {
        /// <value>File.</value>
        File,
        /// <value>Sql DataBase.</value>
        SqlDb
    }
    /// <summary>
    /// Class for geting logger instance
    /// </summary>
    public static class LoggerFactory
    {
        /// <summary>
        /// Method for geting logger instance
        /// </summary>
        /// <param name="type">type of logger</param>
        /// <returns>ILogger</returns>
        public static ILogger CreateLogger(LoggerType type)
        {
            ILogger logger = null;
            switch (type)
            {
                case LoggerType.File:
                    logger = FileLogger.Instance;
                    break;
                case LoggerType.SqlDb:
                    logger = DatabaseLogger.Instance;
                    break;
                default:
                    logger = null;
                    break;
            }
            return logger;
        }
    }
}
