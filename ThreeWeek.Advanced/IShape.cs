namespace ThreeWeek.Advanced;

//Interfaces
public interface IShape
{
    double Area {get;}
    double Perimeter();
}

public class Circle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;
    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}
