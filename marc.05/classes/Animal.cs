namespace marc._05;

public enum Kind
    {
        Ptak,
        Ryba,
        Gad,
        Plaz,
        Ssak
    }
internal class Animal
    {
        public string Name { get;set; }
        public DateTime BirthDate { get;set; }
        public bool IsMammal { get;set; }
        public Kind Kind { get;set; }

        public Animal(string name)
            {
                Name = name;
                BirthDate = DateTime.MinValue; // Domyślna data urodzenia
                IsMammal = true;
                Kind = Kind.Ssak;
            }
        public string Describe()
            {
                string description = string.Concat("Nazwa zwierzęcia: ",Name,". Data urodzenia: ",BirthDate.ToShortDateString(),"r.");
                if(IsMammal)
                    {
                        description = string.Concat(description," Zwierze jest ssakiem. ");
                    }
                else
                    {
                        description = string.Concat(description," Zwierze nie jest ssakiem. ");
                    }
                description = string.Concat(description,"Rodzaj zwierzęcia: ",Kind);
                return description;
            }
    }
