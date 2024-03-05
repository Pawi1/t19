namespace marc._05;

class Program
    {
        static void Main()
            {
                List<Animal> animals = [];
                ShowMainMenu(animals);
            }
        private static void ShowMainMenu(List<Animal> animals)
            {
                Console.Clear();
                Console.WriteLine("Witaj w programie do zarządzania zwierzętami");
                Console.WriteLine("\t1. Dodaj zwierze");
                Console.WriteLine("\t2. Pokaż liste zwierząt");
                Console.WriteLine("\t3. Pokaż szczegóły zwierze");
                Console.WriteLine("\t4. Usuń zwierze");
                Console.WriteLine("\t5. Zakończ program\n");
                Console.Write("Wybierz jedną z opcji: ");
                string choice = Console.ReadLine()??"";
                switch(choice)
                    {
                        case "1":
                            AddNewAnimal(animals);
                            break;
                        case "2":
                            ShowAnimalList(animals);
                            break;
                        case "3":
                            ShowAnimalDetails(animals);
                            break;
                        case "4":
                            RemoveAnimal(animals);
                            break;
                        case "5":
                            break;
                    }
            }

    private static void RemoveAnimal(List<Animal> animals)
        {
        
        }

    private static void ShowAnimalDetails(List<Animal> animals)
        {
        
        }

    private static void AddNewAnimal(List<Animal> animals)
        {
        
        }
    private static void ShowAnimalList(List<Animal> animals)
        {
        
        }
}