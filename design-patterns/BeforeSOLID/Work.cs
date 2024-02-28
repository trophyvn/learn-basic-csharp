public interface IWork
{
    void Work();
    void Manage();
}

public class Worker : IWork
{
    public void Work()
    {
        Console.WriteLine("Worker working...");
    }

    public void Manage()
    {
        // Không có gì ở đây vì Worker không quản lý
        throw new NotImplementedException();
    }
}

public class Manager : IWork
{
    public void Work()
    {
        // Quản lý cũng có thể làm việc nhưng chủ yếu quản lý
        Console.WriteLine("Manager working...");
    }

    public void Manage()
    {
        Console.WriteLine("Manager managing...");
    }
}
