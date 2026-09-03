namespace kwi._23;

class Program
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric
    }
    public class Vehicle
    {
        public string Brand { get; set; } = "???";
        public string Model { get; set; } = "???";
        public double Fuel { get; private set; }
        public FuelType FuelType { get; set; }
        public ushort Speed { get; set; }
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
        public byte NumberOfDoors { get; set; }
        public byte CurrentGear { get; set; }
        public byte MaxGear { get; set; }
        public bool IsAutomatic { get; set; }
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
        public void ChangeGear(sbyte gear)
        {
            if (!IsAutomatic)
            {
                if (gear < 0 || gear > MaxGear)
                {
                    Console.WriteLine("Nieprawidlowy bieg");
                }
                else
                {
                    CurrentGear++;
                    Console.WriteLine("Aktualny bieg: "+CurrentGear);
                }
            }
            else
            {
                Console.WriteLine("Samochód ma automatyczną skrzynie biegów…");
            }
        }
        public void AutomaticChangeGear()
        {
            if(Speed < 30)
            {
                CurrentGear = 1;
            }
            else if(Speed < 70)
            {
                CurrentGear = 2;
            }
            else
            {
                CurrentGear = 3;
            }
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
