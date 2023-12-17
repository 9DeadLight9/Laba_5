class Program
{
    static void Main(string[] args)
    {
      
        Car car = new Car { Speed = 100, Capacity = 5 };
        Bus bus = new Bus { Speed = 60, Capacity = 30 };
        Train train = new Train { Speed = 80, Capacity = 200 };

       
        TransportNetwork transportNetwork = new TransportNetwork();
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

      
        transportNetwork.ControlMovement();

    
        Route route = new Route { StartPoint = "Київ", EndPoint = "Львів" };
        Console.WriteLine(route.CalculateOptimalRoute(car));
        Console.WriteLine(route.CalculateOptimalRoute(bus));
        Console.WriteLine(route.CalculateOptimalRoute(train));

       
        Passenger passenger = new Passenger();
        passenger.Board(car);
        passenger.Alight(car);
    }
}
