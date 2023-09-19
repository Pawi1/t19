using System;
namespace wrz._19;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Pierwszy program");
        Console.Write("w języku C#: ");
        byte i = 10;
        Console.Write("\nZmianna \"i\" wynosi: {0}",i);
        // Typy danych:
        //  byte - int8 bez ujemnych
        // sbyte - int8
        // short - int16
        //   int - int32
        Console.Write("\n"); Console.ReadKey();
    }
}
