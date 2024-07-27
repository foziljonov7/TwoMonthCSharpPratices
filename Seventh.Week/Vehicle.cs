//Factory methods pattern

public enum VehicleType
{
    TwoWheeler,
    ThreeWheeler,
    FourWheeler
}

public abstract class Vehicle
{
    public abstract void PrintVehicleInfo();
}

public class TwoWheeler : Vehicle
{
    public override void PrintVehicleInfo()
    {
        Console.WriteLine("It's a two-wheeler");
    }
}

public class ThreeWheeler : Vehicle
{
    public override void PrintVehicleInfo()
    {
        Console.WriteLine("It's a three-wheeler");
    }
}

public class FourWheeler : Vehicle
{
    public override void PrintVehicleInfo()
    {
        Console.WriteLine("It's a four-wheeler");
    }
}

public interface IVehicleFactory
{
    Vehicle Build(VehicleType type);
}

public class VehicleFactory : IVehicleFactory
{
    public Vehicle Build(VehicleType type)
    {
        switch(type)
        {
            case VehicleType.TwoWheeler: return new TwoWheeler();
            case VehicleType.ThreeWheeler: return new ThreeWheeler();
            case VehicleType.FourWheeler: return new FourWheeler(); 
            default: throw new ArgumentException("Unsupported vehicle type");
        }
    }
}

public class Client
{
    private Vehicle _vehicle;

    public Client()
    {
        _vehicle = null;
    }

    public void BuildVehicle(VehicleType type)
    {
        IVehicleFactory vehicleFactory = new VehicleFactory();
        _vehicle = vehicleFactory.Build(type);
    }

    public Vehicle RetreiveVehicle()
        => _vehicle;
}
