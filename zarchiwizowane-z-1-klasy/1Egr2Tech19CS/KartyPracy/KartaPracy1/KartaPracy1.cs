using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Wpisz liczbę a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a*a+b*b);

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Wpisz liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow((a+b),2));

            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Wpisz liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow((a - b), 3));


            Console.WriteLine("Zadanie 4");
            Console.WriteLine("Wpisz liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę b");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a*b*c);


            Console.WriteLine("Zadanie 5");
            Console.WriteLine("Wpisz liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(2*(a+b)/5);


            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Wpisz brutto");
            double brutto = int.Parse(Console.ReadLine());

            Console.WriteLine(b / 1.23);

            Console.WriteLine("Zadanie 7");
            Console.WriteLine("Wpisz liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz liczbę b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a%b);
        }
    }
}
