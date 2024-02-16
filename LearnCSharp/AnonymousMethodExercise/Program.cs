using System.Text;
Console.OutputEncoding = Encoding.UTF8;

/*
    Biểu thức lambda là một cách tạo hàm ẩn danh trong ngôn ngữ lập trình C#. Có hai loại biểu thức lambda: biểu thức hàm và biểu thức lệnh.
    Biểu thức lambda giúp tạo mã ngắn gọn và linh hoạt, đặc biệt là khi sử dụng trong LINQ, Task.Run(),
    và các tình huống khác đòi hỏi sự linh động của hàm ẩn danh.
*/

/*
1. Biểu thức lambda hàm
    Biểu thức lambda hàm có dạng (tham-số) => biểu-thức.
    Chức năng: Được sử dụng khi bạn muốn tạo một hàm có giá trị trả về.
    Số tham số: Có thể có hoặc không tham số, và cũng có thể có một hoặc nhiều tham số.
*/
Console.WriteLine("1. Biểu thức lambda hàm\n");
Func<int, int> square = x => x * x; //Func<> được sử dụng cho các phương thức có giá trị trả về
Console.WriteLine(square(5));  // Output: 25

/*
2. Biểu thức lambda lệnh
    Chức năng: Được sử dụng khi bạn muốn tạo một phương thức không trả về (void).
    Số tham số: Cũng có thể có hoặc không tham số, và cũng có thể có một hoặc nhiều tham số.
*/
Console.WriteLine("Biểu thức lambda lệnh\n");
// Action<> được sử dụng cho các phương thức không trả về (void)
Action<string> greet = name =>
{
    string greeting = $"Hello {name}!";
    Console.WriteLine(greeting);
};
greet("World"); // Output: Hello World!

/*
3. Tham số đầu vào của biểu thức lambda
    Tham số được đặt trong dấu ngoặc, có thể không có hoặc nhiều hơn một.
    Loại tham số có thể được suy luận hoặc chỉ định rõ ràng.
    Sử dụng _ để bỏ qua tham số không sử dụng trong biểu thức.
*/
Console.WriteLine("Tham số đầu vào của biểu thức lambda\n");
Func<int, int, int> constant = (_, _) => 42;
Console.WriteLine(constant(0, 0));  // Output: 42

/*
4. Tham số đầu vào với giá trị mặc định và sử dụng mảng params
    Tính năng mới từ C# 12 cho phép thêm giá trị mặc định và sử dụng mảng params trong biểu thức lambda.
    Cho phép sự linh hoạt và tiện ích trong việc đặt giá trị mặc định và xử lý các tham số mảng.
*/
Console.WriteLine("Tham số đầu vào với giá trị mặc định và sử dụng mảng params\n");
var IncrementBy = (int source, int increment = 1) => source + increment;
Console.WriteLine(IncrementBy(5));    // Output: 6
Console.WriteLine(IncrementBy(5, 2)); // Output: 7

Console.WriteLine("sử dụng mảng params trong biểu thức lambda\n");
var sum = (params int[] values) =>
{
    int result = 0;
    foreach (var value in values)
        result += value;
    return result;
};

Console.WriteLine(sum());               // Output: 0
Console.WriteLine(sum(1, 2, 3, 4, 5));  // Output: 15

/*
5. Delegate và types
    Biểu thức lambda có thể chuyển đổi thành các loại delegate tương ứng dựa trên tham số và giá trị trả về.
    Có thể định nghĩa các loại delegate với tham số mặc định và mảng params.
*/
Console.WriteLine("Delegate và types\n");
IncrementByDelegate increment = (x, y) => x + y;
Console.WriteLine(increment(3, 4));  // Output: 7

/*
6. Biểu thức Lambda cho xử lý bất đồng bộ (async và await)
    Sử dụng từ khóa async và await để tạo biểu thức lambda xử lý các tác vụ bất đồng bộ.
*/
Console.WriteLine("Biểu thức Lambda cho xử lý bất đồng bộ (async và await)\n");
var greeter = new Greeter();
string asyncGreeting = await greeter.GetGreetingMessageAsync("Asynchronous World");
Console.WriteLine(asyncGreeting); // Output: Hello Asynchronous World

/*
7. Biểu thức Lambda với Tuple
    C# hỗ trợ tích hợp cho tuple, có thể sử dụng tuple làm đối số và giá trị trả về của biểu thức lambda.
*/
Console.WriteLine("Biểu thức Lambda với Tuple\n");
Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
var numbers = (2, 3, 4);
var doubledNumbers = doubleThem(numbers);
Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}"); // Output: The set (2, 3, 4) doubled: (4, 6, 8)

/*
8. Sử dụng Lambda với các toán tử truy vấn tiêu chuẩn
    LINQ to Objects sử dụng các đối số đầu vào là một trong các delegate generic của nó, ví dụ như Func<TResult>.
*/
Console.WriteLine("Sử dụng Lambda với các toán tử truy vấn tiêu chuẩn: Count\n");
// Ví dụ sử dụng Lambda với toán tử Count:
int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int oddNumbers = nums.Count(n => n % 2 == 1);
Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers)}");

Console.WriteLine("Sử dụng Lambda với các toán tử truy vấn tiêu chuẩn: TakeWhile\n");
// Ví dụ khác sử dụng Lambda với TakeWhile:
int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var firstNumbersLessThanSix = numbers2.TakeWhile(n => n < 6);
Console.WriteLine(string.Join(" ", firstNumbersLessThanSix)); // Output: 5 4 1 3

Console.WriteLine("Sử dụng Lambda với các toán tử truy vấn tiêu chuẩn: TakeWhile có nhiều tham số\n");
// Ví dụ sử dụng Lambda với TakeWhile và nhiều tham số:
int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var firstSmallNumbers = numbers3.TakeWhile((n, index) => n >= index);
Console.WriteLine(string.Join(" ", firstSmallNumbers)); // Output: 5 4

/*
9. Suy Luận Kiểu và Thuộc Tính
    Trình biên dịch có thể suy luận kiểu tham số đầu vào và kiểu trả về của Lambda dựa trên nội dung của nó.
    Bạn có thể chỉ định kiểu trả về hoặc thêm thuộc tính cho các tham số trong biểu thức Lambda.
*/
Console.WriteLine("Suy Luận Kiểu và Thuộc Tính\n");
var parseStr = (string s) => s;
var parse = (string s) => int.Parse(s);
var choose = object (bool b) => b ? 1 : "two"; // Func<bool, object>

/*
10. Lambda Tĩnh (Static Lambda)
    Bạn có thể đặt từ khóa static trước Lambda để ngăn chặn sự "capture" không chủ định của biến cục bộ hoặc trạng thái của đối tượng.
*/
Console.WriteLine("Lambda Tĩnh (Static Lambda)\n");
Func<double, double> squareStatic = static x => x * x;
Console.WriteLine(squareStatic(5.0));