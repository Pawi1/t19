using System;
using System.Threading;					
static class Program
{
	public static void Main()
	{
		Zadanie1();
		Zadanie2();
        Zadanie3();
        Zadanie4();
        Zadanie5();
        Zadanie6();
        Zadanie7();
        Zadanie8();
        Zadanie9();
        Zadanie10();
    }

    static void Zadanie1()
    {
        System.Console.WriteLine("Zadanie 1: (very easy) Napisz pętle wypisujacą dni miesiąca listopada 2022 roku");
        System.Console.WriteLine("Kliknij aby wykonać...");
        Console.ReadKey();
       
        System.Console.WriteLine("\t \t [LISTOPAD 2022]"); 
        for(int i = 0;i<=30;i++)
        {
            if (i == 0) System.Console.Write("\t");
            if (!(i == 0)) System.Console.Write($"{i}\t");
            if (i == 6 || i == 13 || i == 20 || i == 27) System.Console.Write("\n");
        }
        System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
    }
    static void Zadanie2()
    {
        System.Console.WriteLine("Zadanie 2: (easy) Napisz pętle wypisujacą kwadraty cyfr nieparzystych");
        System.Console.WriteLine("Kliknij aby wykonać...");
        Console.ReadKey();   
        
     
        for(int i = 1 ;i<=1000100;i+=2)
        {
            System.Console.WriteLine(Math.Sqrt(i)+" "); 
            
        }
        System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
    }
    static void Zadanie3()
    {
        System.Console.WriteLine("Zadanie 3: (easy) Napisz pętle wypisującą liczby czterocyfrowe dzielące się przez 379");
        System.Console.WriteLine("Kliknij aby wykonać...");
        Console.ReadKey();   
        
     
        for(int i = 1000 ;i<=9999;i++)
        {
            if(i%379==0)
            {
                System.Console.WriteLine(i);
            }
            
        }
        System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
    }
    static void Zadanie4()
    {
        System.Console.WriteLine("Zadanie 4: (medium) Napisz pętle wypisującą liczby trzycyfrowe podzielne przez 5, 6 lub ewentualnie 11");
        System.Console.WriteLine("Kliknij aby wykonać...");
        Console.ReadKey();  
        for (int i = 100;i<=999;i++)
        {
            if((i%5==0 && i%6==0) || i%11==0)
            {
                System.Console.WriteLine(i);
            }    
        }
        System.Console.Write("\n Kliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
    }
    static void Zadanie5()
    {
        System.Console.WriteLine("Zadanie 5: (medium) Napisz program, który podaje sumę wpisanych przez usera liczb. User najpierw podaje ile liczb poda, a potem w pętli te liczby są czytane");
        System.Console.Write("Podaj ilość liczb: ");
        int ilość = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        int liczba = 0;
        for(int i = 1 ;i<=ilość;i++)
        {
        System.Console.Write($"Podaj {i} liczbe: ");
        liczba = Convert.ToInt32(Console.ReadLine());
        suma += liczba;
        }
        System.Console.WriteLine(suma);
        System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
    }
    static void Zadanie6()
    {
        System.Console.WriteLine("Zadanie 6: (light hard) Napisz program wyznaczający sumę k początkowych liczb parzystych");
        
        System.Console.Write("Podaj ile chcesz wypisać liczb pierwszych: ");
        int ilość = Convert.ToInt32(Console.ReadLine()); 
        
        for(int i=1,p=2;i<=ilość;p++)
        {
            if (czyPierwsza(p) == true)
            {
            System.Console.Write(p +" ");
            i++;
            }
        }    
        System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
    }
    static void Zadanie7()
   {
        System.Console.WriteLine("Zadanie 7 (light hard) Napisz program wyznaczający sumę m początkowych dwucyfrowych liczb nieparzystych");
        System.Console.Write("Ile razy chcesz z sumować: ");
        int ilosc = Convert.ToInt32(Console.ReadLine());        
        int suma = 0;
        for(int i= 1, dc = 10;i<=ilosc;dc++)
        {
            if (!(dc%2==0))
            {
                suma+=dc;
                i++;
            }

        }   
        System.Console.WriteLine($"Suma {ilosc} początkowych dwucyfrowych liczb nieparzystych to: {suma}");
        System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
   } 
   static void Zadanie8()
   {
        System.Console.WriteLine("Zadanie 8:(light hard) Napisz program, który W PĘTLI obliczy wartość inwestycji, która jest kapitalizowana co miesiąc w stosunku 6% rocznie. User podaje kwotę wejściową W0 oraz okres inwestycji w latach L z dokładnością do pół roku");
        System.Console.Write("Podaj wartość początkową inwestycji: ");
        int w0 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Ile lat ma trwać inwestycja: ");
        double L = Convert.ToDouble(Console.ReadLine());     
        double wartosc = w0;
        for(int m= 1;m<=(L*12);m++)
        {
            wartosc = wartosc + w0*0.6;
        }
        System.Console.WriteLine($"Ostateczna kwota to: {wartosc}");
        System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
        Console.ReadKey();
        Console.Clear();
   }
   static void Zadanie9()
   {
    System.Console.WriteLine("Zadanie 9: (hard) Napisz program wyznaczający sumę n początkowych liczb kończących się liczbą 21");
    System.Console.Write("Ile razy chcesz z sumować: ");
    int n = Convert.ToInt32(Console.ReadLine()); 
    int l = 21;
    int suma = 0;
    for(int i = 1;i<=n;i++)
    {
        l+=100;
        suma += l;
    }
    System.Console.WriteLine($"Suma {n} początkowych liczb kończących się liczbą 21 to: {suma}");
    System.Console.Write("\nKliknij aby rozpocząć następne zadanie...");
    Console.ReadKey();
    Console.Clear();
   }

    static void Zadanie10()
    {
        System.Console.WriteLine("Zadanie 10: (hard) Napisz program wyznaczający wszystkie liczby od 1 do 1000, które kończą się swoim pierwiastkiem");
        System.Console.WriteLine("Kliknij aby wykonać...");
        Console.ReadKey();  
        for(double i = 1;i<=1000;i++)
       {
            if(i % 10 == Math.Sqrt(i))System.Console.WriteLine(i);
        
            else if(i % 100 == Math.Sqrt(i))System.Console.WriteLine(i);
        
       }
        System.Console.Write("\nKliknij aby zakończyć program...");
        Console.ReadKey();
        Console.Clear();
    }
    static bool czyPierwsza(int a) 
    {
      for (int i = 2; i < a; i++) {
        if (a % i == 0) {
          return false;
        }
      }
      return true;
    } 


}