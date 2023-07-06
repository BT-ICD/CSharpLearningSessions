using Web_DependencyInjection_Example.Interfaces;

namespace Web_DependencyInjection_Example.Implementations
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
