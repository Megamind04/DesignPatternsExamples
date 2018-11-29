
namespace Creational.Singleton.Entities
{
    /// <summary>
    /// Interface for classes capable of Logging.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Method capable of Logging.
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
    }
}
