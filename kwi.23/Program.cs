namespace kwi._23;

class Program
{
    public class Vehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public virtual void StartEngine()
        {
            Console.WriteLine($"Silnik od pojazdu: {Brand} {Model} został uruchomiony…");
        }
    }
    public class Car : Vehicle { }
    static void Main(string[] args)
    {
        Vehicle vehicle = new();
        vehicle.Brand = "Audi";
        Console.WriteLine(vehicle.Brand);
        vehicle.StartEngine();
        Car car = new();
        car.Brand = "Fiat";
        Console.WriteLine(car.Brand);
        car.StartEngine();
        Console.ReadKey();
    }
}
