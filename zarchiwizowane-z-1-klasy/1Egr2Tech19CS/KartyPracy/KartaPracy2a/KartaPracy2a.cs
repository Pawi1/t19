using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2a
{
    internal class Program
    {
    static void Main(string[] args)
        {
            Zadanie1(); Zadanie2(); Zadanie3(); Zadanie4(); Zadanie5(); Zadanie6();
        }
    static void Zadanie1()
        {
            System.Console.WriteLine("Zadanie 1: (easy) Sprawdź czy suma dwóch wpisanych przez użytkownika jest liczbą parzystą");
            System.Console.Write("Wpisz liczbę a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę b: ");
            int b = int.Parse(Console.ReadLine());
            
            
            if ((a+b)%2==0)
            {
                System.Console.WriteLine($"Suma liczb {a} i {b} jest parzysta");
            }
            else
            {
                System.Console.WriteLine($"Suma liczb {a} i {b} nie jest parzysta");
            }
            System.Console.Write("Naciśnij dowolny klawisz aby rozpocząć kolejne zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    static void Zadanie2()
        {
            System.Console.WriteLine("Zadanie 2: (easy) Sprawdź, czy średnia arytmetyczna dwóch wpisanych liczb jest wieksza od jej średniej geometrycznej.");
            System.Console.Write("Wpisz liczbe a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbe b: ");
            int b = int.Parse(Console.ReadLine());
            double ary = (a+b)/2;
            double geo = Math.Sqrt(a*b);

            if (ary>geo)
            {
                System.Console.WriteLine("Średnia arytmetyczna jest większa od średniej geometrycznej");
            }
            else if (ary<geo)
            {
                System.Console.WriteLine("Średnia arytmetyczna jest mniejsza od średniej geometrycznej");
            }
            else 
            {
                System.Console.WriteLine("Średnia arytmetyczna jest równa średniej geometrycznej");
            }
            System.Console.Write("Naciśnij dowolny klawisz aby rozpocząć kolejne zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    static void Zadanie3()
        {
            System.Console.WriteLine("Zadanie 3: (easy) Użytkownik podaje 3 liczby całkowite. Sprawdź czy dokładnie dwie z nich są sobie równe");
            System.Console.Write("Wpisz liczbę a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę b: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę c: ");
            int c = int.Parse(Console.ReadLine());
            
            if (a==b && !(a==c) && !(b==c))
            {
                System.Console.WriteLine("Tylko liczby a i b są siebie równe");
            }
            else if (a==c && !(a==b) && !(b==c))
            {
                System.Console.WriteLine("Tylko liczby a i c są siebie równe");
            }
             else if (b==c && !(a==c) && !(a==b))
            {
                System.Console.WriteLine("Tylko liczby c i b są siebie równe");
            }
            else
            {
                System.Console.WriteLine("W tym zbiorze żadna z liczb nie spełnia warunku");
            }

            System.Console.Write("Naciśnij dowolny klawisz aby rozpocząć kolejne zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    static void Zadanie4()
        {
            System.Console.WriteLine("Zadanie 4: (medium) Niech użytkownik wprowadzi 4 różne liczby całkowite. Napisz program, który sprawdzi, która z tych liczb jest najmniejsza");
            System.Console.Write("Wpisz liczbę a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę b: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę c: ");
            int c = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę d: ");
            int d = int.Parse(Console.ReadLine());
            
            if (a<b && a<c && a<d)
            {
                System.Console.WriteLine("Liczba A jest najmniejsza");
            }
            else if (b<a && b<c && b<d)
            {
                System.Console.WriteLine("Liczba B jest najmniejsza");
            }
             else if (c<a && c<b && c<d)
            {
                System.Console.WriteLine("Liczba C jest najmniejsza");
            }
              else if (d<a && d<b && d<c)
            {
                System.Console.WriteLine("Liczba D jest najmniejsza");
            }
            else 
            {
                System.Console.WriteLine("Użytkownik nie wprowadził różnych cyfr");
            }
            
            System.Console.Write("Naciśnij dowolny klawisz aby rozpocząć kolejne zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    static void Zadanie5()
        {
            System.Console.WriteLine("Zadanie 5: Sprawdź czy trzy wprowadzone przez użytkownika liczby spełniają nierówność trójkąta");
            System.Console.Write("Wpisz liczbę a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę b: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write("Wpisz liczbę c: ");
            int c = int.Parse(Console.ReadLine());

            if (a+b>=c || c+b>=a || a+c>=b)
            {
                System.Console.WriteLine("Liczby spełniają nierówność trójkąta");
            }            
            else
            {
                System.Console.WriteLine("Liczby nie spełniają nierówność trójkąta");
            }
            
            System.Console.Write("Naciśnij dowolny klawisz aby rozpocząć kolejne zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    static void Zadanie6()
        {
            System.Console.WriteLine("Zadanie 6 : (medium) Niech z trzech wprowadzonych przez użytkwnika liczbach da się zbudować trójąt. Sprawdź czy ten trójką jest ostrokątny, prostokątny czy rozwartokątny");
            System.Console.Write("Podaj kąt przy wierzchołku A: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Podaj kąt przy wierzchołku B: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.Write("Podaj kąt przy wierzchołku C: ");
            int c = int.Parse(Console.ReadLine());
           
          if ((a < 90 && b < 90 && c < 90) && a+b+c == 180)
          {
            System.Console.WriteLine("Z danych kątów da się zrobić trójkąt ostrokątny");
          }
          else if (((a == 90  && ( b < 90 && c < 90)) || (b == 90  && ( a < 90 && c < 90)) || (c == 90  && ( b < 90 && a < 90))) && a+b+c == 180)
          {
            System.Console.WriteLine("Z danych kątów da się zrobić trójkąt prostokątny");
          }
          else if (((a > 90  && ( b < 90 && c < 90)) || (b > 90  && ( a < 90 && c < 90)) || (c > 90  && ( b < 90 && a < 90))) && a+b+c == 180)
          {
            System.Console.WriteLine("Z danych kątów da się zrobić trójkąt rozwartokątny");
          }
          else 
          {
            System.Console.WriteLine("Z danych kątów nie da się zrobić trójkąta");
          }
        }
    }   
}