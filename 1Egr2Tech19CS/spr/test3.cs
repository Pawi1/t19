using System;
using System.Collections;
Random r = new Random();
// // Zad 1
// int k = Convert.ToInt32(Console.ReadLine());
// ArrayList A = new ArrayList();

// // Zad 2
// int[] Y = new int[20];
// for (int i = 0; i < 20; i++)
// {   
//     Y[i] = r.Next(10,99);
//     Console.Write(Y[i] + " ");
//     Console.WriteLine((Y[i]/10)*10);
//     Y[i] = (Y[i]/10)*10;
    
// }
// Zad 3
int[] U = new int[90];
ArrayList C = new ArrayList();
for (int i = 0; i < 90; i++)
{
    U[i] = r.Next(10,99);
    if(!(C.Contains(U[i]))) C.Add(U[i]);

}
Console.WriteLine($"Jest {C.Count}, a nie ma {90-C.Count}");

// // Zad 4
// int[,] M = new int[16,16];
// int sum = 0;
// for (int i = 0; i < 16; i++)
// {
//     for (int j = 0; j < 16; j++)
//     {
//         M[i,j] = r.Next(100,999);
//         if (DajPier(M[i,j]) == true) sum += M[i,j]; 
//     }
// }
// Console.WriteLine(sum);

// // funkcje
// bool DajPier(int x){
//     for (int i = 2; i < x; i++)
//     {
//         if(x%i == 0) return false;
//     }
//     return true;
// }