namespace gru._12;

public class Zadania
{
    public static void Pre()
    {
        var slownik = new Dictionary<int, string>();
        slownik.Add(1,"Franek");
        slownik.Add(2,"Anna");
        slownik.Add(3,"Tomasz");
        foreach (var item in slownik)
        {
            Console.Write($"{item.Value} ");
        }
        Console.WriteLine();
    }

    public static void Pre2()
    {
        // tworzymy słownik który przechowuje łańcuchy jako klucze i liczby jako wartości
        var slownik = new Dictionary<string, int>();
        slownik.Add("jeden",1);
        slownik.Add("dwa",2);
        slownik.Add("trzy",3);
        foreach (var item in slownik)
        {
            Console.Write("Klucz {0} Wartość {1}",item.Key,item.Value);
        }
        Console.WriteLine();
    }

    public static void Pre3()
    {
        // Utwórz słownik, który może przechowywać łańcuchy jako klucze i wartości
        // Dodaj kilka par klucz-wartość do słownika za pomocą składni inicj. kolekcji
        var capital = new Dictionary<string, string>
        {
            {"Polska","Warszawa"},
            {"Niemcy","Berlin"},
            {"Belgia","Bruksela"},
            {"Czechy","Praga"}
        };
        foreach (var item in capital)
        {
            Console.Write("Kraj {0} Stolica {1}",item.Key,item.Value);
        }
        Console.WriteLine();
    }

    public static void Pre4()
    {
        var phones = new Dictionary<string, string>();
        phones.Add("+48 112 122 453","Katarzyna");
        phones.Add("+48 112 152 453","Tomasz");
        phones.Add("+48 112 172 453","Anna");
        foreach (var item in phones)
        {
            Console.Write("Numer telefonu: {0}",item.Key);
        }
        Console.WriteLine();
    }

    public static void Pre5()
    {
       var animals = new Dictionary<string, string>()
        {
            {"pies","hau hau"},
            {"kot","miau miau"},
            {"krowa","muu"},
            {"koń","iha"}
        };
        foreach (var item in animals)
        {
            Console.Write("Zwierze {0} Dźwięk {1}",item.Key,item.Value);
        }
        Console.WriteLine();
    }

    public static void Pre6()
    {
        var colors = new Dictionary<string, string>
        {
            {"biały","#FFFFFF"},
            {"czarny","#000000"},
            {"czerwony","#FF0000"},
            {"zielony","#00FF00"},
            {"niebieski","#0000FF"}
        };
        foreach (var item in colors)
        {
            Console.Write("kolor {0} hex {1}",item.Key,item.Value);
        }
        Console.WriteLine();
    }

    public static void Pre7()
    {
        var data = new Dictionary<string, string>();
        Console.WriteLine("Podaj ile par klucz-wartość chcesz wprowadzić");
        int n = int.Parse(Console.ReadLine()??"");
        for (int i=0;i<n;i++)
        {
            Console.Write("Podaj klucz: ");
            string key = Console.ReadLine()??"";
            Console.Write("Podaj wartość: ");
            string value = Console.ReadLine()??"";
            data.Add(key,value);
        }
        foreach (var item in data)
        {
            Console.Write("klucz {0} wartość {1}",item.Key,item.Value);
        }
        Console.WriteLine();
    }

    public static void Zad1()
    {
        // Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik, w którym kluczem jest liczba, a wartością jest jej częstotliwość występowania na liście.
        // Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
        // Przykład: dla listy [1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik {1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.
        
        // Napisz program, który wczytuje od użytkownika ciąg znaków, próbuje przekonwertować go na liczbę całkowitą za pomocą metody TryParse, a następnie wyświetla wynik na konsoli.
        // Jeśli konwersja się powiedzie, program powinien wyświetlić liczbę i informację, że jest to poprawna liczba całkowita.
        // Jeśli konwersja się nie powiedzie, program powinien wyświetlić informację, że podany ciąg znaków nie jest poprawną liczbą całkowitą.
        // Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą całkowitą”.
        // Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą całkowitą”.
        var lista = new List<int>() {1, 2, 3, 2, 4, 1, 5, 2};
        Dictionary<int, int> funkcja(List<int> liczby)
        {
            var slownik = new Dictionary<int, int>();
            foreach (var element in liczby)
            {
                if (slownik.ContainsKey(element)) slownik[element]++;
                else slownik.Add(element,1);
            }
            return slownik;
        }
        foreach (var item in funkcja(lista))
        {
            Console.WriteLine("liczba {0} występuje {1}",item.Key,item.Value);
        }
        Console.WriteLine();
        for (;;)
        {
            Console.Write("Podaj ciąg liczb (q żeby wyjść): ");
            string s = Console.ReadLine()??"";
            if(s.Equals("q"))break;
            if(int.TryParse(s,out _)) Console.WriteLine("{0} jest poprawną liczbą całkowitą",s);
            else Console.WriteLine("{0} nie jest poprawną liczbą całkowitą",s);
        }
    }
}