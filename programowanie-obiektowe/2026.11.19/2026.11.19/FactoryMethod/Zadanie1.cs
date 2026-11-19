namespace FactoryMethod.Zadanie1;

public interface IAnimal
{
    public void WhoAmI();
}

public class Dog : IAnimal
{
    public void WhoAmI()
    {
        Console.Write("Dog");
    }
}

public class Cat : IAnimal
{
    public void WhoAmI()
    {
        Console.Write("Cat");
    }
}
public class Bird : IAnimal
{
    public void WhoAmI()
    {
        Console.Write("Bird");
    }
}

public class CreateAnimal
{
    public static IAnimal Create(string type)
    {
        return type.ToLower() switch
        {
            "dog" => new Dog(),
            "cat" => new Cat(),
            "bird" => new Bird(),
            _ => throw new ArgumentException("Unknown type: " + type)
        };
    }
}

public class Program
{
    public static void Main()
    {
        var animal1 = CreateAnimal.Create("dog");
        var animal2 = CreateAnimal.Create("cat");
        animal1.WhoAmI();
        animal2.WhoAmI();
    }    
}