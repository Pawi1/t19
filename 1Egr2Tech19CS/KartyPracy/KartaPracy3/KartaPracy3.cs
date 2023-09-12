using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie  1
            Console.WriteLine("Zadanie 1: Program, który wypisze ciąg sześcianów liczb naturalnych powiększonych o 3");
            Console.Write("Wpisz liczbę: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(i, 3) + 3 + " ");

            }

            // Zadanie 2 
            Console.WriteLine("Zadanie 2: Program, który wypisze wszytkie liczby trzycyfrowe podzielne przez 15");

            for (int i = 115; i <= 1000; i += 15)
            {
                Console.WriteLine($"{i}");
            }

            // Zadanie 3
            Console.WriteLine("Zadanie 3: Program, który wypisze wszyskie dzielniki podanej liczby n");

            Console.Write("Wpisz liczbę: ");
            int p = int.Parse(Console.ReadLine());

            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0)
                {
                    Console.WriteLine($"{i}");
                }

            }

            // Zadanie 4
            Console.WriteLine("Zadanie 4: Program, który obliczy sumę liczb dwucyfrowych");
            int suma = 0;
            for (int i = 10; i < 100; i++)
            {
                suma = suma + i;  
            }
            Console.WriteLine(suma);

            // Zadanie 5
            Console.WriteLine("Zadanie 5: Bajtuś postanowił zrobić dla swoich kolegów pewną zagadkę. Zagadka polega na tym, że koledzy\r\nnajpierw podają liczbę naturalną n. Następnie Bajtuś wybiera sobie liczbę x, taką, że 0 < x < n oraz\r\nwypisuje n − 1 różnych, mniejszych on n liczb pomijając przy tym swoje tajemnicze x. Napisz program,\r\nktóry pozwoli sprawdzić, jaką liczbę x wybrał sobie Bajtuś");
            Console.Write("Podaj liczbę n: ");
            n = int.Parse(Console.ReadLine());
            suma = n * (n + 1) / 2;

            for (int i = 1;i <n-1 ; i++)
            {
                Console.WriteLine($"Podaj {i} liczbę:");
                int x = int.Parse(Console.ReadLine());
                suma = suma - x;
            }
            Console.WriteLine($"Liczba której nie podałeś to {suma}");


            // Zadanie 6
            Console.WriteLine("Zadanie 6: Napisz program według wyjścia poniżej (ciąg Fibonacciego)");
            n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp;
            
            for (int i = 0; i < n - 1; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(b+ "");
            }
        }
    }
}
