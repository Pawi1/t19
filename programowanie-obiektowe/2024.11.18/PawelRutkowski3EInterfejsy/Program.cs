namespace PawelRutkowski3EInterfejsy
{
    internal interface ICar
    {
        void StartEngine();
        void Drive();
    }

    public abstract class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Owner { get; set; }

        public Car(string brand,string model,int year,string owner)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Owner = owner;
        }

        public void StartEngine()
        {
            Console.WriteLine($"{Brand} {Model} Starting engine...");
        }
        public abstract void Drive();
    }

    public class ElectricCar : Car
    {
        public ElectricCar(string brand,string model,int year,string owner):base(brand,model,year,owner)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Owner = owner;
        }
        public override void Drive()
        {
            Console.WriteLine($"{Brand} {Model} Driving by Electric...");
        }
    }

    public class GasolineCar : Car
    {
        public GasolineCar(string brand,string model,int year,string owner):base(brand,model,year,owner)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Owner = owner;
        }
        public override void Drive()
        {
            Console.WriteLine($"{Brand} {Model} Driving by Gasoline...");
        }
    }

    internal class Program
    {
        static void DisplaySortedListOfCars(IOrderedEnumerable<Car>? listOfCars)
        {
            if (listOfCars is null)
                return;
            int i = 0;
            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{++i} -> {car.Brand} {car.Model} {car.Year} {car.Owner}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1:");
            var car1 = new ElectricCar("Tesla", "Model S", 2020, "Jan Kowalski");
            var car2 = new GasolineCar("Ford", "Mustang", 2018, "Anna Nowak");
            var car3 = new ElectricCar("Nissan", "Leaf", 2019, "Piotr Wiśniewski");
            var car4 = new GasolineCar("BMW", "X5", 2017, "Katarzyna Zielińska");
            car1.StartEngine();
            car1.Drive();
            car2.StartEngine();
            car2.Drive();
            car3.StartEngine();
            car3.Drive();
            car4.StartEngine();
            car4.Drive();
            var listOfCars = new List<Car>
            {
                car1,
                car2,
                car3,
                car4
            };
            foreach (var car in listOfCars)
            {
                car.StartEngine();
                car.Drive();
            }
            Console.WriteLine("\nPart 2:");
            // Part 2
            var sortedCarsOwner = listOfCars.OrderBy(car => car.Owner);
            DisplaySortedListOfCars(sortedCarsOwner);
            Console.WriteLine();
            var sortedCarsYear = listOfCars.OrderBy(car => car.Year);
            DisplaySortedListOfCars(sortedCarsYear);
            Console.WriteLine();
            var sortedCarsBrand = listOfCars.OrderBy(car => car.Brand);
            DisplaySortedListOfCars(sortedCarsBrand);
            Console.WriteLine();
            var sortedCarsModel = listOfCars.OrderBy(car => car.Model);
            DisplaySortedListOfCars(sortedCarsModel);
            Console.WriteLine();
            // Part 3
            Console.WriteLine("Press any key to go into Part 3...");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {

                Console.WriteLine("Car workshop:\nSort by:\n1) Owner\n2) Year\n3) Brand\n4) Model\n5) Exit");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Select an option how do you like sort the cars?: ");
                Console.ResetColor();
                try
                {
                    byte choice = byte.Parse(Console.ReadLine()??"");
                    switch (choice)
                    {
                        case 1:
                            SortByOwner(listOfCars);
                            break;
                        case 2:
                            SortByYear(listOfCars);
                            break;
                        case 3:
                            SortByBrand(listOfCars);
                            break;
                        case 4:
                            SortByModel(listOfCars);
                            break;
                        case 5:
                            return;
                        default:
                            throw new ArgumentOutOfRangeException();

                    }

                    Console.WriteLine("Press any key to continue…");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The error occured ({e.Message})! Try again!…");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            void SortByOwner(List<Car> cars)
            {
                DisplaySortedListOfCars(cars.OrderBy(car => car.Owner));
            }
            void SortByYear(List<Car> cars)
            {
                DisplaySortedListOfCars(cars.OrderBy(car => car.Year));
            }
            void SortByBrand(List<Car> cars)
            {
                DisplaySortedListOfCars(cars.OrderBy(car => car.Brand));
            }
            void SortByModel(List<Car> cars)
            {
                DisplaySortedListOfCars(cars.OrderBy(car => car.Model));
            }
        }
    }
}