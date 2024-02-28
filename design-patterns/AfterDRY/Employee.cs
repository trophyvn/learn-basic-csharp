public static class DateUtilities
{
    public static int CalculateAge(DateTime dateOfBirth)
    {
        DateTime now = DateTime.Today;
        int age = now.Year - dateOfBirth.Year;
        if (dateOfBirth > now.AddYears(-age)) age--;
        return age;
    }
}

public class Employee
{
    public DateTime DateOfBirth { get; set; }

    public int Age => DateUtilities.CalculateAge(DateOfBirth);
}

public class EmployeeReport
{
    public Employee Employee { get; set; }

    public void PrintAge()
    {
        Console.WriteLine($"Age: {Employee.Age}");
    }
}
