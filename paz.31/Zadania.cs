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
                Console.Write("Podaj liczbę do spierwiastkowania (albo q aby wyjść): ");
                string rawNumber = Console.ReadLine()??"";
                if(rawNumber.ToLower() == "q"){Console.WriteLine("Program zostanie wyłączony ..."); break;}
                if (!int.TryParse(rawNumber, out int number)) throw new FormatException();
                if (number < 0) throw new ArgumentOutOfRangeException();
                Console.WriteLine($"Pierwiastek {number} to {Math.Sqrt(number)}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Liczba jest ujemna, spróbuj ponownie ...");
            }
            catch (FormatException)
            {
                Console.WriteLine("Podany zapis jest niepoprawny, spróbuj ponownie ...");
            }
            finally
            {
                Thread.Sleep(1000);
                Console.WriteLine();
            }
        }
    }

    public static void Zadanie2()
    {
//     Napisz program w C#, który wczytuje od użytkownika 5 liczb całkowitych i zapisuje je w tablicy. 
//     Następnie program prosi użytkownika o podanie indeksu tablicy i wyświetla liczbę znajdującą się pod tym indeksem. 
//     Jeśli użytkownik wprowadzi indeks spoza zakresu tablicy, program powinien zgłosić wyjątek ArgumentOutOfRangeException
//     i wyświetlić odpowiedni komunikat. Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException
//     i poprosić o ponowne wprowadzenie danych. Program powinien działać w pętli, dopóki użytkownik nie wpisze q. 
//     Użyj instrukcji try-catch do obsługi wyjątkówJeśli liczba jest ujemna, program powinien zgłosić wyjątek ArgumentOutOfRangeException
//      i wyświetlić odpowiedni komunikat. 
//     Jeśli użytkownik wprowadzi nieprawidłowe dane, program powinien zgłosić wyjątek FormatException i poprosić o ponowne wprowadzenie liczby.
        int[] T = new int[5];
        bool isFilled = false;
        while (true)
        {
            try
            {
                if (!isFilled)
                {
                    Console.WriteLine("Podaj liczby do zapisania w tablicy (albo q żeby wyjść):");
                    while (true)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write($"Podaj {i + 1} liczbę: ");
                            string rawNumber = Console.ReadLine() ?? "";
                            if (rawNumber.ToLower() == "q") return;
                            if (!int.TryParse(rawNumber, out int number)) throw new FormatException();
                            T[i] = number;
                        }
                        isFilled = true;
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                    }
                }
                if (isFilled)
                {
                    Console.WriteLine("Brawo! Poprawnie uzupełniłeś tablice, teraz możesz ją podejżyć podając indeks od 0 do 4 (albo q żeby wyjść):");
                    while (true)
                    {
                        Console.Write("Podaj jakiś indeks: ");
                        string rawIndex = Console.ReadLine() ?? "";
                        if (rawIndex == "q") return;
                        if (!int.TryParse(rawIndex, out int index)) throw new FormatException();
                        if (index < 0 || index > 4) throw new ArgumentOutOfRangeException();
                        Console.WriteLine($"Pod indeksem {index} kryje się liczba {T[index]}");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Twoja liczba nie jest liczbą albo nie mieści się w zakresie 'int32', spróbój ponownie ...");
                Thread.Sleep(1500);
                Console.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Indeks jest nieodpowiedni (za duży albo za mały) podaj liczbę w zakresie 0-4");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }
    }
}