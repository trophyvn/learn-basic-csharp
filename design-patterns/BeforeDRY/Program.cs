using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Employee employee = new Employee { DateOfBirth = new DateTime(1990, 1, 1) };
Console.WriteLine($"Employee Age: {employee.CalculateAge()}");

EmployeeReport report = new EmployeeReport { Employee = employee };
report.PrintAge();
