using System.IO;

namespace Interfaces_and_Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(MessageType.Error, message);
        }

        public void LogInfo(string message)
        {
            Log(MessageType.Info, message);
        }

        private void Log(string messageType, string message)
        {
            using (var streamwriter = new StreamWriter(_path, true))
            {
                streamwriter.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
