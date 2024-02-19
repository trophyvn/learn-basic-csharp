internal class Helper
{
    /// <summary>
    /// Add: Phương thức không có trạng thái
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void UpdateValue(ref int value)
    {
        value += 10;
    }

    /// <summary>
    /// Tính giai thừa của n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int GiaiThua(int n)
    {
        // Điều kiện dừng
        if (n <= 1)
            return 1;

        // Gọi đệ quy
        return n * GiaiThua(n - 1);
    }

    /// <summary>
    /// Tính số Fibonacci thứ n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int Fibonacci(int n)
    {
        // Điều kiện dừng
        if (n <= 1)
            return n;

        // Gọi đệ quy
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}