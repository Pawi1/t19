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
                Console.WriteLine("--- Witaj w programie do zarządzania zwierzętami ---");
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
                            Console.WriteLine("Dziękujemy za skorzystanie z programu");
                            return;
                        default:
                            Console.WriteLine("Niepoprawna opcja. Naciśnij dowolny klawisz, aby spróbować ponownie…");
                            ShowMainMenu(animals);
                            break;
                    }
            }
        private static void AddNewAnimal(List<Animal> animals)
            {
                Console.Clear();
                Console.WriteLine("--- Dodawanie nowego zwierzęcia ---");
                Console.Write("\t1. Podaj nazwe zwierzęcia: ");
                string name = Console.ReadLine()??"";
                Console.Write("\t2. Podaj date urodzenia zwierzęcia (RRRR-MM-DD): ");
                DateTime birthDate = DateTime.Parse(Console.ReadLine()??"");
                Console.Write("\t3. Czy jest ssakiem? (tak/nie): ");
                bool isMamal = (Console.ReadLine()??"").ToLower() == "tak";
                Console.Write("\t4. Podaj rodzaj zwierzęcia (Ptak,Ryba,Gad,Płaz,Ssak): ");
                Kind kind = (Kind)Enum.Parse(typeof(Kind),Console.ReadLine()??"");
                Animal animal = new(name,birthDate,isMamal,kind);
                Console.Write("\nCzy jesteś pewien że chcesz dodać to zwierze? (tak/nie): ");
                if((Console.ReadLine()??"").ToLower() == "tak")
                    {
                        animals.Add(animal);
                        Console.Write("\nPomyślnie dodano nowe zwierze, naciśnij dowolny przycisk by kontynuować…");
                    }
                else
                    {
                        Console.Write("\nPorzucono dodawanie zwierzęcia, naciśnij dowolny przycisk by kontynuować…");
                    }
                Console.ReadKey();
            }
        private static void ShowAnimalList(List<Animal> animals)
            {
            
            }
    
        private static void ShowAnimalDetails(List<Animal> animals)
            {
            
            }
        private static void RemoveAnimal(List<Animal> animals)
            {
            
            }
}