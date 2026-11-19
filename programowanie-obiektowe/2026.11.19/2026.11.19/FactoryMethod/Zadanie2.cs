namespace FactoryMethod.Zadanie2;

public interface INotification
{
    static readonly string Type;
    void Send(string message);
}

public class EmailNotification:INotification
{
    static readonly string Type = "Email";

    public void Send(string message)
    {
        Console.WriteLine($"{Type}: {message}");
    }
}

public class SmsNotification:INotification
{
    static readonly string Type = "SMS";

    public void Send(string message)
    {
        Console.WriteLine($"{Type}: {message}");
    }
}

public class PushNotification:INotification
{
    static readonly string Type = "Push";

    public void Send(string message)
    {
        Console.WriteLine($"{Type}: {message}");
    }
}

public class CreateNotify
{
    public static INotification Create(string type)
    {
        return type.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new EmailNotification(),
            "push" => new EmailNotification(),
            _ => throw new ArgumentException("Unknown type: " + type)
        };
    }
}

public class Program
{
    
}