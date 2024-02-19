namespace ExtentionMethodExercise;
internal static class ExtensionHelper
{
    /// <summary>
    /// Phương thức mở rộng:
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static string Reverse(this string input)
    {
        /*
            Cách khai báo:
            Phải được khai báo trong một lớp static.
            Phương thức cũng phải là static.
            Phải có từ khóa this trước tham số đầu tiên, chỉ ra kiểu dữ liệu mà phương thức mở rộng sẽ áp dụng.
         */
        if (input == null)
            throw new ArgumentNullException(nameof(input));
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        return new String(array);
    }

    /// <summary>
    ///  Phương thức mở rộng Sum cho bất kỳ IEnumerable<T> nào
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <returns></returns>
    public static T Sum<T>(this IEnumerable<T> collection) where T : IConvertible
    {
        dynamic sum = default(T);
        foreach (var item in collection)
        {
            sum += (dynamic)item;
        }
        return sum;
    }
}