namespace _2026._09._10;

public abstract class Figura
{
    public abstract double Pole();
}

public class Kwadrat : Figura
{
    private int a;
    public Kwadrat(int a)
    {
        this.a = a;
    }
    public override double Pole()
    {
        return a * a;
    }
}

public class Prostokat : Figura
{
    private int a,b;
    public Prostokat(int a , int b)
    {
        this.a = a;
        this.b = b;
    }

    public override double Pole()
    {
        return a * b;
    }
}

public class Kolo : Figura
{
    private int r;
    public Kolo(int r)
    {
        this.r = r;
    }
    public override double Pole()
    {
        return Math.PI * (r*r);
    }
}
class  Program
{
    static void Main(string[] args)
    {
        List<Figura> figury = new List<Figura> { new Kwadrat(5), new Prostokat(10, 8), new Kolo(10) };
        foreach (var fig in figury)
        {
            Console.WriteLine(fig.Pole());
        }
    }
}