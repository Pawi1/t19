namespace Singleton.Zadanie2;

public class GameSession
{
    private static GameSession _instance;
    public static GameSession Instance => _instance ??= new GameSession();

    private GameSession() { }
    public string PlayerId;
    public string SessionId;
}

public class Program
{
    public static void Main()
    {
        GameSession.Instance.PlayerId = "Testowy";
        GameSession.Instance.SessionId = Guid.NewGuid().ToString();
        Console.WriteLine(GameSession.Instance.PlayerId);
        Console.WriteLine(GameSession.Instance.SessionId);
    }
}