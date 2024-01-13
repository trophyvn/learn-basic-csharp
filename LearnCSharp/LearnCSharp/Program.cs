using SimpleLibrary;

namespace LearnCSharp
{
    // Class
    public class Program
    {
        // Main Method: Entry point of the application
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, Developer!");

            // Instantiate a class
            var greeter = new Greeter();
            // Call a method
            string greeting = greeter.GetGreetingMessage("World");
            Console.WriteLine(greeting);

            // Asynchronous programming
            string asyncGreeting = await greeter.GetGreetingMessageAsync("Asynchronous World");
            Console.WriteLine(asyncGreeting);
        }
    }
}