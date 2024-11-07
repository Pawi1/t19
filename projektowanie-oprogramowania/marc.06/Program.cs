namespace marc._06;

class Program
    {
        static void Main()
            {
                var G = new Dictionary<int,List<int>>();
                Console.Write("Podaj ilosc wierzołków: ");
                var n = int.Parse(Console.ReadLine()??"");
                for (int i = 1; i <= n; i++)
                    {
                        G.Add(i,[]);
                    }
                Console.Write("Podaj ilość krawędzi: ");
                int k = int.Parse(Console.ReadLine()??"");
        
                for (int i = 0;i<k;i++)
                    {
                        Console.Write("Podaj połączenie (x y): ");
                        string[] j = (Console.ReadLine()??"").Split(" ");
                        G[int.Parse(j[0])].Add(int.Parse(j[1]));
                    }
                
                foreach (var item in G)
                    {
                        Console.WriteLine(item.Key + " - "+ string.Join(" ",item.Value));
                    }
            // obliczenie sumy wierzcholków grafu
                
            // podaj ilość wierzchołków bez sąsiadów
            // sprawdź czy isnieje krawędź między a i b
            }
    }