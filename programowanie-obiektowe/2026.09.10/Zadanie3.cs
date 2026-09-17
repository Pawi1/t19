class Pracownik
{
    protected string name, surname;

    public Pracownik(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public virtual void Opis()
    {
        Console.WriteLine($"{name} {surname}: Pracownik");
    }
}

class Programista : Pracownik
{
    public Programista(string name, string surname) : base(name, surname) { }

    public override void Opis()
    {
        Console.WriteLine($"{name} {surname}: Programista");
    }
}

class Tester : Pracownik
{
    public Tester(string name, string surname) : base(name, surname) { }
    public override void Opis()
    {
        Console.WriteLine($"{name} {surname}: Tester");
    }
}

// class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Pracownik> pracownicy = new List<Pracownik> {new Programista("Adam","Nowak"), new Tester("Ania","Kowal")};
//         foreach (var pracownik in pracownicy)
//         {
//             pracownik.Opis();
//         }
//     }
// }