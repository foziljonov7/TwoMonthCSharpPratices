namespace OneWeek.ClassAndObject;

//Abstraction
public abstract class Shape
{
    public abstract double GetArea();

    public void Display()
        => Console.WriteLine("This is a shape");
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}