using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Console.Write("Wpisz a: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 3 == 0)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }

            Console.WriteLine("Zadanie 2");
            Console.Write("Wpisz a: ");
            a = int.Parse(Console.ReadLine());

            if (a < 1000 && a > 99 && a % 17 == 0)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }

            Console.WriteLine("Zadanie 3");
            Console.Write("Wpisz wiek: ");
            a = int.Parse(Console.ReadLine());
            if (a < 18)
            {
                Console.WriteLine("Jesteś niepełnoletni");

            }
            else
            {
                Console.WriteLine("Jesteś pełnoletni");
            }


            Console.WriteLine("Zadanie 4");
            Console.Write("Wpisz wagę: ");
            a = int.Parse(Console.ReadLine());
            if (a > 20)
            {
                Console.WriteLine("Nie możesz wjechać");
            }
            else
            {
                Console.WriteLine("Możesz śmiało wjechać");
            }

            Console.WriteLine("Zadanie 5");
            Console.Write("Wpisz liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Wpisz liczbę b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Wpisz liczbę c: ");
            int c = int.Parse(Console.ReadLine());

            if ((a < c && b > c) || (b < c && a > c))
            {
                Console.WriteLine("Mieści się");
            }
            else
            {
                Console.WriteLine("Nie mieści się");
            }

            Console.WriteLine("Zadanie 5");
            Console.Write("Podaj dowolną liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę pierwszą: ");
            int p = int.Parse(Console.ReadLine());

            if ((Math.Pow(a, p) - a) % p == 0)
            {
                Console.WriteLine("Spełnia");
            }
            else
            {
                Console.WriteLine("Nie Spełnia");
            }


            Console.WriteLine("Zadanie 7");
            Console.Write("Podaj długość skoku: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Podaj punkt startu: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Podaj punkt końcowy: ");
            int k = int.Parse(Console.ReadLine());
            if (3 * s + p >= k)

            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }
        }
    }
}
