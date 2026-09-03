namespace spr1;
class Program
{ 
    static void Main()
    {
        // grupa 2
        // Napisz program, który:
        // 
        // Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową o długości n, wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury
        // Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole kwadratu to:
        // P=a2
        // 
        // Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód kwadratu to:
        // O=4a
        // 
        // W funkcji Main:
        // Deklaruje zmienną n i przypisuje jej wartość 5.
        // Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
        // Wyświetla na ekranie zawartość tablicy tablica.
        // 
        // Dla każdego elementu tablicy tablica:
        // Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
        // Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.
        // 
        // Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
        // Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu
        // do każdej zmiennej dodaj 2 w nazwie
        int[] UtworzTabliceLiczb2(int n)
        {
            int[] tablica = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj {0}/{1}: ",i+1,n);
                if (int.TryParse(Console.ReadLine(), out int j)) tablica[i] = j;
                else --i;
            }
            return tablica;
        }
        int ObliczPole2(int a)
        {
            return a * a;
        }
        int ObliczObwod2(int a)
        {
            return a * 4;
        }

        int n2 = 5;
        int[] tablica2 = UtworzTabliceLiczb2(n2);
        Console.WriteLine("\nWyświetlanie zawartości tablicy 'tablica2':");
        foreach (int e in tablica2)
        {
            Console.Write(e+" ");
        }
        Console.WriteLine("\n");
        foreach (int e in tablica2)
        {
            int pole2 = ObliczPole2(e);
            int obwod2 = ObliczObwod2(e);
            Console.WriteLine("Dla boku długości {0}: pole jest równe: {1} obwód jest równy: {2}",e,pole2,obwod2);
        }

        void funkcja2(int[] tablica)
        {
            for (;;)
            {
                Console.Write("Podaj dowolny index z zakresu od 0 do {0} (albo q żeby zakończyć program): ",tablica.Length-1);
                string s = Console.ReadLine()??"";
                if (int.TryParse(s, out int j) && j > -1 && j < tablica.Length)
                {
                    int pole2 = ObliczPole2(tablica[j]);
                    int obwod2 = ObliczObwod2(tablica[j]);
                    Console.WriteLine("Dla boku długości {0}: pole jest równe: {1} obwód jest równy: {2}\n",tablica[j],pole2,obwod2);
                }
                else if(s == "q")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Został podany niepoprawny index, spróbuj ponownie ...\n");
                }
            }
        }
        Console.WriteLine("\n");
        funkcja2(tablica2);
    }
}