/*
Wygeneruj tablicę n losowych liczb:
Random r = new Random()
r.Next(pocz, kon)
1. Znajdź największą liczbę w tablicy
2. Znajdź najmniejszą liczbę w tablicy
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy
5. Podaj rozpiętość tablicy (różnica max - min)
6. Podaj sumę liczb w tablicy
7. Podaj średnią wartość liczb w tablicy
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy
*/
using System;
int n = 10;
int pocz = 1;
int kon = 20;
int max = pocz;
int min = kon;
int maxIlosc = 0;
int minIlosc = 0;
int suma = 0;
int iloscParzyste = 0;
int iloscNieParzyste = 0;
int iloscLiczPierwszych = 0;
int vcemax = 0;
int vcemin = 0;
int[] T = new int[n];
Random r = new Random();
for (int i = 0; i<n;i++){
    T[i]= r.Next(pocz,kon);
}
for (int i = 0; i < n;i++)
{
    Console.Write($"{T[i]} ");
}
// // // // // // //
// 1
for (int i = 0; i < n; i++){
    if(T[i] > max){
    max = T[i]; 
    }
}
Console.WriteLine($"\n\n1.Największa liczba to: {max}");
// 2
for (int i = 0; i < n; i++)
{
    if (T[i]< min){
        min = T[i];
    }
}
Console.WriteLine($"2.Najmniejsza liczba to: {min}");
// 3
max = pocz;
min = kon;
for (int i = 0; i < n; i++){
    if(T[i] > max){
    max = T[i]; 
    }
}
for (int i = 0; i < n; i++){
    if (T[i] == max) maxIlosc++;
}
Console.WriteLine($"3.Największa liczba występuje: {maxIlosc}");
// 4
max = pocz;
min = kon;
for (int i = 0; i < n; i++){
    if(T[i] < min){
    min = T[i];
    }
}
for (int i = 0; i < n; i++){
    if (T[i] == min) minIlosc++;
}
Console.WriteLine($"4.Najmniejsza liczba występuje: {minIlosc}");
// 5
max = pocz;
min = kon;
for (int i = 0; i < n; i++){
    if(T[i] > max){
    max = T[i]; 
    }
    if (T[i]< min){
    min = T[i];
    }
}
Console.WriteLine($"5.Rozpiętość tablicy to : {max - min}");
// 6
for (int i = 0; i < n;i++)
{
    suma+=T[i];
}
Console.WriteLine($"6.Suma liczb to: {suma}");
// 7
for (int i = 0; i < n;i++)
{
    suma+=T[i];
}
Console.WriteLine($"7.Średnia liczb to {suma/n}");
// 8
for (int i = 0; i < n;i++)
{
    if(T[i]%2==0)iloscParzyste++;
    if(T[i]%2!=0)iloscNieParzyste++;
}
if(iloscNieParzyste<iloscParzyste) Console.WriteLine($"8.Więcej jest liczb parzystych");
else 
    if(iloscNieParzyste>iloscParzyste) Console.WriteLine($"8.Więcej jest liczb nieparzystych");
else 
    Console.WriteLine("8.Jest tyle samo liczb parzystych i nieparzystych");
// 9
for (int i = 0; i < n;i++)
{
        if (T[i]==2) iloscLiczPierwszych++;
   else if (T[i]==3) iloscLiczPierwszych++;
   else if (T[i]==5) iloscLiczPierwszych++;
   else if (T[i]==7) iloscLiczPierwszych++;
   else if (T[i]==11)iloscLiczPierwszych++;
   else if (T[i]==13)iloscLiczPierwszych++;
   else if (T[i]==17)iloscLiczPierwszych++;
   else if (T[i]==19)iloscLiczPierwszych++;
}
Console.WriteLine($"9.W zbiorze jest {iloscLiczPierwszych} liczb pierwszych");
// 10
max = pocz;
min = kon;

for (int i = 0; i < n; i++){
    if(T[i] > max){
    vcemax = max;
    max = T[i]; 
    }
    if (T[i]< min){
    vcemin = min;
    min = T[i];
    }
}
Console.WriteLine($"10.Liczbą v-ce max jest {vcemax}, a liczbą v-ce min jest {vcemin}");