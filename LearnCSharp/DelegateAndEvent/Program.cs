using System.Text;
Console.OutputEncoding = Encoding.UTF8;

#region Delegate
// Ví dụ 1: Cách sử dụng delegate
Console.WriteLine("Ví dụ 1: Cách sử dụng delegate\n");

// Khởi tạo delegate và trỏ đến phương thức cộng
MathOperation mathOp = new MathOperation(Calculator.Add);

// Thực hiện phép cộng thông qua delegate
mathOp(5, 10);

// Thêm phương thức nhân vào delegate
mathOp += Calculator.Multiply;

// Thực hiện cả phép cộng và phép nhân
mathOp(3, 7);
Console.WriteLine("");
#endregion

#region Event
// Ví dụ 2: Cách sử dụng event
Console.WriteLine("Ví dụ 2: Cách sử dụng event\n");

// Tạo đối tượng Publisher và Subscriber
Publisher publisher = new Publisher();
Subscriber subscriber = new Subscriber();

// Đăng ký phương thức xử lý sự kiện
publisher.MyEvent += subscriber.HandleEvent;

// Kích hoạt sự kiện từ đối tượng Publisher
publisher.RaiseEvent("Hello, this is an event!");

// Hủy đăng ký phương thức xử lý sự kiện
publisher.MyEvent -= subscriber.HandleEvent;

// Sự kiện không còn hiệu lực
publisher.RaiseEvent("Event after unsubscribe");
#endregion