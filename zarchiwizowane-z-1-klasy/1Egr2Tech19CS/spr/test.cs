using System;
namespace test{
    class Tablice{
        public static void Main(string[] args){
          Random r = new Random();
          // 1. Wygeneruj tablice z 15 losowymi liczbami dwucfrowymi nieparzystymi
          // int[] T1 = new int[15];
          // for (int i = 0, temp = r.Next(100); i < 15; i++)
          // {
          //   if(temp%2!=0)
          //   {
          //     T1[i] = temp;
          //     Console.Write($"{T1[i]} ");
          //   }
          //   else i--;  
          // }
          
          // 2. Wygeneruj tablice 20 dowolnych liczb dwucyfryowych i potem zaokrąglij każdą w góre do pełnej 10-tki
          double[] T2 = new double[20];
          for (int i = 0; i < 20; i++) {
            T2[i] = Convert.ToDouble(r.Next(100));
            Console.Write($"{T2[i]} \t");
            T2[i] = Math.Round(T2[i]/10,MidpointRounding.ToPositiveInfinity)*10;
            Console.Write($"{T2[i]} \n");
            }
          
          // 3. Wygeneruj listę 12 losowych liczb dwucyfrowych podzielnych przez 7
          // int[] T3 = new int[12];
          // for (int i = 0, temp = r.Next(100); i < 15; i++)
          // {
          //   if(temp%7!=0)
          //   {
          //     T3[i] = temp;
          //     Console.Write($"{T3[i]} ");
          //   }
          //   else i--;  
          // }
        }
    }
}