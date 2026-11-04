package zad17;

import java.util.HashMap;
import java.util.Random;

public class Sala {
    HashMap<Integer, String> miejsca = new HashMap<>();
    Random r = new Random();

    boolean rezerwuj(int miejsce, String klient) {
        if (miejsca.get(miejsce) != null)
            return false;
        try {
            Thread.sleep(r.nextInt(6));
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        miejsca.put(miejsce, klient);
        return true;
    }

    void wypiszPlan() {
        for (var i = 1; i <= 30; i++)
            IO.print(String.format("[%02d %s] ", i, miejsca.getOrDefault(i, "----")));
        IO.println("");
    }
}
