using System.Text;
using ExtentionMethodExercise;
Console.OutputEncoding = Encoding.UTF8;

#region Phan 1, 2, 3
// Cú pháp
//public int Add(int a, int b)
//{
//    return a + b;
//}

//public void DisplayMessage(string message)
//{
//    Console.WriteLine(message);
//}

//public void UpdateValue(ref int value)
//{
//    value += 10;
//}

// Ví dụ 1: Trả về giá trị
Console.WriteLine("Ví dụ 1: Trả về giá trị");
int result = Helper.Add(2, 5);
Console.WriteLine("Kết quả của phương thức Add(2, 5): " + result);

// Ví dụ 2: Trả về kiểu void
Console.WriteLine("Ví dụ 2: Trả về kiểu void");
Helper.DisplayMessage("Xin chào");

// Ví dụ 3: Tham số tham chiếu
Console.WriteLine("Ví dụ 3: Tham số tham chiếu");
int number = 5;
// In giá trị ban đầu của number
Console.WriteLine("Giá trị ban đầu của number: " + number);
// Gọi phương thức UpdateValue
Helper.UpdateValue(ref number);
// In giá trị của number sau khi gọi phương thức
Console.WriteLine("Giá trị của number sau khi gọi UpdateValue: " + number);

/*
 Phương thức có trạng thái (Stateful methods):
    Lưu giữ trạng thái
    Phụ thuộc vào trạng thái
    Quản lý trạng thái
    Ví dụ: Increment() của đối tượng Counter

Phương thức không có trạng thái (Stateless Methods):
    Không lưu giữ trạng thái
    Độc lập với trạng thái
    Dễ quản lý và mở rộng
    Ví dụ: Add(int a, int b) của đối tượng Calculator.
 */

// Ví dụ 4: Phương thức có trạng thái Stateful
Console.WriteLine("Ví dụ 4: Phương thức có trạng thái Stateful");
// Sử dụng lớp ShoppingCart
ShoppingCart cart = new ShoppingCart();
cart.AddItem("Apple");
cart.AddItem("Banana");
Console.WriteLine(cart.GetItemCount()); // Output sẽ là 2
cart.RemoveItem("Apple");
Console.WriteLine(cart.GetItemCount()); // Output sẽ là 1

// Ví dụ 5: Phương thức không có trạng thái Stateless
Console.WriteLine("Ví dụ 5: Phương thức không có trạng thái Stateless");
int sum = Helper.Add(5, 3);
Console.WriteLine(sum);
Console.WriteLine(sum); // Output luôn luôn là 8 mỗi khi gọi với cùng đầu vào 5 và 3

// Ví dụ 6: Nạp chồng phương thức
Console.WriteLine("Ví dụ 6: Nạp chồng phương thức");
Console.WriteLine(Calculator.Add(1, 2)); // Gọi phương thức với 2 tham số int
Console.WriteLine(Calculator.Add(1, 2, 33)); // Gọi phương thức với 3 tham số int
Console.WriteLine(Calculator.Add(1, 2, 3)); // Gọi phương thức với 3 tham số int
Console.WriteLine(Calculator.Add(1.0, 2.0)); // Gọi phương thức với 2 tham số double
Console.WriteLine(Calculator.Add(1.0, 2.0, 3.0)); // Gọi phương thức với 3 tham số double, c không có giá trị mặc định
Console.WriteLine(Calculator.Add(1.0, 2.0, c: 4.0)); // Gọi phương thức với 3 tham số double, chỉ định c
// Gọi phương thức với tham số out
Calculator.Add(3.0, 4.0, out double sum2, out double product);
Console.WriteLine($"Sum: {sum2}, Product: {product}"); // In ra tổng và tích của 3.0 và 4.0
#endregion

#region Phan 4
// Ví dụ 7: Tính giai thừa sử dụng Phương thức đệ quy
Console.WriteLine("Ví dụ 7: Tính giai thừa sử dụng Phương thức đệ quy");
Console.WriteLine(Helper.GiaiThua(4)); // 24
Console.WriteLine(Helper.GiaiThua(7)); // 5040

// Ví dụ 8: Tính Fibonacci sử dụng Phương thức đệ quy
Console.WriteLine("Ví dụ 8: Tính Fibonacci sử dụng Phương thức đệ quy");
Console.WriteLine(Helper.Fibonacci(5)); // 5
Console.WriteLine(Helper.Fibonacci(9)); // 34

// Ví dụ 9: 
Console.WriteLine("Ví dụ 9: Xây dựng cây menu");
List<MenuItem> menuItems = new List<MenuItem>
{
    new MenuItem(1, "Trang chủ", null), // Mục gốc
    new MenuItem(2, "Giới thiệu", null), // Mục gốc khác
    new MenuItem(3, "Sản phẩm", null), // Một mục gốc nữa
    new MenuItem(4, "Điện thoại", 3), // Con của "Sản phẩm"
    new MenuItem(5, "Máy tính bảng", 3), // Con của "Sản phẩm"
    new MenuItem(6, "Liên hệ", null), // Mục gốc khác
    new MenuItem(7, "Bảo hành", 6), // Con của "Liên hệ"
    new MenuItem(8, "Hỗ trợ kỹ thuật", 6), // Con của "Liên hệ"
};

// Xây dựng cây menu
List<MenuItem> menuTree = MenuTree.BuildMenuTree(menuItems);

// Hiển thị cây menu
MenuTree.DisplayMenuTree(menuTree, 0);
#endregion

#region Phan 5
// Ví dụ 10: Sử dụng phương thức mở rộng như là một phần của lớp String
Console.WriteLine("Ví dụ 10: Sử dụng phương thức mở rộng như là một phần của lớp String");
string example = "Hello";
string reversed = example.Reverse();
Console.WriteLine(reversed);

// Ví dụ 11: Sử dụng phương thức mở rộng với một danh sách các số nguyên và số thực
Console.WriteLine("Ví dụ 11: Sử dụng phương thức mở rộng với một danh sách các số nguyên và số thực");
// Sử dụng phương thức mở rộng với một danh sách các số nguyên
var numbers = new List<int> { 1, 2, 3, 4, 5 };
int sumOfIntegers = numbers.Sum();
Console.WriteLine($"Sum of integers: {sumOfIntegers}"); // Output: Sum of integers: 15

// Sử dụng phương thức mở rộng với một danh sách các số thực
var doubles = new List<double> { 1.5, 2.5, 3.5 };
double sumOfDoubles = doubles.Sum();
Console.WriteLine($"Sum of doubles: {sumOfDoubles}"); // Output: Sum of doubles: 7.5
#endregion

