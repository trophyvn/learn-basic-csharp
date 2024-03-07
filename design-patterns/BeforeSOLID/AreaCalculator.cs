public class Circle
{
    public double Radius { get; set; }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalculator
{
    public double CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }

    public double CalculateCircleArea(Circle circle)
    {
        return Math.PI * circle.Radius * circle.Radius;
    }
}
