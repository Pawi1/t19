namespace Singleton.Zadanie1;

public class ConfigurationManager
{
    private static ConfigurationManager _instance; 
    private ConfigurationManager() { }

    public static ConfigurationManager Instance => _instance ??= new ();
    public string Path;
    public bool IsDebug;
}

public class Program
{
    public static void Main()
    {
        ConfigurationManager.Instance.Path = "/opt/test";
        ConfigurationManager.Instance.IsDebug = false;
        Console.WriteLine(ConfigurationManager.Instance.Path);
        Console.WriteLine(ConfigurationManager.Instance.IsDebug);
    }
}