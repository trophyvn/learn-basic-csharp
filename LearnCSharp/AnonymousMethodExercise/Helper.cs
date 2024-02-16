// Khai báo delegate
delegate int IncrementByDelegate(int source, int increment = 1);
public class Greeter
{
    public async Task<string> GetGreetingMessageAsync(string name)
    {
        // Simulate an asynchronous operation
        await Task.Delay(1000);
        return $"Hello {name}!";
    }
}