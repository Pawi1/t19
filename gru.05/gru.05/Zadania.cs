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

    public static void z2()
    {
        //•	Napisz program, który tworzy listę liczb całkowitych i wypełnia ją losowymi wartościami z zakresu od 1 do 100.
        // •	Napisz program, który wyświetla menu z pięcioma opcjami, co chcesz zrobić z listą:
        // •	Wyświetlić listę liczb podzielnych przez 3 lub 5
        // •	Wyświetlić listę liczb nieparzystych
        // •	Wyświetlić listę liczb posortowanych rosnąco
        // •	Wyświetlić listę liczb posortowanych malejąco
        // •	Wyjść z programu
        // •	Napisz metodę dla każdej opcji, która przyjmuje jako parametr listę liczb i zwraca listę liczb spełniających warunek danej opcji.
        // •	Napisz kod, który obsługuje wybór użytkownika i wywołuje odpowiednią metodę, a następnie wyświetla wynikową listę na konsoli.
        // •	Napisz kod, który powtarza wyświetlanie menu i obsługę wyboru, dopóki użytkownik nie wybierze opcji wyjścia z programu.
        for (;;)
        {
            Console.Clear();
            Console.Write("\tProgram:\n1. Wyświetlić listę liczb podzielnych przez 3 lub 5\n2. Wyświetlić listę liczb nieparzystych\n3. Wyświetlić listę liczb posortowanych rosnąco\n4. Wyświetlić listę liczb posortowanych malejąco\nq. Wyjdź z programu\n\nTwój wybór: ");
            string s = Console.ReadLine()??"";
            if (int.TryParse(s, out int j))
            {
                switch (j)
                {
                    case 1:
                        F1();
                        break;
                    case 2:
                        F2();
                        break;
                    case 3:
                        F3();
                        break;
                    case 4:
                        F4();
                        break;
                    default:
                        Console.WriteLine("Niepoprawny warunek, spróbuj ponownie ...");
                        Console.ReadLine();
                        break;
                }
            }
            else if(s == "q") return;
            else
            {
                Console.WriteLine("Niepoprawny warunek, spróbuj ponownie ...");
                Console.ReadLine();
            }
        }
        void F1()
        {
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

            Console.Write("\nNaciśnij dowolny przycisk aby kontynuować ...");
            Console.ReadLine();
        }
        void F2()
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0;i<10;i++)
            {
                list.Add(r.Next(0,100));
            }
            List<int> ModuloList(List<int> list)
            {
                List<int> list2 = new List<int>();
                foreach (var v in list)
                {
                    if(!(v%2==0))list2.Add(v);
                }
                return list2;
            }
            foreach (var v in list)
            {
                Console.Write(v+" ");            
            }
            Console.WriteLine();
            foreach (var v in ModuloList(list))
            {
                Console.Write(v+" ");            
            }

            Console.Write("\nNaciśnij dowolny przycisk aby kontynuować ...");
            Console.ReadLine();
        }
        void F3()
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0;i<10;i++)
            {
                list.Add(r.Next(0,100));
            }
            List<int> SortList(List<int> list)
            {
                list.Sort();
                return list;
            }
            foreach (var v in list)
            {
                Console.Write(v+" ");            
            }
            Console.WriteLine();
            foreach (var v in SortList(list))
            {
                Console.Write(v+" ");            
            }

            Console.Write("\nNaciśnij dowolny przycisk aby kontynuować ...");
            Console.ReadLine();
        }
        void F4()
        {
        }
    }
}