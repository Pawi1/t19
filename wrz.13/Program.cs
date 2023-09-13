using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
int Nwd(int a,int b)
{
    while(b>0)
    {
        int c = b;
        b = a%c;
        a = c;    
    }
    return a;
}
int Nww(int a,int b)
{
    return(a*b/Nwd(a,b));
}
// // 1. User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.
// int a,b;
// Console.Write("Podaj nwd: ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Podaj nww: ");
// b = Convert.ToInt32(Console.ReadLine());

// // force
// for (int i = 1; i < 1000; i++)
// {
//     for (int j = 1; j < 1000; j++)
//     {
//        if(Nwd(i,j)==a && Nww(i,j) ==b) 
//        {
//         Console.WriteLine("a: "+i+" b: "+j);
//        }
//     }
// }

// // iloczyn nwd*nwd
// int iloczyn = a*b;
// for(int i = 1; i<= iloczyn;i++)
// {
//     if(iloczyn%i==0 && Nwd(i,iloczyn/i) == a && Nww(i,iloczyn/i) == b && i <iloczyn)
//     Console.WriteLine(i+" "+iloczyn/i);
// }

// // 2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.
// Console.Write("2.\n?/b c/d: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("a/? c/d: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("\na/b ?/d: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write("a/b c/?: ");
// int d = Convert.ToInt32(Console.ReadLine());

// int mianownik = Nww(b,d);
// int licz1 = mianownik * a/b;
// int licz2 = mianownik * c/d;
// if(licz1+licz2>mianownik) Console.WriteLine("tak"); else Console.WriteLine("nie");

//TODO 4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek. (nie działa)
// char[] Samogloski = {'a','e','i','o','u','y'};
// string napis = Console.ReadLine().ToLower();
// int ilosc = 0;
// for(int i = 0;i<6;i++)
// {
//     if(napis.Contains(Samogloski[i]))
//     ilosc++;
//     else
//     --ilosc;
// }
// if(ilosc>0) Console.WriteLine("Więcej samogłosek");
// else Console.WriteLine("Więcej współgłosek");

// 5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.
// 6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby.

// 7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
// Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
// i lecąc z jednakową prędkością przybywają w tym samym czasie. 
// Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

// 8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
// a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb, 
// które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
// Napisz program, który pomaga w takich obliczeniach.

// 9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody, 
// zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład, 
// jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
// będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4. Masz dane wszystkie liczby, które Halinka wypowiedziała 
// podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

// 10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował
// przechadzających się ludzi.
// W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
// obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
// znaleźć sobie miejsce na ławce.
// Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
// Jaka jest minimalna, a jaka maksymalna wartość k?
int l1 = Convert.ToInt32(Console.ReadLine());
int l2 = Convert.ToInt32(Console.ReadLine());
int l3 = Convert.ToInt32(Console.ReadLine());
// 6 4 4
// 8

// 6 3 4
// 8

// 6 11 4

int m = Convert.ToInt32(Console.ReadLine());
int maxK = 0;
if (l1>l2 && l1>l2)maxK = l1;
if (l2>l1 && l2>l3)maxK = l2;
if (l3>l1 && l3>l2)maxK = l3;
int k1 = maxK + m;
Console.WriteLine("max k:"+k1);

double minK = (l1+l2+l3+m)/3;
int k2 = Convert.ToInt32(Math.Ceiling(minK));
Console.WriteLine("min k:"+k2);


