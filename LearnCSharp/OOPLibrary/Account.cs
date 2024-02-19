public class Account
{
    private decimal balance; // Private: Chỉ có thể truy cập trong Account

    public Account(decimal initialBalance)
    {
        balance = initialBalance > 0 ? initialBalance : 0;
    }

    public decimal Balance // Public: Có thể truy cập từ bất cứ đâu
    {
        get { return balance; }
    }

    public void Deposit(decimal amount) // Public: Có thể truy cập từ bất cứ đâu
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }
    }

    public bool Withdraw(decimal amount) // Public: Có thể truy cập từ bất cứ đâu
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, New Balance: {balance}");
            return true;
        }
        Console.WriteLine("Withdrawal failed: Insufficient funds or invalid amount");
        return false;
    }

    protected void ApplyInterest(decimal interestRate) // Protected: Chỉ có thể truy cập trong Account và các lớp kế thừa
    {
        balance += balance * interestRate;
    }

    internal void SetAccountNumber(long number) // Internal: Chỉ có thể truy cập trong cùng assembly
    {
        Console.WriteLine($"Account number set to: {number}");
    }
}
