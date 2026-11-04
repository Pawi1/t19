package zad16;

import java.util.ArrayList;

public class Program {
    /// Klasa Odliczanie implements Runnable (pola: nazwa, od ilu liczy).
    /// ArrayList<Runnable> z 5 odliczaniami, na podstawie listy budujemy
    /// ArrayList<Thread>:
    /// - pętlą tworzymy wątki i uruchamiamy (start()),
    /// - drugą pętlą czekamy na wszystkie (join()),
    /// - na końcu "Wszystkie wątki zakończone".
    ///
    /// Pytanie: co się stanie, jeśli start() i join() będą w jednej pętli?
    /// Jeśli w jednej pętli po start() wywołamy od razu join(), to główny wątek
    /// czeka na zakończenie każdego wątku po kolei, zanim uruchomi następny –
    /// wątki przestają działać równolegle, program wykonuje się sekwencyjnie
    /// tak jakby wywołać po kolei run().
    void main() throws InterruptedException {
        var odliczania = new ArrayList<Runnable>();
        odliczania.add(new Odliczanie("A", 5));
        odliczania.add(new Odliczanie("B", 3));
        odliczania.add(new Odliczanie("C", 8));
        odliczania.add(new Odliczanie("D", 4));
        odliczania.add(new Odliczanie("E", 6));

        var watki = new ArrayList<Thread>();
        for (var o : odliczania) {
            var w = new Thread(o);
            watki.add(w);
            w.start();
        }
        for (var w : watki)
            w.join();

        IO.println("Wszystkie wątki zakończone");
    }
}
