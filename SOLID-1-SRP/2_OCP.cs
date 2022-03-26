// Open-Closed Principle
// 2nd SOLID Principle
// Class is open for extension, closed for modification

// By creating IShape interface abstraction, without needing to modify AreaCalculator function we can add new shapes.

public interface IShape
{
    public double Area();
}

public class Rectangle : IShape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public double Area()
    {
        return Height * Width;
    }
}
public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius,2);
    }
}

public class AreaCalculator
{
    public double TotalArea(IShape[] arrShapes)
    {
        double area = 0;
        foreach (var objShape in arrShapes)
        {
            area += objShape.Area();
        }
        return area;
    }
}