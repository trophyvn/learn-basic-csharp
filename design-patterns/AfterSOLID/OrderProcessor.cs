public interface ITaxCalculator
{
    decimal CalculateTax(decimal orderValue);
}

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class TaxCalculator : ITaxCalculator
{
    public decimal CalculateTax(decimal orderValue)
    {
        return orderValue * 0.1m; // Giả định thuế suất cố định
    }
}

public class PaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount}");
    }
}

public class OrderProcessor
{
    private ITaxCalculator _taxCalculator;
    private IPaymentProcessor _paymentProcessor;

    public OrderProcessor(ITaxCalculator taxCalculator, IPaymentProcessor paymentProcessor)
    {
        _taxCalculator = taxCalculator;
        _paymentProcessor = paymentProcessor;
    }

    public void ProcessOrder(decimal orderValue)
    {
        var tax = _taxCalculator.CalculateTax(orderValue);
        var totalAmount = orderValue + tax;
        _paymentProcessor.ProcessPayment(totalAmount);
        Console.WriteLine("Order processed");
    }
}
