namespace SimpleLibrary
{
    public class Greeter
    {
        // Property
        public string DefaultGreeting { get; set; } = "Hello";

        // Method
        //CPU Bound
        public string GetGreetingMessage(string name)
        {
            return $"{DefaultGreeting}, {name}!";
        }

        // Asynchronous method
        // I/O Bound
        public async Task<string> GetGreetingMessageAsync(string name)
        {
            // Simulate an asynchronous operation
            await Task.Delay(1000);
            return $"{DefaultGreeting}, {name}!";
        }
    }
}
