namespace composite;

public abstract class Component 
{
    public abstract void Operation();
}
public class Leaf : Component
{
    public override void Operation(){}
}
public class Composite : Component
{
    public List<Component> components = new();
    public override void Operation(){}
    
    public void Add(){}
    public void Remove(){}
    public void GetChild(){}
}
class Program
{
    static void Main()
    {
    }
}
