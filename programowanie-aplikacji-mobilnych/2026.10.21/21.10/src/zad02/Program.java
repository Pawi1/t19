package zad02;

import java.util.ArrayList;

public class Program {
    private static final int N = 10;
    private static final int POWTORZENIA = 100_000;

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
    ///
    /// Przykładowy przebieg (N = 10, 100 000 zwiększeń na wątek):
    ///   Wersja          | Wynik     | Oczekiwany | Czas [ms]
    ///   bez synchr.     | 258763    | 1000000    | 50
    ///   z metodą        | 1000000   | 1000000    | 81
    ///   z blokiem       | 1000000   | 1000000    | 54
    void main() throws InterruptedException {
        IO.println("Wersja          | Wynik     | Oczekiwany | Czas [ms]");
        wykonaj("bez synchr.", new Licznik());
        wykonaj("z metodą", new Licznik2());
        wykonaj("z blokiem", new Licznik3());
    }

    private void wykonaj(String nazwa, Licznik licznik) throws InterruptedException {
        var run1 = new Runnable(){
            @Override
            public void run(){
                for (int i = 0; i < POWTORZENIA; i++) {
                    licznik.zwieksz();
                }
            }
        };
        var thl = new ArrayList<Thread>();
        for (int i = 0; i < N; i++) {
            thl.add(new Thread(run1));
        }
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
        IO.println(String.format("%-15s | %-9d | %-10d | %d",
                nazwa, licznik.getWartosc(), N * POWTORZENIA, stop - start));
    }
}
