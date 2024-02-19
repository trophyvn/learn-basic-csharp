using System;
using System.Data;
using System.Data.SqlTypes;
using static ArrayHelper;

internal class ArrayHelper
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public static void DisplayArray(int[] arr) => Console.WriteLine(string.Join(" ", arr));
    public static void Access2DArrayElements()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Truy cập phần tử theo chỉ số
        int firstElement = numbers[0];
        int lastElement = numbers[numbers.Length - 1];

        // In ra màn hình console
        Console.WriteLine($"First Element: {firstElement}");
        Console.WriteLine($"Last Element: {lastElement}");
    }

    public static void Access3DArrayElements()
    {
        // Khai báo và khởi tạo mảng 3 chiều có kích thước 2x3x4
        int[,,] threeDArray =
        {
            { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } },
            { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } }
        };

        // Truy cập và hiển thị giá trị từ mảng 3 chiều
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.WriteLine($"3DArray[{i},{j},{k}] = {threeDArray[i, j, k]}");
                }
            }
        }
    }

    public static void AccessJaggedArrayElements()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };

        // Truy cập phần tử của mảng trong mảng
        int jaggedElement = jaggedArray[0][2];

        // In ra màn hình console
        Console.WriteLine($"Element at (0, 2): {jaggedElement}");
    }

    public static void ConvertArrayToString()
    {
        string[] fruits = { "Apple", "Banana", "Orange" };

        // Sử dụng string.Join để ghép mảng thành chuỗi
        string fruitsString = string.Join(", ", fruits);

        // In ra màn hình console
        Console.WriteLine($"Fruits: {fruitsString}");
    }

    public static void ConvertStringToArray()
    {
        string names = "John,Susan,Mike";

        // Sử dụng phương thức Split để tách chuỗi thành mảng
        string[] namesArray = names.Split(',');

        // In ra màn hình console
        Console.WriteLine("Names:");
        foreach (var name in namesArray)
        {
            Console.WriteLine(name);
        }
    }

    public static void ConcatArrays()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        // Sử dụng phương thức Concat để ghép hai mảng
        int[] mergedArray = array1.Concat(array2).ToArray();

        // In ra màn hình console
        Console.WriteLine("Merged Array:");
        foreach (var element in mergedArray)
        {
            Console.WriteLine(element);
        }
    }

    public static void SortArrayElements()
    {
        int[] numbers = { 5, 2, 8, 1, 7 };

        // Sắp xếp tăng dần
        Array.Sort(numbers);

        // In ra màn hình console
        Console.WriteLine("Sorted Array:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    public static void SearchElementInArray()
    {
        string[] names = { "Alice", "Bob", "Charlie", "David" };

        // Tìm phần tử trong mảng
        string targetName = "Tu";
        int index = Array.IndexOf(names, targetName);

        // Kiểm tra xem phần tử có tồn tại không
        if (index != -1)
        {
            Console.WriteLine($"{targetName} found at index {index}");
        }
        else
        {
            Console.WriteLine($"{targetName} not found in the array");
        }
    }

    public static void SumOfElementsIn2DArray()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

        int sum = 0;
        foreach (var element in matrix)
        {
            sum += element;
        }

        Console.WriteLine($"Sum of all elements in the 2D array: {sum}");
    }

    public static void Convert2DArrayTo1DArray()
    {
        int[,] matrix2D = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Chuyển đổi mảng 2D thành mảng 1D
        int[] flattenedArray = matrix2D.Cast<int>().ToArray();

        // In ra màn hình console
        Console.WriteLine("Flattened Array:");
        foreach (var num in flattenedArray)
        {
            Console.WriteLine(num);
        }
    }

    public static void ReversesJaggedArray()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };

        // Đảo ngược các phần tử của mảng lép
        Array.Reverse(jaggedArray[0]);

        // In ra màn hình console
        Console.WriteLine("Reversed Jagged Array:");
        foreach (var num in jaggedArray[0])
        {
            Console.WriteLine(num);
        }
    }

    public static void SumOfElementsInJaggedArray()
    {
        int[][] jaggedNumbers = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 8, 9 }
            };

        // Tính tổng các phần tử của mảng lép
        int sum = 0;
        foreach (var subArray in jaggedNumbers)
        {
            foreach (var num in subArray)
            {
                sum += num;
            }
        }

        Console.WriteLine($"Sum of all elements in the jagged array: {sum}");

    }

    public static void ObjectsInArray()
    {
        // Khai báo và khởi tạo mảng đối tượng
        object[] personArray = new object[]
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 22 }
        };

        // Truy cập vào thuộc tính của phần tử đối tượng bằng cách ép kiểu
        Console.WriteLine($"su dung phuong phap 'Casting;");
        foreach (var obj in personArray)
        {
            if (obj is Person)
            {
                Person person = (Person)obj;
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }

        // Truy cập vào thuộc tính của phần tử đối tượng bằng cách sử dụng phương pháp 'as'
        Console.WriteLine($"su dung phuong phap 'as;");
        foreach (var obj in personArray)
        {
            Person? person = obj as Person;
            if (person != null)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }

        // Thêm một phần tử đối tượng mới vào mảng
        Console.WriteLine($"Them mot phan tu moi vao mang");
        Person newPerson = new Person { Name = "David", Age = 28 };

        // Cần lưu ý rằng Array.Resize không trực tiếp thay đổi kích thước của mảng mà bạn truyền vào,
        // mà thay vào đó nó tạo ra một mảng mới có kích thước mới và sao chép dữ liệu từ mảng cũ sang mảng mới.
        Array.Resize(ref personArray, personArray.Length + 1);
        personArray[personArray.Length - 1] = newPerson;

        // In ra màn hình console
        Console.WriteLine("Updated Person Array:");
        foreach (var obj in personArray)
        {
            if (obj is Person)
            {
                Person person = (Person)obj;
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

    public static void ConvertArrayToList()
    {
        // Mảng số nguyên
        int[] integerArray = { 1, 2, 3, 4, 5 };

        // Chuyển mảng sang danh sách
        // cach 1: khởi tạo bằng cách sử dụng constructor
        List<int> integerList = new List<int>(integerArray);
        // cach 2: Khởi tạo bằng cách sử dụng thư viện hàm
        var list = integerArray.ToList();

        Console.WriteLine("\n\nSu dung constructor:");
        foreach (var num in integerList)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nSu dung .ToList():");
        foreach (var num in list)
        {
            Console.Write(num + " ");
        }
    }
}
