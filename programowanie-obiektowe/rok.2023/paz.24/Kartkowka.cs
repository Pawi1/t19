namespace paz._24;
public class Kartkowka
{
    public static void Zadanie()
    {
        // gr 1
        // Zadanie: Użytkownik podaje swoje imie i rok urodzenia
        // dodaj wyjątki i zabezpiecz program
        string imie;
        ushort rok;
        while (true)
        {
            try
            {
                Console.Clear();
                Console.Write("Zadanie: Użytkownik podaje swoje imie i rok urodzenia\nPodaj swoje imie: ");
                imie = Console.ReadLine()??"";
                if (imie == "") throw new Exception("Brak imienia");
                if (imie.Length < 3) throw new Exception("Twoje imie jest za krótkie");
                if (containsDigit(imie)) throw new Exception("Twoje imie zawiera liczbę");
                Console.Write("Podaj swój rok urodzenia: ");
                rok = Convert.ToUInt16(Console.ReadLine());
                if (rok > 2023) throw new Exception("Twój rok urodzenia jest za duży");
                if (rok < 1900) throw new Exception("Twój rok urodzenia jest za mały");
                break;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
                Thread.Sleep(1500);
            }
        }
        Console.WriteLine($"Witaj {imie} masz {2023-rok} lat!");
    }

    static bool containsDigit(string text)
    {
        if (text.Contains('0') ||
            text.Contains('1') ||
            text.Contains('2') ||
            text.Contains('3') ||
            text.Contains('4') ||
            text.Contains('5') ||
            text.Contains('6') ||
            text.Contains('7') ||
            text.Contains('8') ||
            text.Contains('9')) return true;
        else return false;
    }
}