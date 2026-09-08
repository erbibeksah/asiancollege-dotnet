namespace TestDotnet.Services
{
    public interface ICustomLogger
    {
        void Log(string message);
    }
    public class CustomLogger: ICustomLogger
    {
        public void Log(string message)
        {
            // Implement your custom logging logic here
            Console.WriteLine($"Custom Log: {message}");
        }
    }
}
