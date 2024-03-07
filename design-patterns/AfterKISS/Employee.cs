public class Employee
{
    public string Name { get; set; }
    public int YearsOfWork { get; set; }
    public decimal CurrentSalary { get; set; }

    public bool IsEligibleForRaise()
    {
        if (YearsOfWork <= 0) return false;

        decimal salaryCap = YearsOfWork <= 5 ? 50000 : (YearsOfWork <= 10 ? 70000 : 90000);
        return CurrentSalary < salaryCap;
    }
}
