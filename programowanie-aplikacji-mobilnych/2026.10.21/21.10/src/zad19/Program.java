package zad19;

import java.util.ArrayList;

public class Program {
    /// 3 klasy implementujące Runnable:
    /// - PobieraniePliku (nazwa pliku, postęp co 25%),
    /// - WysylanieMaila (adres, sleep i komunikat),
    /// - KompresjaZdjec (liczba zdjęć, komunikat po każdym).
    ///
    /// ArrayList<Runnable> z 8 zadaniami różnych typów (przemieszanymi).
    /// a) wykonaj je po kolei w jednym wątku (zwykła pętla r.run()),
    /// b) uruchom każde w osobnym wątku (ArrayList<Thread>, start, join).
    ///
    /// Pytanie: czym różni się wywołanie run() od start()?
    /// run() to zwykłe wywołanie metody – wykonuje się w bieżącym wątku,
    /// blokując go do zakończenia. start() tworzy nowy wątek systemowy
    /// i w nim dopiero wywołuje run() – kod wykonuje się równolegle,
    /// a wątek wywołujący start() od razu wraca do dalszej pracy.
    void main() throws InterruptedException {
        var zadania = new ArrayList<Runnable>();
        zadania.add(new PobieraniePliku("plik1.zip"));
        zadania.add(new WysylanieMaila("ktos@example.com"));
        zadania.add(new KompresjaZdjec(4));
        zadania.add(new PobieraniePliku("plik2.zip"));
        zadania.add(new KompresjaZdjec(3));
        zadania.add(new WysylanieMaila("inny@example.com"));
        zadania.add(new PobieraniePliku("plik3.zip"));
        zadania.add(new KompresjaZdjec(5));

        IO.println("=== a) po kolei w jednym wątku ===");
        var start1 = System.currentTimeMillis();
        for (var z : zadania)
            z.run();
        var czas1 = System.currentTimeMillis() - start1;

        IO.println("\n=== b) każde w osobnym wątku ===");
        var start2 = System.currentTimeMillis();
        var watki = new ArrayList<Thread>();
        for (var z : zadania) {
            var w = new Thread(z);
            watki.add(w);
            w.start();
        }
        for (var w : watki)
            w.join();
        var czas2 = System.currentTimeMillis() - start2;

        IO.println(String.format("\nCzas sekwencyjnie: %d ms", czas1));
        IO.println(String.format("Czas wielowątkowo: %d ms", czas2));
    }
}
