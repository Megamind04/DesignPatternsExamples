using System.IO;

namespace Creational.Singleton.Entities.Loggers
{
    internal class FileLogger : Logger<FileLogger>
    {
        private readonly TextWriter textWriter;
        private const string path = @"C:\Users\Karco\Desktop\Logs\Logs.txt";

        private FileLogger() => textWriter = TextWriter.Synchronized(File.AppendText(path));

        public override void Log(string message)
        {
            textWriter.WriteLine(message);
            textWriter.Flush();
        }
    }
}
