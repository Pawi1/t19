// z1
using System.Collections;

int[] tab = new int[115];
tab[0] = 3;
for(int i = 1;i<tab.Length;i++)
{
    tab[i] = tab[i-1] + 4;
}
// z2
StreamReader sr = new(AppDomain.CurrentDomain.BaseDirectory+"osoby.txt");
string[] linia;
Osoba[] Osoby = new Osoba[5];
int licznik = 0;
while(!sr.EndOfStream)
{
    linia = sr.ReadLine().Split(";");
    Osoba os;
    os.imie = linia[0];
    os.nazwisko = linia[1];
    os.wiek = linia[2];
    Osoby[licznik++] = os;
}
sr.Close();
foreach(var item in Osoby)
{
    Console.WriteLine("{0} {1} {2}",item.imie,item.nazwisko,item.wiek);
}
// z3
List<char> samogloski = ['a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'y'];
// List<char> samogloski = ['a', 'e', 'i', 'o', 'u', 'y'];
List<string> wyrazy = [];
Random random = new ();
while(!(wyrazy.Count == 3))
{
    string w = "";
    List<char> samo = new(samogloski);
    for(int j = 0; j<3;j++)
    {
        int r = random.Next(samo.Count);
        w += samo[r];
        samo.Remove(samo[r]);
    }
    wyrazy.Add(w);
}
Console.WriteLine();
foreach(var item in wyrazy)
{
    Console.WriteLine(item);
}
Console.WriteLine();
// z4
List<int> fiboList = [];
int fibo(int n)
{
    if(n==1) return 1;
    if(n==2) return 2;
    return fibo(n-1)+ fibo(n-2);
}
for(int i = 1; fibo(i)<100;i++)
{
    fiboList.Add(fibo(i));
}
Queue queue = new();
for(int i=0;i<4;i++)
{
    queue.Enqueue(fiboList[random.Next(fiboList.Count)]);
}
foreach(var item in queue)
{
    Console.WriteLine(item);
}
queue.Dequeue(); queue.Dequeue();
Console.WriteLine();
foreach(var item in queue)
{
    Console.WriteLine(item);
}
Console.WriteLine();
// z5
Stack stack = new();
int[] pierwsze = [11,13,17,19,23];
for(int i = 0;i<5;i++)
{
    stack.Push(pierwsze[i]);
}
foreach(var item in stack)
{
    Console.WriteLine(item);
}
stack.Pop(); stack.Pop(); stack.Pop();
Console.WriteLine();
foreach(var item in stack)
{
    Console.WriteLine(item);
}
// Struct
struct  Osoba
{
    public string imie;
    public string nazwisko;
    public string wiek;
}