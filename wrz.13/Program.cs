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

// 4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.
char[] Samogloski = {'a','e','i','o','u','y'};
string napis = Console.ReadLine().ToLower();
int ilosc = 0;
for(int i = 0;i<6;i++)
{
    if(napis.Contains(Samogloski[i]))
    ilosc++;
    else
    --ilosc;
}
if(ilosc>0) Console.WriteLine("Więcej samogłosek");
else Console.WriteLine("Więcej współgłosek");
