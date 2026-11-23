package zad17;

import java.util.HashMap;
import java.util.Random;

/// a) wersja BEZ synchronized - dwóch klientów może dostać to samo miejsce
public class Sala {
    HashMap<Integer, String> miejsca = new HashMap<>();
    Random r = new Random();

    boolean rezerwuj(int miejsce, String klient) {
        spij();
        if (miejsca.get(miejsce) != null)
            return false;
        // drugi sleep MIĘDZY sprawdzeniem a zapisem - rozszerza okno wyścigu,
        // bez niego sprawdzenie i put są tak blisko, że kolizja praktycznie nie zachodzi
        spij();
        var poprzedni = miejsca.put(miejsce, klient);
        if (poprzedni != null)
            IO.println(String.format("KOLIZJA: %s nadpisał %s na miejscu %02d", klient, poprzedni, miejsce));
        return true;
    }

    private void spij() {
        try {
            Thread.sleep(r.nextInt(6));
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }

    void wypiszPlan() {
        for (var i = 1; i <= 30; i++)
            IO.print(String.format("[%02d %s] ", i, miejsca.getOrDefault(i, "----")));
        IO.println("");
    }
}
