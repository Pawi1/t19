namespace _2024._09._09;

public class Shape
{
    public virtual float CalcArena()
    {
        return 0F;
    }    
    public virtual float CalcPerimetro()
    {
        return 0F;
    }
}
public class Rect:Shape
{
    private float width;
    private float height;
    public void SetDimension(float w, float h)
    {
        width = w;
        height = h;
    }
    public override float CalcArena()
    {
        // return base.CalcArena();
        return width * height;
    }
    public override float CalcPerimetro()
    {
        // return base.CalcPerimetro();
        return 2 * (width * height);
    }
}
public class Circle:Shape
{
    private float radius;
    public Circle(float r)
    {
        radius = r;
    }
    public  void SetRadius(float r)
    {
        radius = r;
    }
    public override float CalcPerimetro()
    {
        // return base.CalcPerimetro();
        return MathF.Round(2*MathF.PI * radius,2);
    }

}
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Prostokąt");
            Console.WriteLine("2. Koło");
            Console.WriteLine("3. Trójkąt");
            Console.WriteLine("4. Trapez");
            Console.WriteLine("5. Kula");
            Console.WriteLine("6. Wyjście");
            Console.Write("Wybierz krztałt do obliczenia");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch( choice) 
            {
                    case 1:
                    Rect rect = new Rect();                    
                    float rectW = inputProtection("Podaj szerokość: ");
                    float rectH = inputProtection("Podaj długośc: ");
                    rect.SetDimension(rectW,rectH);
                    Console.WriteLine("Powierzchnia prostokątu wynosi: {1}",rect.CalcArena());
                    Console.WriteLine("Obwód prostokątu wynosi: {1}", rect.CalcPerimetro());
                break;
                    case 2:
                    Circle circle = new Circle(0F);
                    circle.SetRadius(inputProtection("Podaj średnice koła: "));
                    Console.WriteLine("Obwód prostokątu wynosi: {1}",circle.CalcPerimetro());
                break;
                    case 3:
                break;
                    case 4:
                break;
            }
        }
        
        float inputProtection(string name)
        {
            while (true)
            {
                Console.Write(name);
                if (float.TryParse(Console.ReadLine(), out float inp) && inp > 0)
                    return inp;
                else Console.WriteLine("\x1b[1;31mPodaj ponownie…\x1b[0m");
            }
        }
        }   
    }