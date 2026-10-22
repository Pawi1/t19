package zad03;

import java.util.Random;

public class Zolw implements Runnable {
    private String imie;

    public Zolw(String imie) {
        this.imie = imie;
    }

    @Override
    public void run() {
        for (int i = 0; i < 20; i++) {
            var r = new Random();
            IO.println(String.format("%s: krok %d/20",imie,i+1));
            try {
                Thread.sleep(r.nextInt(50,300));
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
        synchronized (this) {
            Program.wyniki.add(imie);
        }
    }
}
