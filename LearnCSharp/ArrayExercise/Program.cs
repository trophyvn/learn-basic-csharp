#region Gioi thieu cac loai mang

// vi du 1: Mảng một chiều - single-dimensional arrays
int[] numbers = new int[5];
string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

// vi du 2: Mảng đa chiều - multidimensional arrays
int[,] array2D = new int[4, 2];
int[,,] array3D = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

// vi du 3: Mảng răng cưa - jagged arrays
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
jaggedArray[1] = new int[] { 0, 2, 4, 6 };

// vi du 4: Mảng Không Rõ Kiểu - implicitly typed arrays
var numbersArray = new[] { 1, 2, 3, 4 };
var stringArray = new[] { "hello", null, "world" };

// vi du 5: Mảng đối tượng - Object Array
object[] personArray = new object[]
{
    new ArrayHelper.Person { Name = "Alice", Age = 25 },
    new ArrayHelper.Person { Name = "Bob", Age = 30 },
    new ArrayHelper.Person { Name = "Charlie", Age = 22 }
};

// vi du 6: Truyền mảng vào phương thức
Console.WriteLine("Vi du 6:");
ArrayHelper.DisplayArray(new int[] { 1, 2, 3, 4 });

// vi du 7: Khai thác và truy cập phần tử của mảng 2D
Console.WriteLine("Vi du 7:");
ArrayHelper.Access2DArrayElements();

// vi du 8: Khai thác và truy cập phần tử của mảng 3D
Console.WriteLine("Vi du 8:");
ArrayHelper.Access3DArrayElements();

// vi du 9: Truy cập phần tử của mảng trong mảng
Console.WriteLine("Vi du 9:");
ArrayHelper.AccessJaggedArrayElements();

// vi du 10: Chuyển đổI mảng sang chuỗI và ngược lại
Console.WriteLine("Vi du 10:");
ArrayHelper.ConvertArrayToString();
ArrayHelper.ConvertStringToArray();

// vi du 11: Ghép mảng
Console.WriteLine("Vi du 11:");
ArrayHelper.ConcatArrays();

// vi du 12: Sắp xếp phần tử trong mảng
Console.WriteLine("Vi du 12:");
ArrayHelper.SortArrayElements();

// vi du 13: Tìm kiếm phần tử trong mảng
Console.WriteLine("Vi du 13:");
ArrayHelper.SearchElementInArray();

// vi du 14: Tính tổng các phần tử trong mảng 2D
Console.WriteLine("Vi du 14:");
ArrayHelper.SumOfElementsIn2DArray();

// vi du 15: Chuyển đổi mảng 2D sang mảng 1D
Console.WriteLine("Vi du 15:");
ArrayHelper.Convert2DArrayTo1DArray();

// vi du 16: Đảo ngược mảng trong mảng
Console.WriteLine("Vi du 16:");
ArrayHelper.ReversesJaggedArray();

// vi du 17: Tính tổng các phần tử trong mảng trong mảng (jagged)
Console.WriteLine("Vi du 17:");
ArrayHelper.SumOfElementsInJaggedArray();

// vi du 18: Làm việc với mảng của các đối tượng
Console.WriteLine("Vi du 18:");
ArrayHelper.ObjectsInArray();

// vi du 19: Chuyển đổi từ mảng sang danh sách
Console.WriteLine("Vi du 19:");
ArrayHelper.ConvertArrayToList();

#endregion