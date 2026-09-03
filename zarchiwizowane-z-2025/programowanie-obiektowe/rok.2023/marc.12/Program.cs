namespace marc._12;
class Program
    {
        static void Main()
            {
                try
                    {
                        List<Animal> animals = [];
                        ShowMainMenu(animals);
                    }
                catch(Exception)
                    {
                        Console.WriteLine("BŁĄD!");
                    }
            }
        private static void ShowMainMenu(List<Animal> animals)
            {
                while(true)
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
            }   
        private static void AddNewAnimal(List<Animal> animals)
            {
                Console.Clear();
                Console.WriteLine("--- Dodawanie nowego zwierzęcia ---");
                Console.Write("\t1. Podaj nazwe zwierzęcia: ");
                string name = Console.ReadLine()??"";
            BirthDate:
                Console.Write("\t2. Podaj date urodzenia zwierzęcia (RRRR-MM-DD): ");
                DateTime birthDate;
                if(DateTime.TryParse(Console.ReadLine() ?? "", out DateTime bD))
                    {
                        birthDate = bD;
                    }
            else goto BirthDate;
                Console.Write("\t3. Czy jest ssakiem? (TAK/nie): ");
                string mammal = (Console.ReadLine()??"").ToLower();
                bool isMammal = mammal == "tak" || mammal == "t" || mammal == "";
            Kind:
                Kind kind;
                if(isMammal) 
                    {
                        kind = Kind.Ssak;
                    }
                else
                    {
                        Console.Write("\t4. Podaj rodzaj zwierzęcia (Ptak,Ryba,Gad,Płaz,Ssak): ");
                        try
                            {
                                kind = (Kind)Enum.Parse(typeof(Kind),Console.ReadLine()??"");
                            }
                        catch
                            {
                                goto Kind;
                            }
                    }
                Animal animal = new(name,birthDate,isMammal,kind);
                Console.Write("\nCzy jesteś pewien że chcesz dodać to zwierze? (TAK/nie): ");
                string choice = (Console.ReadLine()??"").ToLower();
                if(choice == "tak" || choice == "t" || choice == "")
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
                Console.Clear();
                Console.WriteLine("\t--- Lista Zwierząt ---");
                Console.WriteLine("\t[Numer]\t\t[Nazwa]");
                for(int i = 0;i<animals.Count;i++)
                    {
                        Console.Write("\t "+i+"\t\t"+animals[i].Name+"\n");
                    }
                Console.Write("\nNacisnij dowolny przycisk by kontynuować…");
                Console.ReadLine();
            }
    
        private static void ShowAnimalDetails(List<Animal> animals)
            {
                Console.Clear();
                Console.WriteLine("--- Detale Zwierzęcia ---");
                Console.Write("1. Podaj numer zwierzęcia którego chcesz poznać szczegóły: ");
                int choice = int.Parse(Console.ReadLine()??"");
                Console.WriteLine(animals[choice].Describe()+"\n"+animals[choice].ShowAge());
                Console.Write("\nNacisnij dowolny przycisk by kontynuować…");
                Console.ReadLine();
            }
        private static void RemoveAnimal(List<Animal> animals)
            {
                Console.Clear();
                Console.WriteLine("--- Usuwanie Zwierzęcia ---");
                Console.Write("1. Podaj numer zwierzęcia którego chcesz usunąć: ");
                int choice = int.Parse(Console.ReadLine()??"");
                Console.Write("\nCzy jesteś pewien że chcesz dodać to zwierze? (TAK/nie): ");
                string choice2 = (Console.ReadLine()??"").ToLower();
                if(choice2 == "tak" || choice2 == "t" || choice2 == "")
                    {
                        animals.RemoveAt(choice);
                        Console.Write("\nPomyślnie usunięto zwierze, naciśnij dowolny przycisk by kontynuować…");
                    }
                else
                    {
                        Console.Write("\nPorzucono usuwanie zwierzęcia, naciśnij dowolny przycisk by kontynuować…");
                    }
                Console.ReadLine();
            }
}
