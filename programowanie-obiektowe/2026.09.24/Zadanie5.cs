abstract class PozycjaBiblioteczna(string title, string author)
{
    protected bool isBorrowed { get; set; }
    protected string title { get; } = title;
    public string Title => title;
    protected string author { get; } = author;
    protected uint numberOfPages { get; set; }
    protected uint yearOfPublication { get; set; }

    public PozycjaBiblioteczna(string title, string author, uint numberOfPages) : this(title, author)
    {
        this.numberOfPages = numberOfPages;
    }

    public PozycjaBiblioteczna(string title, string author, uint numberOfPages, uint yearOfPublication) : this(title, author)
    {
        this.numberOfPages = numberOfPages;
        this.yearOfPublication = yearOfPublication;
    }

    public virtual void Info()
    {
        Console.WriteLine(title);
        Console.WriteLine(author);
        Console.WriteLine(numberOfPages);
        Console.WriteLine(yearOfPublication);
    }
}

class Ksiazka(string title, string author) : PozycjaBiblioteczna(title, author)
{
    protected uint editionNumber { get; }

    public Ksiazka(string title, string author, uint editionNumber) : this(title, author)
    {
        this.editionNumber = editionNumber;
    }

    public Ksiazka(string title, string author, uint editionNumber, uint numberOfPages) : this(title, author, editionNumber)
    {
        this.numberOfPages = numberOfPages;
    }

    public Ksiazka(string title, string author, uint editionNumber, uint numberOfPages, uint yearOfPublication) : this(title, author, editionNumber, numberOfPages)
    {
        this.yearOfPublication = yearOfPublication;
    }

    public override void Info()
    {
        base.Info();
        Console.WriteLine(editionNumber);
    }
}

class Czasopismo(string title, string author) : PozycjaBiblioteczna(title, author)
{
    protected uint issueNumber { get; }

    public Czasopismo(string title, string author, uint issueNumber) : this(title, author)
    {
        this.issueNumber = issueNumber;
    }

    public Czasopismo(string title, string author, uint issueNumber, uint numberOfPages) : this(title, author, issueNumber)
    {
        this.numberOfPages = numberOfPages;
    }

    public Czasopismo(string title, string author, uint issueNumber, uint numberOfPages, uint yearOfPublication) : this(title, author, issueNumber, numberOfPages)
    {
        this.yearOfPublication = yearOfPublication;
    }

    public override void Info()
    {
        base.Info();
        Console.WriteLine(issueNumber);
    }
}
class Czytelnik(string name, string surname)
{
    protected string name { get; } = name;
    protected string surname { get; } = surname;
    public string Name => name;
    public string Surname => surname;
    protected string address { get; set; }
}

class Wypozyczenie
{
    protected static Dictionary<PozycjaBiblioteczna, Czytelnik?> wypozyczenia { get; } = new();
    public bool Borrow(PozycjaBiblioteczna pozycja, Czytelnik czytelnik)
    {
        if (!wypozyczenia.TryGetValue(pozycja, out var obecny))
        {
            Console.WriteLine("Biblioteka nie ma tej książki");
            return false;
        }

        if (obecny != null)
        {
            Console.WriteLine("Ktoś już wypożyczył tę książkę");
            return false;
        }

        wypozyczenia[pozycja] = czytelnik;
        return true;
    }
    public void UnBorrow(PozycjaBiblioteczna pozycja)
    {
        wypozyczenia[pozycja] = null;
    }
    
    public void AddPozycjaBiblioteczna(PozycjaBiblioteczna pozycja)
    {
        wypozyczenia.Add(pozycja, null);
    }
    public void AddPozycjaBiblioteczna(PozycjaBiblioteczna pozycja, Czytelnik czytelnik)
    {
        wypozyczenia.Add(pozycja, czytelnik);
    }
    public bool RemovePozycjaBiblioteczna(PozycjaBiblioteczna pozycja)
    {
        return wypozyczenia.Remove(pozycja);
    }
}

class Biblioteka(List<Czytelnik> czytelnicy) : Wypozyczenie
{
    public List<Czytelnik> czytelnicy = czytelnicy;

    public void AddCzytelnik(Czytelnik czytelnik)
    {
        czytelnicy.Add(czytelnik);
    }

    public Czytelnik? FindCzytelnik(string name, string surname)
    {
        return czytelnicy.FirstOrDefault(c => c.Name == name && c.Surname == surname);
    }

    public PozycjaBiblioteczna? FindPozycjaByTitle(string title)
    {
        return wypozyczenia.Keys.FirstOrDefault(p => p.Title == title);
    }

    public IEnumerable<PozycjaBiblioteczna> ListAvailable()
    {
        return wypozyczenia.Where(kv => kv.Value == null).Select(kv => kv.Key);
    }

    public IEnumerable<PozycjaBiblioteczna> ListBorrowed()
    {
        return wypozyczenia.Where(kv => kv.Value != null).Select(kv => kv.Key);
    }

    public PozycjaBiblioteczna? FindAvailableByTitle(string title)
    {
        foreach (var kv in wypozyczenia)
        {
            if (kv.Key.Title == title && kv.Value == null)
            {
                return kv.Key;
            }
        }
        return null;
    }

    public bool BorrowByTitle(string title, string name, string surname)
    {
        var pozycja = FindAvailableByTitle(title);
        var czytelnik = FindCzytelnik(name, surname);

        if (pozycja == null)
        {
            Console.WriteLine("Brak wolnego egzemplarza o podanym tytule");
            return false;
        }

        if (czytelnik == null)
        {
            Console.WriteLine("Nie znaleziono czytelnika");
            return false;
        }

        return Borrow(pozycja, czytelnik);
    }

    public PozycjaBiblioteczna? FindBorrowedByTitleAndReader(string title, Czytelnik? czytelnik)
    {
        foreach (var kv in wypozyczenia)
        {
            if (kv.Key.Title == title && kv.Value == czytelnik)
            {
                return kv.Key;
            }
        }
        return null;
    }

    public void ReturnByTitle(string title, Czytelnik? czytelnik)
    {
        var pozycja = FindBorrowedByTitleAndReader(title, czytelnik);

        if (pozycja == null)
        {
            Console.WriteLine("Ten czytelnik nie ma wypożyczonej pozycji o podanym tytule");
            return;
        }

        UnBorrow(pozycja);
    }
    public void PrintAll()
    {
        foreach (var (pozycja, czytelnik) in wypozyczenia)
        {
            pozycja.Info();
            Console.WriteLine(czytelnik != null ? $"Wypożyczone przez: {czytelnik.Name} {czytelnik.Surname}" : "Dostępne");
            Console.WriteLine("---");
        }
    }

    public IEnumerator<KeyValuePair<PozycjaBiblioteczna, Czytelnik?>> GetEnumerator()
    {
        return wypozyczenia.GetEnumerator();
    }
}
internal class Program
{
    public static void Main(string[] args)
    {
        // utworzenie biblioteki
        var biblioteka = new Biblioteka(new List<Czytelnik>());

        biblioteka.AddPozycjaBiblioteczna(new Ksiazka("Mały Książę", "Antoine de Saint-Exupéry", 1));
        biblioteka.AddPozycjaBiblioteczna(new Ksiazka("Hobbit", "J.R.R. Tolkien", 2, 310, 1937));
        biblioteka.AddPozycjaBiblioteczna(new Ksiazka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling"));
        biblioteka.AddPozycjaBiblioteczna(new Ksiazka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling")); // duplikat
        biblioteka.AddPozycjaBiblioteczna(new Czasopismo("National Geographic", "National Geographic Partners", 316, 50));
        biblioteka.AddPozycjaBiblioteczna(new Czasopismo("Wiedza i Życie", "Prószyński Media", 16, 20, 2016));

        // dodanie czytelników
        biblioteka.AddCzytelnik(new Czytelnik("Adam", "Kowalski"));
        biblioteka.AddCzytelnik(new Czytelnik("Michał", "Nowak"));
        biblioteka.AddCzytelnik(new Czytelnik("Andrzej", "Stolarski"));
        biblioteka.AddCzytelnik(new Czytelnik("Monika", "Mickiewicz"));

        Console.WriteLine("-- Stan biblioteki przed wypożyczeniami --");
        biblioteka.PrintAll();

        // operacje:
        // wypozyczenie harryego przez adama
        biblioteka.BorrowByTitle("Harry Potter i Kamień Filozoficzny", "Adam", "Kowalski");

        // wypozyczenie drugiego harrego
        biblioteka.BorrowByTitle("Harry Potter i Kamień Filozoficzny", "Michał", "Nowak");

        // próba wypożyczenia czegoś, czego nie ma w bibliotece
        Console.WriteLine();
        Console.WriteLine("próba wypożyczenia czegoś, czego nie ma w bibliotece");
        biblioteka.BorrowByTitle("Nieistniejąca Książka", "Andrzej", "Stolarski");

        Console.WriteLine();
        Console.WriteLine("-- Stan biblioteki po wypożyczeniach --");
        biblioteka.PrintAll();

        // zwrot Hobbita
        biblioteka.ReturnByTitle("Harry Potter i Kamień Filozoficzny",biblioteka.FindCzytelnik("Adam","Kowalski"));

        Console.WriteLine();
        Console.WriteLine("-- Stan biblioteki po zwrocie Harrego --");
        biblioteka.PrintAll();

        Console.WriteLine();
        Console.WriteLine("-- Iteracja przez foreach po obiekcie Biblioteka --");
        foreach (var wpis in biblioteka)
        {
            Console.WriteLine($"{wpis.Key.Title} -> {(wpis.Value != null ? $"{wpis.Value.Name} {wpis.Value.Surname}" : "wolna")}");
        }
    }
}