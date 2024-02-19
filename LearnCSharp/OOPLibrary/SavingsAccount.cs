public class SavingsAccount : Account
{
    private decimal interestRate;

    public SavingsAccount(decimal initialBalance, decimal interestRate)
        : base(initialBalance)
    {
        this.interestRate = interestRate;
    }

    public void AddInterest() // Public: Có thể truy cập từ bất cứ đâu
    {
        ApplyInterest(interestRate); // Gọi phương thức protected từ lớp cha
        Console.WriteLine($"Interest applied using rate: {interestRate}");
    }
}
