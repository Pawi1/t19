using System.Runtime.InteropServices;

namespace wrz._19;
class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();
        // Console.Write("Pierwszy program");
        // Console.Write("w języku C#: ");
        // Typy danych:
        //    byte - int8 bez ujemnych
        //   sbyte - int8
        //   short - int16
        //     int - int32
        //  ushort - short bez ujemnych
        //    uint - int32 bez ujemnuch
        //    long - int64
        //   ulong - int64 bez ujemnych
        //    bool - True/False
        //   float - 32bity
        //  double - 64bity
        // decimal - 128bity
        
        byte i1 = 10;
        long l1 = 10L;
        ulong l2 = 10LU;
        float f1 = 0.25F;

        Console.WriteLine("Zmianna \"i1\" wynosi: {0}",i1);
        Console.WriteLine("Zmianna \"l1\" wynosi: {0}",l1);
        Console.WriteLine("Zmianna \"l2\" wynosi: {0}",l2);
        Console.WriteLine("Zmianna \"f1\" wynosi: {0}",f1);
        // zapis systemów liczbowych
        Console.WriteLine(0b1011);                  //bin 1011 -> 11
        Console.WriteLine(Convert.ToByte("12",8));  //oct 12   -> 10
        Console.WriteLine(0xA1);                    //hex A1 -> 11
        // zakres typów danych
        Console.WriteLine(byte.MinValue);  // 0
        Console.WriteLine(byte.MaxValue);  // 255
        
        Console.WriteLine(sbyte.MinValue); //-128
        Console.WriteLine(sbyte.MaxValue); // 127
        
        Console.WriteLine(short.MinValue); //-32768
        Console.WriteLine(short.MaxValue); // 32767
        
        Console.WriteLine(int.MinValue);   //-2147483647
        Console.WriteLine(int.MaxValue);   // 2147483648
        
        Console.WriteLine(long.MinValue);  //-9223372036854775808
        Console.WriteLine(long.MaxValue);  // 9223372036854775807
        
      //Console.WriteLine(Int128.MaxValue);// 170141183460469231731687303715884105727 (Brak w dotnet 8)

        Console.WriteLine(float.MinValue); //-3.4028235E+38
        Console.WriteLine(float.MaxValue); // 3.4028235E+38

        Console.WriteLine(double.MinValue); //-1.7976931348623157E+308
        Console.WriteLine(double.MaxValue); // 1.7976931348623157E+308

        Console.WriteLine(decimal.MinValue); //-79228162514264337593543950335
        Console.WriteLine(decimal.MaxValue); // 79228162514264337593543950335
    }
}
