public class Employee
{
    public DateTime DateOfBirth { get; set; }

    public int CalculateAge()
    {
        DateTime now = DateTime.Today;
        int age = now.Year - DateOfBirth.Year;
        if (DateOfBirth > now.AddYears(-age)) age--;
        return age;
    }
}

public class EmployeeReport
{
    public Employee Employee { get; set; }

    public void PrintAge()
    {
        DateTime now = DateTime.Today;
        int age = now.Year - Employee.DateOfBirth.Year;
        if (Employee.DateOfBirth > now.AddYears(-age)) age--;
        Console.WriteLine($"Age: {age}");
    }
}
