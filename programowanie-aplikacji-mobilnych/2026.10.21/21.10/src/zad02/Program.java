package zad02;

import java.util.ArrayList;

public class Program {
    void main() throws InterruptedException {
        ///   Wersja          | Wynik     | Oczekiwany | Czas [ms]
        ///   bez synchr.     | 258763    | 20000000   | 50
        ///   z metodą        | 20000000  | 20000000   | 81
        ///   z blokiem       | 20000000  | 20000000   | 54

        /// Klasa Licznik ma pole wartosc i metodę zwieksz().
        /// Uruchom N wątków (N podawane w kodzie, np. 10), każdy wywołuje
        /// zwieksz() 100 000 razy. Po zakończeniu wszystkich wątków (join!)
        /// wypisz wynik i porównaj z oczekiwanym (N * 100 000).
        ///
        /// Przygotuj trzy wersje:
        /// a) bez synchronizacji,
        /// b) z metodą synchronized,
        /// c) z blokiem synchronized(this) { ... }.
        ///
        /// Zmierz czas wykonania każdej wersji (System.currentTimeMillis())
        /// i wypisz wyniki w tabelce:
        ///
        ///   Wersja          | Wynik     | Oczekiwany | Czas [ms]
        ///   bez synchr.     | 734512    | 1000000    | 12
        ///   ...
        var licznik = new Licznik();
        //var licznik = new Licznik2();
        //var licznik = new Licznik3();
        var run1 = new Runnable(){
            @Override
            public void run(){
                for (int i = 0; i < 100000; i++) {
                    licznik.zwieksz();
                }
            }
        };
        var n = Integer.parseInt(IO.readln("Podaj ilość wątków: "));
        var thl = new ArrayList<Thread>();
        for (int i = 0; i < n; i++) {
            thl.add(new Thread(run1));
        }
        IO.println("\nOczekiwany wynik: "+n*1000000);
        var start = System.currentTimeMillis();
        for (var th: thl)
        {
            th.start();
        }
        for (var th: thl)
        {
            th.join();
        }
        var stop = System.currentTimeMillis();
        IO.println("Wynik: "+licznik.getWartosc());
        IO.println("Czas: "+(stop-start));
    }
}
