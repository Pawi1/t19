namespace Zadanie1;

abstract class Vehicle(string brand, string model, int productionYear)
{
    private string Brand { get; } = brand;
    private string Model { get; } = model;
    private int ProductionYear { get; } = productionYear;

    public virtual void Info()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
    }
}

class PassengerCar(string brand, string model, int productionYear) : Vehicle(brand, model, productionYear)
{
    private int NumberOfSeats { get; }

    public PassengerCar(string brand, string model, int productionYear, int numberOfSeats) : this(brand, model,
        productionYear)
    {
        NumberOfSeats = numberOfSeats;
    }

    public override void Info()
    {
        base.Info();
        Console.WriteLine($"Number of seats: {NumberOfSeats}");
    }
}

class Truck(string brand, string model, int productionYear) : Vehicle(brand, model, productionYear)
{
    private int Capacity { get; }
    public Truck(string brand, string model, int productionYear, int capacity):this(brand, model, productionYear)
    {
        Capacity = capacity;
    }
    public override void Info()
    {
        base.Info();
        Console.WriteLine($"Capacity: {Capacity}");
    }
}
class Zadanie1
{
    static void Main(string[] args)
    {
        var flotaPojazdóœ = new List<Vehicle>();
        flotaPojazdóœ.Add(new PassengerCar("VW","Transporter",2022,6));
        flotaPojazdóœ.Add(new Truck("Scania","S-series",2026,50));
        flotaPojazdóœ.Add(new Truck("Volvo","FL",2026,40));
        flotaPojazdóœ.Add(new PassengerCar("Iveco","Daily",2019,3));
        foreach (var vehicle in flotaPojazdóœ)
        {
            vehicle.Info();
            Console.WriteLine();
        }
    }
}