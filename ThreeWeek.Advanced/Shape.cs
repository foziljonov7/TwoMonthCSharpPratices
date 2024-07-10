namespace ThreeWeek.Advanced;

//Abstract class
public abstract class Shape
{
    public abstract double Area{get;}
    public abstract double Perimeter();

    public void Display() => Console.WriteLine($"Area: {Area} Perimeter: {Perimeter()}");
}

public class Rectangle : Shape
{
    public double Radius {get; set;}
    public override double Area => Math.PI * Radius * Radius;
    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}