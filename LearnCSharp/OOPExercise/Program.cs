using System.Text;
Console.OutputEncoding = Encoding.UTF8;
#region Phan 1 - OOP
Console.WriteLine("Phan 1: OOP\n");
/*
public class ClassName
{
    // Trường
    private int myField;

    // Thuộc tính
    public int MyProperty { get; set; }

    // Hàm tạo
    public ClassName()
    {
        // Khởi tạo
    }

    // Phương thức
    public void MyMethod()
    {
        // Hành vi
    }
}

*/

// Tạo đối tượng Car
Car myCar = new Car("Toyota", "Camry", 2024);

// Gọi phương thức trên đối tượng
myCar.Start(); // In ra: "Toyota Camry (2024) đang khởi động."
myCar.Speed = 50; // Sử dụng setter của thuộc tính Speed
myCar.IncreaseSpeed(20); // Gọi phương thức IncreaseSpeed
Console.WriteLine(myCar.Speed); // Sử dụng getter của thuộc tính Speed để in ra giá trị, kết quả là 70
myCar.Stop();  // In ra: "Toyota Camry đã dừng lại."

// Overloading
Car car = new Car(); // Gọi hàm tạo không tham số
Car car1 = new Car("VinFast"); // Gọi hàm tạo có tham số
Car car2 = new Car("VinFast", "VF8"); // Gọi hàm tạo có 2 tham số
Car car3 = new Car("VinFast", "VF8", 2024); // Gọi hàm tạo có 3 tham số

// Static members
Car.DisplayNumberOfCars(); // Output: 5
var numberOfCar = Car.NumberOfCars;
#endregion

#region Phan 2 - Encapsulation
/* Access Modifiers:
      Public
      Private
      Protected
      Internal
      Protected Internal
      Private Protected
 */
Console.WriteLine("\nPhan 2: 4 pillars\n");
Console.WriteLine("Encapsulation\n");
SavingsAccount mySavings = new SavingsAccount(1000, 0.05m); // Khởi tạo với $1000 và lãi suất 5%

mySavings.Deposit(500); // Nạp thêm $500
mySavings.AddInterest(); // Áp dụng lãi suất

Console.WriteLine($"Current Balance: {mySavings.Balance}"); // In ra số dư hiện tại, bao gồm tiền lãi

// SetAccountNumber là internal, chỉ có thể gọi nếu bạn đang làm việc trong cùng một assembly
// mySavings.SetAccountNumber(123456789); // Lệnh này chỉ hoạt động nếu đặt trong cùng một assembly với Account
#endregion

#region Inheritance
Console.WriteLine("\nInheritance\n");
Vehicle myVehicle = new Vehicle();
myVehicle.DisplayInfo();

Car myCar2 = new Car();
myCar2.DisplayInfo();

Truck myTruck = new Truck();
myTruck.DisplayInfo();

ElectricCar myElectricCar = new ElectricCar();
myElectricCar.DisplayInfo();
#endregion

#region Polymorphism
Console.WriteLine("\nPolymorphism\n");

// Ví dụ: Đa hình thời gian biên dịch
Console.WriteLine("\nVí dụ: Đa hình thời gian biên dịch\n");
PrintData printData = new PrintData();
printData.Display(100);                   // Hiển thị số
printData.Display("Hello, World!");       // Hiển thị chuỗi
printData.Display(new int[] { 1, 2, 3, 4 }); // Hiển thị mảng số
printData.Display("This", "is", "params", "example"); // Hiển thị mảng chuỗi

// Ví dụ: Đa hình thời gian chạy
Console.WriteLine("\nVí dụ: Đa hình thời gian chạy\n");
Animal myAnimal = new Animal(); // Tạo đối tượng Animal
Animal myDog = new Dog(); // Tạo đối tượng Dog, nhưng tham chiếu như Animal

myAnimal.Speak(); // Gọi phương thức Speak từ Animal
myDog.Speak(); // Gọi phương thức Speak từ Dog, thể hiện đa hình thời gian chạy
#endregion

#region Abstraction
Console.WriteLine("\nAbstraction\n");
// Ví dụ nâng cao: Đa hình thời gian chạy
Console.WriteLine("\nVí dụ: Trừu tượng\n");
Employee[] employees = new Employee[] {
            new FullTimeEmployee(),
            new PartTimeEmployee(),
            new ContractEmployee()
        };

foreach (Employee emp in employees)
{
    emp.CalculateSalary(); // Gọi phương thức được ghi đè tương ứng với mỗi loại nhân viên
}
#endregion