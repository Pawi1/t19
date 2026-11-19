namespace Zadanie2;
abstract class Vehicle(string brand, string model, int productionYear)
{
    protected string Brand { get; } = brand;
    protected string Model { get; } = model;
    protected int ProductionYear { get; } = productionYear;
    
    public abstract string GetDescription();
}

class PassengerCar(string brand, string model, int productionYear) : Vehicle(brand, model, productionYear)
{
    private int NumberOfSeats { get; }

    public PassengerCar(string brand, string model, int productionYear, int numberOfSeats)
        : this(brand, model, productionYear)
    {
        NumberOfSeats = numberOfSeats;
    }

    public override string GetDescription()
    {
        return $"Passenger car {Brand} {Model} ({ProductionYear}), number of seats: {NumberOfSeats}.";
    }
}

class Truck(string brand, string model, int productionYear) : Vehicle(brand, model, productionYear)
{
    private int Capacity { get; }

    public Truck(string brand, string model, int productionYear, int capacity)
        : this(brand, model, productionYear)
    {
        Capacity = capacity;
    }

    public override string GetDescription()
    {
        return $"Truck {Brand} {Model} ({ProductionYear}), capacity: {Capacity} kg.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var fleet = new List<Vehicle>
        {
            new PassengerCar("VW", "Transporter", 2022, 6),
            new Truck("Scania", "S-series", 2026, 50),
            new Truck("Volvo", "FL", 2026, 40),
            new PassengerCar("Iveco", "Daily", 2019, 3)
        };

        foreach (var vehicle in fleet)
        {
            Console.WriteLine(vehicle.GetDescription());
        }
    }
}