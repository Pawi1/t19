package zad30;

import java.util.HashMap;

public class Statystyki implements Subskrybent {
    private final HashMap<String, Integer> filmyNaKanal = new HashMap<>();

    @Override
    public void powiadomienie(Kanal k, Film f) {
        filmyNaKanal.merge(k.getNazwa(), 1, Integer::sum);
    }

    public void wypisz() {
        filmyNaKanal.forEach((kanal, ile) -> IO.println("  " + kanal + ": " + ile));
    }
}
