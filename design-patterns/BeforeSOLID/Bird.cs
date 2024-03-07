public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Bird is flying");
    }
}

public class Duck : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Duck is flying");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Penguins cannot fly");
    }
}
