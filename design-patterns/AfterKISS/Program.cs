using System.Text;
Console.OutputEncoding = Encoding.UTF8;

// Ví dụ 1:
Employee employee = new Employee { Name = "John Doe", YearsOfWork = 6, CurrentSalary = 65000 };
bool eligible = employee.IsEligibleForRaise();
Console.WriteLine($"{employee.Name} is eligible for raise: {eligible}");

// Ví dụ 2:
PluginManager manager = new PluginManager();
manager.LoadPlugin("PdfExport");
manager.LoadPlugin("ImageExport");
// Cố gắng tải một plugin không được hỗ trợ
try
{
    manager.LoadPlugin("Unsupported");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message); // Xuất thông báo lỗi cho plugin không được hỗ trợ
}
manager.ExecuteAll();

