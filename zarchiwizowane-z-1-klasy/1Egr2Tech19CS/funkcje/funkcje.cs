using System;
using System.Collections.Generic;

int kalc(int a, int b)
{
    return a + b;
}
Console.WriteLine (kalc(1, 2));

string rev(string s)
{
    char[] chars = s.ToCharArray();
    Array.Reverse (chars);
    return new string(chars);
}
Console.WriteLine(rev("asdas"));

int f1(int[] T)
{
    int s = 0;
    foreach (int i in T) s += i;
    return s;
}
Console.WriteLine(f1(new int[] { 1, 2, 3, 4 }));

int f2(params int[] T)
{
    int s = 0;
    foreach (int i in T) s += i;
    return s;
}
Console.WriteLine(f2(1,2,3,4));

void f3(int n)
{
    if (n == 0) return;
    f3(n - 1);
    Console.WriteLine(n);
}
f3(5);

void f4(int n)
{ 
    if (n == 0) return;
    Console.WriteLine(n);
    f4(n - 1);
    Console.WriteLine(n);
}
f4(5);
