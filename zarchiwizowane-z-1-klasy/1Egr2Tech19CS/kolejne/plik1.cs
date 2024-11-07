using System;
string[] S = System.IO.File.ReadAllLines(@"Dane_PR2/pary.txt");
// L - to ma być tablica int'ów
// N - to ma być tablica string'ów
int[] L = new int[S.Length];
string[] N = new string[S.Length];
int k = 0;
foreach (string item in S)
{
    // Console.WriteLine(item);
    // string[] TE = item.Split(" ");
    // Console.WriteLine(TE[0]); // tutaj liczby 
    // Console.WriteLine(TE[1]); // tutaj słowa 

    L[k] = Convert.ToInt32((item.Split(" "))[0]);
    N[k] = (item.Split(" "))[1];
    k++;
}
bool czyPierwsza(int n)
{
    for (int i = 2; i<n;i++)
        if (n%i==0)
            return false;
    return true;
}
for (int i = 0; i < L.Length; i++)
{
    if(L[i]> 4 && L[i]% 2==0)
    {
        for (int j = 2; j < L[i]; j++)
        {
            if (czyPierwsza(j) && czyPierwsza(L[i]-j))
            {
                Console.WriteLine($"{L[i]} {j} {L[i]-j}");
                break;
            }
        }
    }
}