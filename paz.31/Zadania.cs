namespace paz._31;
public class Zadania
{
    public static void Zadanie1()
    { 
//     Napisz program w C#, który wczytuje liczbę całkowitą od użytkownika i oblicza jej pierwiastek kwadratowy.
//     Jeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException i wyświetlić odpowiedni komunikat. 
//     Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby. 
//     Program powinien działać w pętli, dopóki użytkownik nie wpisze q. Użyj instrukcji try-catch-finally do obsługi wyjątków.
        while (true)
        {
            try
            {
                Console.Write("Podaj liczbę do spierwiastkowania: ");
                string rawNumber = Console.ReadLine()??"";
                if (!int.TryParse(rawNumber, out int number)) throw new FormatException();
                if (number < 0) throw new ArgumentOutOfRangeException();
                Console.WriteLine($"Pierwiastek {number} to {Math.Sqrt(number)}");
                break;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Liczba jest ujemna, spróbuj ponownie ...\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Podany zapis jest niepoprawny, spróbuj ponownie ...\n");
            }
            finally
            {
                Thread.Sleep(1500);
            }
        }
    }
    
}