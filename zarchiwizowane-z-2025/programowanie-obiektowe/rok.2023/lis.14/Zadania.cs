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
        int size;
        while (true)
        {
            Console.Write($"Podaj rozmiar tablicy {arrayName}: ");
            if (!int.TryParse(Console.ReadLine(), out size) || size<1)
            {
                Console.WriteLine("Podano złą wartość! Wartość musi być liczbą większą od 0 ...");
                continue;
            }
            break;
        }
        return (new int[size],arrayName);
    }
    static void SetArray((int[] Table,string name) Array)
    {
        Console.WriteLine($"Podaj wartości które mają zostać dodane do tablicy {Array.name}, tablica ma określoną długość, w tym przypadku {Array.Table.Length}");
        for (int i = 0;i<Array.Table.Length;i++)
        {
            Console.Write($"Podaj wartość [{i+1}/{Array.Table.Length}]: ");
            if (!int.TryParse(Console.ReadLine(), out int temp))
            {
                Console.WriteLine("Podano złą wartość! Wartość musi być liczbą ...");
                i--;
                continue;
            }
            Array.Table[i] = temp;
        }
    }

    static void DisplayArray((int[] Table,string name) Array)
    {
        Console.WriteLine($"Tablica {Array.name} wygląda następująco:");
        foreach (int number in Array.Table) Console.Write($"{number} ");
    }
}