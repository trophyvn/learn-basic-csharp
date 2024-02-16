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

// Tạo và Sử Dụng Đối Tượng
ClassName myObject = new ClassName();
myObject.MyProperty = 100; // Thiết lập giá trị cho thuộc tính
myObject.MyMethod();       // Gọi phương thức

*/

// Lớp dẫn xuất
public class Car : Vehicle
{
    public static int NumberOfCars = 0;

    // Trường và thuộc tính
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    //private int speed;
    //public int Speed
    //{
    //    get { return speed; }
    //    set { speed = value; }
    //}

    public int Speed { get; set; }

    public Car()
    {
        NumberOfCars++;
    }

    public Car(string make)
    {
        // Có một tham số
        this.Make = make;
        NumberOfCars++;
    }

    public Car(string make, string model)
    {
        // Có hai tham số
        this.Make = make;
        this.Model = model;
        NumberOfCars++;
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        NumberOfCars++;
    }

    // Phương thức
    public void Start()
    {
        Console.WriteLine($"{Make} {Model} ({Year}) đang khởi động.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Make} {Model} đã dừng lại.");
    }

    public void IncreaseSpeed(int increment)
    {
        Speed += increment;
    }

    public static void DisplayNumberOfCars()
    {
        Console.WriteLine($"Tổng số xe: {NumberOfCars}");
    }

    // Ghi đè phương thức DisplayInfo từ lớp Vehicle
    public override void DisplayInfo()
    {
        // Gọi phương thức DisplayInfo của lớp cơ sở
        base.DisplayInfo();
        Console.WriteLine("This vehicle is a car.");
    }
}

// Lớp dẫn xuất khác, sử dụng từ khóa new
public class Truck : Vehicle
{
    // Ẩn phương thức DisplayInfo từ lớp Vehicle
    public new void DisplayInfo()
    {
        Console.WriteLine("This vehicle is a truck.");
    }
}

// Lớp cơ sở
public class Vehicle
{
    public virtual void DisplayInfo()
    {
        Console.WriteLine("This is a vehicle.");
    }
}

// Lớp dẫn xuất ElectricCar từ Car
//public class ElectricCar : Car
//{
//    // Sử dụng 'sealed' để ngăn chặn việc ghi đè phương thức này trong bất kỳ lớp con nào của ElectricCar
//    public sealed override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine("This car is electric.");
//    }
//}

// Khai báo ElectricCar như một lớp sealed để ngăn chặn kế thừa
public sealed class ElectricCar : Car
{
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("This car is electric.");
    }
}