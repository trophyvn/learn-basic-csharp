internal class TryCatchHelper
{
    public static void UseTryCatchFinally()
    {
        try
        {
            Console.Write("Nhập một số nguyên dương: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Số không được phép âm.");
            }
            Console.WriteLine($"Số bạn vừa nhập là: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Định dạng nhập vào không đúng, vui lòng nhập một số nguyên.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void UseNestedTryCatchFinally()
    {
        try
        {
            Console.WriteLine("Bắt đầu chương trình...");
            int numerator = 10;
            int[] denominators = { 2, 1, 0 };

            foreach (int denominator in denominators)
            {
                try
                {
                    Console.WriteLine("Phép chia: {0} / {1}", numerator, denominator);
                    int result = numerator / denominator;
                    Console.WriteLine("Kết quả: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Không thể chia cho 0.");
                }
                finally
                {
                    Console.WriteLine("Phép chia đã được thử với mẫu số {0}.", denominator);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Một ngoại lệ không mong đợi đã xảy ra: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Xử lý ngoại lệ hoàn tất.");
        }

        Console.WriteLine("Chương trình kết thúc.");
    }
}