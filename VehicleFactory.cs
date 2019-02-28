public interface IVehicle
{
    int NumberOfWheels { get; }

    string PaintColour { get; }
}

public abstract class Vehicle : IVehicle
{
    protected string _paintColour = "White";

    public Vehicle() {}

    public Vehicle(string paintColour)
    {
        _paintColour = paintColour;
    }

    public abstract int NumberOfWheels { get; }

    public virtual string PaintColour { get => _paintColour; }

    public void PaintVehicle(string colour){
        _paintColour = colour;
    }
}

public class Car : Vehicle
{
    public Car() {}

    public Car(string paintColour) : base(paintColour) {}

    public override int NumberOfWheels { get => 4; }
}

public class Motorbike : Vehicle
{
    public Motorbike() {}

    public Motorbike(string paintColour) : base(paintColour) {}

    public override int NumberOfWheels { get => 2; }
}

public class Bus
{
    public int NumberOfWheels { get => 6; }
}

public class VehicleFactory{
    public static IVehicle Create<T>() where T : Vehicle, IVehicle, new() {
        if (typeof(T) == typeof(Car)){
            return new Car();
        }
        else{
            return new Motorbike();
        }
    }
}