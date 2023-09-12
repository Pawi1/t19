using System;
int Zad11(int a)
    {
        int suma = 0;
        while(a>0)
            {
                suma += a%10;
                a = a/10;
            } 
        return suma;
    }

string Zad12(string a)
    {
        char[] charArray = a.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

void Zad13(int a)
    {   System.Console.Write(a + " ");
        while(a>1)
            {
                a = a/2;
                System.Console.Write(a + " ");
            }
    }

// int Zad21(int n)
//     {
//         if(n==1)return 1;
//         int w = Zad21(n-2);
//         System.Console.WriteLine(n);
//         return w;
//     }

int Zad21(int n)
    {
        if(n == 1)
            return 3;
        return Zad21(n-1)+2;
    }

int Zad22(int n)
    {
        if(n == 1)
            return 2;
        return Zad21(n-1)*2;
    }
// int Zad22(int n)
//     {
//         if(n<6) return 6;
//         int w = Zad22(n/2);
//         System.Console.WriteLine(n);
//         return w;
//     }
// int 

for (int i = 1; i <= 10; i++)
    System.Console.WriteLine(Zad21(i));

for (int i = 1; i <= 10; i++)
    System.Console.WriteLine(Zad22(i));



int Zad23(int n)
    {
        if (n == 1 || n == 2)
            return 1;
        else
            return Sequence(n-1) + 2 * Sequence(n-2);
        
    }
for (int i = 1; i <= 10; i++)    
    Console.WriteLine(Sequence(i));
        

