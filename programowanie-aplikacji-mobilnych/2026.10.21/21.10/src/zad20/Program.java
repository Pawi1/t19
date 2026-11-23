package zad20;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

public class Program {
    /// Wspólna ArrayList<Runnable> kolejka – 15 zadań.
    /// ArrayList<Thread> z 3 robotnikami. Każdy robotnik w pętli:
    /// - pobiera i usuwa pierwsze zadanie z kolejki (synchronized!),
    /// - wykonuje je (run()),
    /// - kończy, gdy kolejka jest pusta.
    ///
    /// HashMap<String, Integer> – ile zadań wykonał każdy robotnik.
    ///
    /// BONUS: to samo z Executors.newFixedThreadPool(3) – porównaj ilość kodu.
    void main() throws InterruptedException {
        wlasnaKolejka();
        bonusExecutor();
    }

    private void wlasnaKolejka() throws InterruptedException {
        IO.println("--- własna kolejka + klasa Robotnik ---");
        var kolejka = new ArrayList<Runnable>();
        for (var i = 1; i <= 15; i++)
            kolejka.add(new ProsteZadanie(i));

        var wykonane = new HashMap<String, Integer>();
        var watki = new ArrayList<Thread>();
        for (var i = 1; i <= 3; i++) {
            var w = new Thread(new Robotnik("Robotnik-" + i, kolejka, wykonane));
            watki.add(w);
            w.start();
        }
        for (var w : watki)
            w.join();

        IO.println("");
        wykonane.forEach((nazwa, ile) -> IO.print(String.format("%s: %d  ", nazwa, ile)));
        IO.println("");
    }

    /// BONUS: executor sam dzieli pracę między 3 wątki - nie trzeba
    /// ani własnej kolejki, ani klasy Robotnik, ani synchronized.
    /// 4 linie zamiast osobnej klasy Robotnik (36 linii) i ręcznego
    /// zarządzania ArrayList<Thread>.
    private void bonusExecutor() throws InterruptedException {
        IO.println("\n--- BONUS: Executors.newFixedThreadPool(3) ---");
        var kolejka = new ArrayList<Runnable>();
        for (var i = 1; i <= 15; i++)
            kolejka.add(new ProsteZadanie(i));

        var pool = Executors.newFixedThreadPool(3);
        for (var zadanie : kolejka)
            pool.submit(zadanie);
        pool.shutdown();
        pool.awaitTermination(1, TimeUnit.MINUTES);
    }
}
