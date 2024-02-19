public class PrintData
{
    // Nạp chồng phương thức với tham số kiểu int
    public void Display(int number)
    {
        Console.WriteLine($"Displaying Number: {number}");
    }

    // Nạp chồng phương thức với tham số kiểu string
    public void Display(string message)
    {
        Console.WriteLine($"Displaying Message: {message}");
    }

    // Nạp chồng phương thức với tham số mảng int
    public void Display(int[] numbers)
    {
        Console.Write("Displaying Number Array: ");
        foreach (int i in numbers)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // Nạp chồng phương thức với tham số params
    public void Display(params string[] messages)
    {
        Console.Write("Displaying Messages Array: ");
        foreach (string msg in messages)
        {
            Console.Write(msg + " ");
        }
        Console.WriteLine();
    }
}