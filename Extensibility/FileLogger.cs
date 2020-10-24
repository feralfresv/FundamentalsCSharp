using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            this._path = path;
        }
        public void LogError(string message)
        {
            LoggerWriter("Error: ", message);
        }
        public void LogInfo(string message)
        {
            LoggerWriter("Info: ", message);
        }

        private void LoggerWriter(string type, string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(type + message);
            }
        }
    }
}
