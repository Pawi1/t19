namespace _10_2_konstruktory;
internal class Program{
static void Main()
    {
        Person p1 = new();
        Console.WriteLine(p1.GetData());
        Console.WriteLine(Person.Counter);
    }
}