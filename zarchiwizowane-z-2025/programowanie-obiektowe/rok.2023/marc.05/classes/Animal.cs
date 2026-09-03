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
        public string Name { get;set; } = "";
        public DateTime BirthDate { get;set; } = DateTime.MinValue;
        public bool IsMammal { get;set; } = true;
        public Kind Kind { get;set; } = Kind.Ssak;

        public Animal(string name)
            {
                Name = name;
            }
        public Animal(string name, DateTime birthDate):this(name)
            {
                BirthDate = birthDate;
            }
        public Animal(string name, DateTime birthDate, bool isMammal):this(name,birthDate)
            {
                IsMammal = isMammal;
            }
        public Animal(string name,DateTime birthDate, bool isMammal, Kind kind):this(name,birthDate,isMammal)
            {
                Kind = kind;
            }
        public string Describe()
            {
                return string.Concat("Nazwa zwierzęcia: ",Name,". Data urodzenia: ",BirthDate.ToShortDateString(),"r.",IsMammal?" Zwierze jest ssakiem. ":" Zwierze nie jest ssakiem. ","Rodzaj zwierzęcia: ",Kind);
            }
        public string ShowAge()
            {
                return string.Concat(Name," ma ",DateTime.Now.Year-BirthDate.Year," lat.");
            }
    }
