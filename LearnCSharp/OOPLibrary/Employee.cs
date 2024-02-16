public abstract class Employee
{
    public abstract void CalculateSalary();
}

public class FullTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary for Full-Time Employee is calculated with base rate.");
    }
}

public class PartTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary for Part-Time Employee is calculated with hourly rate.");
    }
}

public class ContractEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary for Contract Employee is fixed monthly.");
    }
}