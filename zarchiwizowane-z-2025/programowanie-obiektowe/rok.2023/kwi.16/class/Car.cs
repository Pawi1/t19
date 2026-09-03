namespace kwi._16
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsDamaged { get; set; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            IsDamaged = false;
        }

        ~Car()
        {
            Console.WriteLine($"Samochód {Brand} {Model} jest zezłomowany");
        }

        public void Drive()
        {
            if ( IsDamaged )
            {
                Console.WriteLine($"Samochód {Brand} {Model} jest uszkodzony!");
            }
            else
            {
                Console.WriteLine($"Samochód {Brand} {Model} porusza się");
            }
        }

        public void SimulateRandomDamage()
        {
            Random random = new Random();
            int damageType = random.Next(1, 4);

            switch ( damageType )
            {
                case 1:
                    Console.WriteLine($"Samochód {Brand} {Model} ma przebitą oponę!");
                    break;
                case 2:
                    Console.WriteLine($"Silnik samochodu {Brand} {Model} jest uszkodzony!");
                    break;
                case 3:
                    Console.WriteLine($"Samochód {Brand} {Model} ma zepsute światło!");
                    break;
            }

            IsDamaged = true;
        }
    }
}