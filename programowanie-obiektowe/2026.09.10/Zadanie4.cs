interface IPoloczenie
{
    public void Polacz();
    public void Rozlacz();
}

class Router : IPoloczenie
{
    public void Polacz()
    {
        Console.WriteLine("Połączono z 100.64.0.1/10 jako 100.64.7.34");
    }

    public void Rozlacz()
    {
        Console.WriteLine("Rozłączono z 100.64.0.1/10");
    }
}

class Laptop : IPoloczenie
{
    public void Polacz()
    {
        Console.WriteLine("Połączono z 192.168.1.1/24 jako 192.168.1.102");
    }

    public void Rozlacz()
    {
        Console.WriteLine("Rozłączono z 192.168.1.1/24");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<IPoloczenie> devices = new List<IPoloczenie> { new Router(), new Laptop() };
        foreach (var device in devices)
        {
            device.Polacz();
        }
    }
}