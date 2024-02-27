namespace _10_2_konstruktory;

internal class Person
{
    public static int Counter = 0;
    public string Name { get;set; }
    public string Surname { get; set; }
    
    public int Age {get;set;}
    static Person()
    {
        Console.WriteLine("Statyczny konstruktor klasy Person");
        Counter++;
    }
    public Person(){
        Name = "nieznane";
        Surname = "nieznane";
    }
    public Person(string name,string surname)
    {
        Name = name;
        Surname = surname;
    }
    public string GetData()
    {
        return $"Imie i nazwisko {Name} {Surname}, wiek {Age}";
    }
}
