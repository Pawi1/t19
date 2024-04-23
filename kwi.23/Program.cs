namespace kwi._23;

class Program
{
    public class Vehicle
    {
        public string Brand { get; set; } = "???";
        public string Model { get; set; } = "???";
        public double Fuel { get; private set; }
        public virtual void StartEngine()
        {
            Console.WriteLine($"Silnik pojazdu: {Brand} {Model} został uruchomiony…");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine($"Silnik pojazdu: {Brand} {Model} został zatrzymany…");
        }
    }
    public class Car : Vehicle
    {
        public sbyte NumberOfDoors { get; set; }
        public override void StartEngine()
        {
            //base.StartEngine();
            Console.WriteLine($"Silnik samochodu: {Brand} {Model} został uruchomiony…");
        }
        public override void StopEngine()
        {
            //base.StopEngine();
            Console.WriteLine($"Silnik samochodu: {Brand} {Model} został zatrzymany…");
        }
    }
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
    }
}
