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
}