using System.Text;
Console.OutputEncoding = Encoding.UTF8;

#region SRP
// Khởi tạo UserManager
UserManager userManager = new UserManager();

// Thêm người dùng mới, Logger sẽ được sử dụng để ghi log
userManager.AddUser("johnDoe", "john.doe@example.com");
#endregion

#region OCP
// Tạo một instance mới của Rectangle và thiết lập thuộc tính
var rectangle = new Rectangle { Width = 10, Height = 20 };

// Tạo một instance của Circle và thiết lập bán kính
var circle = new Circle { Radius = 5 };

// Tạo một instance mới của AreaCalculator
AreaCalculator calculator = new AreaCalculator();

// Sử dụng AreaCalculator để tính diện tích của hình chữ nhật
double area = calculator.CalculateRectangleArea(rectangle);

// In ra diện tích
Console.WriteLine($"Diện tích của hình chữ nhật là: {area}");

// Sử dụng AreaCalculator để tính diện tích của hình tròn
double areaOfCircle = calculator.CalculateCircleArea(circle);

// In ra diện tích của hình tròn
Console.WriteLine($"Diện tích của hình tròn là: {areaOfCircle}");
#endregion

#region LSP
List<Bird> birds = new List<Bird> { new Duck(), new Penguin() };

foreach (var bird in birds)
{
    try
    {
        bird.Fly(); // Cố gắng gọi Fly trên mỗi Bird
    }
    catch (NotImplementedException nie)
    {
        Console.WriteLine($"{bird.GetType().Name} cannot fly: {nie.Message}");
    }
}
#endregion

#region ISP
Worker worker = new Worker();
Manager manager = new Manager();

worker.Work(); // Điều này hoạt động tốt
worker.Manage(); // Điều này sẽ gây ra lỗi nếu được gọi vì Worker không thể quản lý

manager.Work(); // Điều này hoạt động tốt
manager.Manage(); // Điều này cũng hoạt động tốt

#endregion

#region DIP
// Tạo instance của OrderProcessor
OrderProcessor orderProcessor = new OrderProcessor();

// Gọi phương thức ProcessOrder với giá trị đơn hàng cụ thể
orderProcessor.ProcessOrder(100); // Giả sử giá trị đơn hàng là 100

// Đầu ra mong đợi:
// "Processing payment of 110"
// "Order processed"
#endregion