using Web_DependencyInjection_Example.Interfaces;

namespace Web_DependencyInjection_Example.Implementations
{
    public class FileMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
          
            var fileName = $"C:\\AppLogs\\{DateTime.Now.ToString("dd-MMM-yyyy")}.txt";
            File.AppendAllText(fileName, $"Hello, {message}");

        }
    }
}
