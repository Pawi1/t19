package zad18;

import java.util.ArrayList;
import java.util.HashMap;

public class Program {
    /// Klasa Logger ze wspólną ArrayList<String> logów i metodą
    /// zapisz(String modul, String poziom, String tresc).
    /// Każdy wpis ma format: "[ERROR] Siec: brak połączenia".
    ///
    /// 4 wątki symulują moduły aplikacji: "Siec", "Baza", "UI", "Platnosci".
    /// Każdy wątek generuje 250 wpisów z losowym poziomem
    /// INFO / WARN / ERROR (sleep 0–5 ms między wpisami).
    ///
    /// a) Logger (bez synchronized) – rozmiar listy bywa mniejszy niż 1000,
    /// b) Logger2 (z synchronized) – zawsze 1000.
    void main() throws InterruptedException {
        var logger = new Logger();
        //var logger = new Logger2();
        var nazwy = new String[]{"Siec", "Baza", "UI", "Platnosci"};
        var watki = new ArrayList<Thread>();

        for (var nazwa : nazwy) {
            var w = new Thread(new Modul(nazwa, logger));
            watki.add(w);
            w.start();
        }
        for (var w : watki)
            w.join();

        IO.println(String.format("Rozmiar listy: %d", logger.logi.size()));

        var liczbaWgPoziomu = new HashMap<String, Integer>();
        var bledyWgModulu = new HashMap<String, Integer>();
        var ostatnieBledy = new ArrayList<String>();

        for (var wpis : logger.logi) {
            var poziom = wpis.substring(1, wpis.indexOf(']'));
            liczbaWgPoziomu.put(poziom, liczbaWgPoziomu.getOrDefault(poziom, 0) + 1);
            if (poziom.equals("ERROR")) {
                var modul = wpis.substring(wpis.indexOf(']') + 2, wpis.indexOf(':'));
                bledyWgModulu.put(modul, bledyWgModulu.getOrDefault(modul, 0) + 1);
                ostatnieBledy.add(wpis);
            }
        }

        IO.println("\nRaport:");
        liczbaWgPoziomu.forEach((poziom, ile) -> IO.print(String.format("%s: %d  ", poziom, ile)));

        var najwiecejBledow = bledyWgModulu.entrySet().stream()
                .max(java.util.Map.Entry.comparingByValue())
                .orElseThrow();
        IO.println(String.format("\nNajwięcej błędów: %s (%d)", najwiecejBledow.getKey(), najwiecejBledow.getValue()));

        IO.println("\nOstatnie 5 błędów:");
        ostatnieBledy.subList(Math.max(0, ostatnieBledy.size() - 5), ostatnieBledy.size())
                .forEach(IO::println);
    }
}
