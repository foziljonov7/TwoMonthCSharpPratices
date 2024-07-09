namespace TwoWeek.ClassAndObject;

//Class & Object
public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }

    public void Drive()
    {
        Console.WriteLine("The car is driving");
    }
}
