using System;
// 1. User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.
int a,b;
Console.Write("Podaj nwd: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj nww: ");
b = Convert.ToInt32(Console.ReadLine());

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

for (int i = 1; i < 1000; i++)
{
    for (int j = 1; j < 1000; j++)
    {
       if(Nwd(i,j)==a && Nww(i,j) ==b) 
       {
        Console.WriteLine("a: "+i+" b: "+j);
       }
    }
}

// 2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.
Console.Write("2.\ng1: ");
int gora1 = Convert.ToInt32(Console.ReadLine());
Console.Write("d1: ");
int dol1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\ng1: ");
int gora2 = Convert.ToInt32(Console.ReadLine());
Console.Write("d1: ");
int dol2 = Convert.ToInt32(Console.ReadLine());
