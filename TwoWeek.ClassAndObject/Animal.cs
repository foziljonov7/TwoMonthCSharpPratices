namespace TwoWeek.ClassAndObject;

//Dynamic polymorhism
public class Animal
{
    public virtual void Ovoz()
    {
        Console.WriteLine("Hayvonlarning ovozlari...");
    }
}

public class Cat : Animal
{
    public override void Ovoz()
    {
        Console.WriteLine("Mushukning ovozi .... miyav");
    }
}

public class Dog : Animal
{
    public override void Ovoz()
    {
        Console.WriteLine("Itning ovozi... Vauv");
    }
}

