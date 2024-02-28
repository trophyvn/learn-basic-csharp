public class Employee
{
    public string Name { get; set; }
    public int YearsOfWork { get; set; }
    public decimal CurrentSalary { get; set; }

    public bool IsEligibleForRaise()
    {
        if (this.YearsOfWork > 0)
        {
            if (this.YearsOfWork <= 5)
            {
                if (this.CurrentSalary < 50000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (this.YearsOfWork > 5 && this.YearsOfWork <= 10)
            {
                if (this.CurrentSalary < 70000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (this.CurrentSalary < 90000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        else
        {
            return false;
        }
    }
}
