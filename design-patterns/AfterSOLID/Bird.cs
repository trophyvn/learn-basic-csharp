public interface IFlyable
{
    void Fly();
}

public class Bird
{
    // Các thuộc tính và phương thức chung của Bird
}

public class Duck : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying");
    }
}

public class Penguin : Bird
{
    // Penguin không thực hiện IFlyable
}
