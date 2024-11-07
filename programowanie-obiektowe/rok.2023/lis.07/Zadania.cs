namespace lis._07
{
    public class Zadania
    {
        public static void Pre()
        {
          // Deklaracja tablicy
          int[] T = new int[] {1,2,3,4,5};
          // Console.WriteLine(T[0]);  // 1
          // Console.WriteLine(T[^1]); // 5
          foreach (var v in T) Console.WriteLine(v);
        }

        public static void Zadanie1()
        {
            bool run = true;
            while (run)
            {
                int[] T = new int[5];
                int sum = 0;
                for (int i = 0; i < 5;)
                {
                    Console.Write($"Podaj {i + 1} liczbę albo 'q' aby zakończyć: ");
                    string inp = Console.ReadLine()??"";
                    if (inp == "q"){ run = false; break;}
                    if (int.TryParse(inp, out int inpInt))
                    {
                        T[i] = inpInt;
                        i++;
                    }
                    else Console.WriteLine("Dane nie są liczbą całkowitą w zakresie 'int', podaj ponownie ...");
                }
                if (run)
                {
                    Console.WriteLine("\nPodane liczby:");
                    foreach (int v in T)
                    {
                        sum += v;
                        Console.Write(v + " ");
                    }
                    Console.WriteLine($"\nSuma podanych liczb to {sum}\n");
                }
            }
        }
    }

    public class DuzeZadanie
    {
        public static void Zadanie()
        {
            int[] Numbers = new int[5];
            for (int i = 0; i<5;i++)
            {
               Numbers[i] = GetIntegerFromUser();
            }
            Console.WriteLine($"Suma wynosi: {CalculateSum(Numbers)}");
        }

        static int GetIntegerFromUser()
        {
            while (true)
            {
                Console.Write($"Podaj liczbę: ");
                string input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else Console.WriteLine("Spróbuj ponownie...");
            }
        }

        static int CalculateSum(int[] Numbers)
        {
            int sum = 0;
            foreach (int v in Numbers)sum += v;
            return sum;
        }
    }
}