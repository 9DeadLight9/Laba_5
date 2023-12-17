
public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

public class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is moving at speed: " + Speed);
    }
}

public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving at speed: " + Speed);
    }
}

public class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bus is moving at speed: " + Speed);
    }
}

public class Train : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Train is moving at speed: " + Speed);
    }
}

public class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ControlMovement()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }
}

public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }

    public string CalculateOptimalRoute(Vehicle vehicle)
    {
        
        return "Optimal Route for " + vehicle.GetType().Name;
    }
}

public class Passenger
{
    public void Board(Vehicle vehicle)
    {
        Console.WriteLine("Passenger boards the " + vehicle.GetType().Name);
    }

    public void Alight(Vehicle vehicle)
    {
        Console.WriteLine("Passenger alights from the " + vehicle.GetType().Name);
    }
}
