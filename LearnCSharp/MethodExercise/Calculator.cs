internal class Calculator
{
    // Phương thức Add nạp chồng với 2 tham số kiểu int
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Phương thức Add nạp chồng với 3 tham số kiểu int
    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Phương thức Add nạp chồng với 2 tham số kiểu double
    public static double Add(double a, double b)
    {
        return a + b;
    }

    // Phương thức Add nạp chồng với tham số params
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum;
    }

    // Phương thức Add nạp chồng với tham số có giá trị mặc định
    public static double Add(double a, double b, double c = 0)
    {
        return a + b + c;
    }

    // Phương thức Add nạp chồng sử dụng tham số out để trả về nhiều giá trị
    public static void Add(double a, double b, out double sum, out double product)
    {
        sum = a + b;
        product = a * b;
    }
}