public class TaxCalculator
{
    public decimal CalculateTax(decimal orderValue)
    {
        // Giả định thuế suất cố định là 10%
        return orderValue * 0.1m;
    }
}

public class PaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount}");
    }
}

public class OrderProcessor
{
    private TaxCalculator _taxCalculator = new TaxCalculator();
    private PaymentProcessor _paymentProcessor = new PaymentProcessor();

    public void ProcessOrder(decimal orderValue)
    {
        var tax = _taxCalculator.CalculateTax(orderValue);
        var totalAmount = orderValue + tax;
        _paymentProcessor.ProcessPayment(totalAmount);
        Console.WriteLine("Order processed");
    }
}
