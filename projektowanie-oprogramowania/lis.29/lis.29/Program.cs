int j;
// Zad 3. Napisz alg sumujący cyfry iter i reku
j = 0;
for (int i = 0; i <= 9; i++)
{
    j += i;
}
Console.WriteLine(j);

int reku3(int n)
{
    if (n == 0) return n;
    n += reku3(n-1);
    return n;
}
Console.WriteLine(reku3(9)+"\n");

// 4. Napisz alg sumujący liczby dwucyfrowe parzyste iter i reku
j = 0;
for (int i = 10; i <= 98; i += 2)
{
    j += i;
}

int reku4(int n)
{
    if (n == 10) return n;
    n += reku4(n - 2);
    return n;
}
Console.WriteLine(j);
Console.WriteLine(reku4(98) + "\n");

// 5. Oblicz sumę n pierwszych wyrazów ciągów:

// a) 3, 6, 9, 12, 15, 18, 21 ... <=> 3+6+9+12 = 3(1+2+3+4)

int reku5(int n)
{
    if (n == 1) return 3;
    return reku5(n-1) + n*3;
}
Console.WriteLine(reku5(4)+"\n");

// b) 12, 23, 34, 45, 54 ...

j = 0;
int reku6(int n)
{
    if (n == 1) return 12;
    return reku6(n - 1) + 11;
}

for (int i = 1; i <= 3; i++)
{
    j += reku6(i);
}
Console.WriteLine(j+"/n");

// d) 1, 2, 4, 9, 16 ...
j = 0;

int reku7(int n)
{
    if (n == 1) return 1;
    return reku7(n - 1) + 2 * (n - 1) + 1;
}
for (int i = 1; i <= 4; i++)
{
    j += reku6(i);
}
Console.WriteLine(j);
