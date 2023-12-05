namespace gru._05;

public class Zadania
{
    public static void pre()
    {
        List<int> ints = new List<int>();
        List<int> ints2 = new List<int>(){1, 2, 1, 10, - 2};
        ints2.Add(1);
        ints2.Add(111); // ints2.Add() dodaje item na koniec listy
        foreach (var v in ints2)
        {
            Console.Write(v+" ");
        }
        Console.WriteLine();
        ints2.Remove(1); // ints2.Remove() usuwa item który był najpóżniej dodany (usunięcie ostatniej 1 ints2[5])
        foreach (var v in ints2)
        {
            Console.Write(v+" ");
        }
    }

    public static void z1()
    {
        // Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
        // Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
        // Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
        List<int> list = new List<int>();
        Random r = new Random();
        for (int i = 0;i<10;i++)
        {
            list.Add(r.Next(0,100));
        }
        List<int> ReturnList(List<int> list)
        {
            List<int> list2 = new List<int>();
            foreach (var v in list)
            {
                if(v%3==0 || v%5==0)list2.Add(v);
            }
            return list2;
        }
        foreach (var v in list)
        {
            Console.Write(v+" ");            
        }
        Console.WriteLine();
        foreach (var v in ReturnList(list))
        {
            Console.Write(v+" ");            
        }
    }
}