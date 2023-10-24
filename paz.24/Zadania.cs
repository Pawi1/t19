namespace paz._24;
public class Zadania
{
    public static void Zadanie1()
    {
        Start:
        try
        {
            Console.Clear();
            Console.Write("Podaj dwie liczby\nPodaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b == 0) throw new DivideByZeroException("Próbujesz podzielić przez 0");
            Console.WriteLine($"Wynik dzielenia {a}/{b} to {a / b:F3}");
        }
        catch (FormatException)
        {
            Console.Write("Błąd: Podaj liczbe zmiennoprzecinkową lub całkowitą ...");
            Thread.Sleep(1500);
            goto Start;
        }
        catch (DivideByZeroException)
        {
            Console.Write("Błąd: Próbujesz dzielić przez 0 ...");
            Thread.Sleep(1500);
            goto Start;
        }
        catch (OverflowException)
        {
            Console.Write("Błąd: Błędny zakres liczby ...");
            Thread.Sleep(1500);
            goto Start;
        }
        catch (Exception ex)
        {
            Console.Write($"Błąd: {ex.Message} ...");
            Thread.Sleep(1500);
            goto Start;
        }
    }
}