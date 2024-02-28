public interface IWork
{
    void Work();
}

public interface IManage
{
    void Manage();
}

public class Worker : IWork
{
    public void Work()
    {
        Console.WriteLine("Worker working...");
    }
}

public class Manager : IWork, IManage
{
    public void Work()
    {
        Console.WriteLine("Manager working...");
    }

    public void Manage()
    {
        Console.WriteLine("Manager managing...");
    }
}
