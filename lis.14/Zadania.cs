namespace lis._14;
public class Zadanie1
{
    public static void Major()
    {
        var Array = CreateArray();
        SetArray(Array);
        DisplayArray(Array);
    }
    static (int[],string) CreateArray()
    {
        Console.Write("Podaj nazwę nowej tablicy: ");
        string arrayName = Console.ReadLine()??"";
        Console.Write($"Podaj rozmiar tablicy {arrayName}: ");
        int size = Convert.ToInt32(Console.ReadLine());
        return (new int[size],arrayName);
    }
    static void SetArray((int[] Table,string name) Array)
    {
        Console.WriteLine($"Podaj wartości które mają zostać dodane do tablicy {Array.name}, tablica ma określoną długość, w tym przypadku {Array.Table.Length}");
        for (int i = 0;i<Array.Table.Length;i++)
        {
         Console.Write($"Podaj wartość [{i+1}/{Array.Table.Length}]: ");
         Array.Table[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void DisplayArray((int[] Table,string name) Array)
    {
        Console.WriteLine($"Tablica {Array.name} wygląda następująco:");
        foreach (int number in Array.Table)
        {
            Console.Write($"{number} ");
        }
    }
}