namespace _10_2_konstruktory;

internal class Person
{
    public static int Counter = 0;
    public string Name { get;set; }
    public string Surname { get; set; }
    
    public int Age {get;set;}
    public float Height {get;set;}
    static Person()
    {
        Console.WriteLine("Statyczny konstruktor klasy Person");
        Counter++;
    }
    public Person(){
        Name = "";
        Surname = "";
        Counter++;
    }
    public Person(string name)
    {
        Name = name;
        Surname = "";
        Counter++;
    }
    public Person(string name,string surname)
    {
        Name = name;
        Surname = surname;
        Counter++;
    }
    public Person(string name,string surname, int age):this(name,surname) {Age = age; Counter++;}

    public Person(string name, string surname, int age, float height):this(name,surname,age){Height = height; Counter++;}
    public string GetData()
    {
        return $"Imie i nazwisko {Name} {Surname}, wiek {Age}";
    }
}
