/*
1. Wpisz do tablicy T 5 losowych liczb dwucyfrowych. Stwórz tablicę W liczb parzystych znajdujących się między 
minimalną i maksymalną wartością z tablicy T.

2. Utwóz ArrayListę A zawierającą 10 losowych słów 3-literowych. 
Wypisz słowo o najwiekszej sumie kodów ASCII jego liter

3. Stwórz listę L składającą się z list 10 losowych cyfr. Oblicz sumę maksymalnych cyfr w listach listy L oraz 
sprawdź czy istnieje taka lista gdzie wylosowano 3 identyczne cyfry.

4. Stwórz słownik D kluczami i = 1, 2, 3 ... n (user podaje n) oraz wartościami 
   i-cyfrowych dzielników każdego kluczy.

5. Korzystając ze słownika utwórz graf G zbudowany z n wierzchołków i k krawędzi. 
Policz wierzchołki nie mające żadnych sąsiadów.
*/
// z 1
using System.Collections;
using System.ComponentModel;
Random random = new();

// int[] T = new int[5];
// for(int i = 0; i<5 ;i++)
// {
//     T[i] = random.Next(10,100);
//     Console.Write(T[i]+" ");
// }
// Console.WriteLine();
// int c = (T.Max()-T.Min())/2;
// int[] W = new int[c];
// for(int i = T.Min()+1, j = 0; j<c;j++,i++)
// {
//    if(i%2==0) W[j] = i;
//    else j--;
// }
// foreach(var i in W)
// {
//     Console.Write(i+" ");
// }

// z 2
// const string alfabet = "abcdefghijklmnoprstuwyz";
// ArrayList A = new();
// int[] Maxi = new int[2]; Array.Fill(Maxi,-1);
// for(int i = 0; i<10;i++)
// {
//     string wyraz = "";
//     int suma = 0;
//     for(int j = 0; j<3;j++)
//     {
//         wyraz += alfabet[random.Next(alfabet.Length)];
//         suma += wyraz[^1];
//     }
//     A.Add(wyraz);
//     Console.WriteLine(suma + " "+ wyraz);
//     if(Maxi[0] < suma)
//     {
//         Maxi[0] = suma;
//         Maxi[1] = i;
//     }
// }
// Console.WriteLine("Największy jest " + Maxi[0]+ " czyli "+ A[Maxi[1]]);

// z 4
Dictionary<int,List<int>> Slownik = new();
// int n = int.Parse(Console.ReadLine()!);
int n = 8;
for(int i = 1;i<=n;i++)
{
    List<int> war = new();
    for(int j= 1; j < Math.Pow(10,i-1); j++)
    {
        if(Math.Pow(10,i) % j == 0) war.Add(j);
    }
    Console.Write(i+"=> "+string.Join(' ', war));
    Console.WriteLine();
    Slownik.Add(i,war);
}
