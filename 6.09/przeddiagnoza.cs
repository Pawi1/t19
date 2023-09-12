using System;
// Napisz i przetestuj algorytm Euklidesa odejmowanie
int Odejmow(int a,int b)
{
    while(a!=b)
    {
        if(a>b)a-=b;
        else b-=a;
    }
    return a;
}
Console.WriteLine(Odejmow(24,18));
// Napisz i przetestuj algorytm Euklidesa modulo
int Modulo(int a,int b)
{
    while(b>0)
    {
        int c = b;
        b = a%c;
        a = c;
    }
    return a;
}
Console.WriteLine(Modulo(24,18));

// Napisz i przetestuj algorytm sortowania bąbelkowego na tablicy
// Wypisz wszystkie pary liczb zaprzyjaźnionych z przedziały 1-10.000
// Listy - Tablice - w tablicy 30 losowych liczb trzycyfrowych znajdź ilość wielokrotności liczb 17 (wynik do listy)
// Macierz cyfr - wypisz sumy kolejnych ramek w macierzy kwadratowej