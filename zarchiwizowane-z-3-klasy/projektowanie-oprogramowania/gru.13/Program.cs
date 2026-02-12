//1. napisz iteracyjnie i rekurencyjnie obliczenia sumy kodów ASCII wpisanego przez usera słowa
// 'A' to int = xy
int sum = 0;
string s = "ABC";
for(int i = 0;i<s.Length;i++)
{
    sum+=s[i];
}
Console.WriteLine(sum);

int reku1(string inp)
{
    if (inp == "") return 0;
    return reku1(inp.Substring(1)) + inp[0];
}
Console.WriteLine(reku1(s));

int reku2(int x,int n)
{
    if (n == 0) return 1;
    return reku2(x, n - 1) * x;
}
Console.WriteLine(reku2(2,6));

int euk(int a, int b)
{
    while (a!=b)
    {
        if (a > b) a -= b;
        if (b > a) b -= a;
    }
    return a;
}

void rekeuk(int a, int b)
{
    if (a == b) {Console.WriteLine(a); return;}
    if (a > b) rekeuk(a - b, b);
    else rekeuk(a, b-a);
}
Console.WriteLine(euk(16,20));
rekeuk(16,20);
int rekeuk2(int a, int b)
{
    if (a > b) return rekeuk2(a - b, b);
    if (a < b) return rekeuk2(a, b-a);
    return a;
}
Console.WriteLine(rekeuk2(16,20));