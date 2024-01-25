using System.Text;
Console.OutputEncoding = Encoding.UTF8;

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