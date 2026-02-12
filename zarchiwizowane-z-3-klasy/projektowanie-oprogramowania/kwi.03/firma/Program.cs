namespace firma;

public abstract class Osoba {}
public class Ksiegowa : Osoba {}
public class Magazynier : Osoba {}
public class Kierowca : Osoba {}
public class Spedytor : Osoba {}

public class DyrFinansow : Osoba 
{
    public List<Osoba> Podwładni = new()
    {
        new Ksiegowa()
    };
}
public class DyrLogistyki : Osoba 
{
    public List<Osoba> Podwładni = new()
    {
        new Kierowca(),
        new Magazynier(),
        new Spedytor()
    };
}
public class Prezes : Osoba
{
    public List<Osoba> Dyrektorzy = new()
    {
        new DyrFinansow(),
        new DyrLogistyki()
    };
}
class Program
{
    static void Main(string[] args)
    {
    }
}
