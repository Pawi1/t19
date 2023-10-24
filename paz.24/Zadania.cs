namespace paz._24;
public class Zadania
{
    public static void Zadanie1()
    {
        while (true)
        {
            try
            {
                Console.Clear();
                Console.Write("Podaj dwie liczby które chcesz podzielić\nPodaj a: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj b: ");
                double b = Convert.ToInt32(Console.ReadLine());
                if (b == 0) throw new DivideByZeroException("Próbujesz podzielić przez 0");
                Console.Write($"\nWynik dzielenia {a}/{b} to: ");
                ChangeConsoleColor($"{a / b:F3}",ConsoleColor.Green);
                break;
            }
            catch (FormatException)
            {
                ChangeConsoleColor("\nBłąd: Podaj liczbe zmiennoprzecinkową lub całkowitą ...",ConsoleColor.Red);
                Thread.Sleep(1500);
            }
            catch (DivideByZeroException)
            {
                ChangeConsoleColor("\nBłąd: Próbujesz dzielić przez 0 ...",ConsoleColor.Red);
                Thread.Sleep(1500);
            }
            catch (OverflowException)
            {
                ChangeConsoleColor("\nBłąd: Błędny zakres liczby ...",ConsoleColor.Red);
                Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                ChangeConsoleColor($"\nBłąd: {ex.Message} ...",ConsoleColor.Red);
                Thread.Sleep(1500);
            }
        }
    }
    public static void ChangeConsoleColor(string write,ConsoleColor consolecolor)
    {
        Console.ForegroundColor = consolecolor;
        Console.Write(write);
        Console.ResetColor();
    }
}