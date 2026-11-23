package zad03;

import java.util.Random;

public class Zolw implements Runnable {
    private String imie;

    public Zolw(String imie) {
        this.imie = imie;
    }

    @Override
    public void run() {
        var r = new Random();
        for (int i = 0; i < 20; i++) {
            IO.println(String.format("%s: krok %d/20",imie,i+1));
            try {
                Thread.sleep(r.nextInt(50,301));
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
        // monitorem musi być wspólna lista, a nie this - każdy żółw to inny obiekt,
        // więc synchronized(this) niczego nie chroniłoby
        synchronized (Program.wyniki) {
            Program.wyniki.add(imie);
        }
    }
}
