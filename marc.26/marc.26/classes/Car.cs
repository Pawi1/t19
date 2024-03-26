using System.Data;
using System.Dynamic;

namespace marc._26;
public enum FuelType
{
    Benzyna,
    Diesel,
    Elektryczny,
    Hybrydowy
}
public class Car
{
    static int _numberOfWheels = 4;
    private string? _brand;
    private string? _model;
    private int _yearOfProduction;
    public DateTime DateofFirstRegistration { get;set; }
    public float EngineCapacity { get;set; }
    public Car()
    {
        _brand = "Nieznany";
        _model = "Nieznany";
        _yearOfProduction = 0;
    }
    public Car(string brand, string model, int yearOfProduction)
    {
        _brand = brand;
        _model = model;
        _yearOfProduction = yearOfProduction;
    }


}
