// Khai báo delegate
delegate void MathOperation(int x, int y);

// Khai báo delegate cho event
delegate void EventHandler(string message);

internal class Calculator
{
    // Phương thức cộng
    public static void Add(int x, int y)
    {
        Console.WriteLine($"Tổng: {x + y}");
    }

    // Phương thức nhân
    public static void Multiply(int x, int y)
    {
        Console.WriteLine($"Tích: {x * y}");
    }
}

internal class Publisher
{
    // Khai báo event với delegate tương ứng
    public event EventHandler MyEvent;

    // Phương thức kích hoạt sự kiện
    public void RaiseEvent(string message)
    {
        Console.WriteLine($"Event raised: {message}");

        // Kiểm tra xem sự kiện có được đăng ký hay không
        if (MyEvent != null)
        {
            // Gọi tất cả các phương thức đăng ký với sự kiện
            MyEvent(message);
        }
    }
}

internal class Subscriber
{
    // Phương thức xử lý sự kiện
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Event handled: {message}");
    }
}
