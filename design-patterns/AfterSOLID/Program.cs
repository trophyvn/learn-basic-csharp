using System.Text;
Console.OutputEncoding = Encoding.UTF8;

#region SRP
// Khởi tạo Logger
Logger logger = new Logger();

// Sử dụng Logger khi khởi tạo UserManager
UserManager userManager = new UserManager(logger);

// Thêm người dùng mới, Logger sẽ được sử dụng để ghi log
userManager.AddUser("johnDoe", "john.doe@example.com");
#endregion

#region OCP
var rectangle = new Rectangle { Width = 10, Height = 20 };
var circle = new Circle { Radius = 5 };

var calculator = new AreaCalculator();

var rectangleArea = calculator.CalculateArea(rectangle);
var circleArea = calculator.CalculateArea(circle);

Console.WriteLine($"Diện tích hình chữ nhật: {rectangleArea}");
Console.WriteLine($"Diện tích hình tròn: {circleArea}");
#endregion

#region LSP
List<Bird> birds = new List<Bird> { new Duck(), new Penguin() };
foreach (var bird in birds)
{
    if (bird is IFlyable flyableBird)
    {
        flyableBird.Fly();
    }
    else
    {
        Console.WriteLine($"{bird.GetType().Name} cannot fly");
    }
}

#endregion

#region ISP
var worker = new Worker();
var manager = new Manager();

worker.Work(); // "Worker working..."
manager.Work(); // "Manager working..."
manager.Manage(); // "Manager managing..."
#endregion

#region DIP
ITaxCalculator taxCalculator = new TaxCalculator();
IPaymentProcessor paymentProcessor = new PaymentProcessor();
OrderProcessor orderProcessor = new OrderProcessor(taxCalculator, paymentProcessor);

orderProcessor.ProcessOrder(100); // Giả định giá trị đơn hàng là 100
#endregion