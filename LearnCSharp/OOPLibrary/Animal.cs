public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Âm thanh của động vật");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Chó sủa: Gâu-gâu");
    }
}