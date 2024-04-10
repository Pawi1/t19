public interface IWezel
{
    string Name {get;set;}
    void Display() {}
}
public class File : IWezel
{
    public string Name {get;set;}
    public File(string name)
    {
        Name = name;
    }
    public void Display() { Console.Write(Name);}
}
public class Directory : IWezel
{
    public string Name {get;set;}
    List<IWezel> Childrens = new();
    public Directory(string name)
    {
        Name = name;
    }
    public void Display()
    {
        Console.Write(Name+":\n");
        foreach (IWezel child in Childrens)
        {
            Console.Write(" ");
            child.Display();
            Console.WriteLine();
        }
    }
    public void AddChild(IWezel wezel)
    {
        Childrens.Add(wezel);
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Directory zdjecia = new("Zdjecia");
            File z1 = new("z1");
                zdjecia.AddChild(z1);
            File z2 = new("z2");
                zdjecia.AddChild(z2);
            File z3 = new("z3");
                zdjecia.AddChild(z3);
        Directory dysk = new("D");
        dysk.AddChild(zdjecia);
        Directory album = new("Album");
        album.AddChild(zdjecia);
        dysk.AddChild(album);
        dysk.AddChild(z2);
        dysk.Display();
    }
}
