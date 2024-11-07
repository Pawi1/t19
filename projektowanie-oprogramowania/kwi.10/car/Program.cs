public interface Car { public void build(); }
public class BMW : Car { public void build(){} }
public class Chevrolet : Car { public void build(){} }
public class Renault : Car { public void build(){} }
public class FacadeForCar
{
    private Car bmw;
    private Car chevrolet;
    private Car renoult;
    public FacadeForCar(BMW bmw, Chevrolet chevrolet, Renault renoult)
    {
        this.bmw = bmw;
        this.chevrolet = chevrolet;
        this.renoult = renoult;
    }
    public void bulidBmw()
    {
        bmw.build();
    }
    public void buildChevrolet()
    {
        chevrolet.build();
    }
    public void buildRenoult()
    {
        renoult.build();
    }
}
internal class Program
{
    public static void Main(string[] args)
    {
         
    }
}