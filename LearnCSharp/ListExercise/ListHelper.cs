namespace ListExercise;

internal class ListHelper
{
    public static IEnumerable<int> GetNumbers()
    {
        return new List<int> { 1, 2, 3, 4, 5 };
    }

    public static void PrintNumbers(IEnumerable<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public static void AddNumbers(ICollection<int> numbers)
    {
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
    }

    public static void SortNumbers(IList<int> numbers)
    {
        numbers.Remove(3); // Xóa phần tử có giá trị là 3
        numbers.Insert(0, 3); // Thêm 3 vào đầu danh sách
        ((List<int>)numbers).Sort(); // Sắp xếp danh sách
    }
}
