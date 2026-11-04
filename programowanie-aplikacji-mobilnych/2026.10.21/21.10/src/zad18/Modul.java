package zad18;

import java.util.Random;

public class Modul implements Runnable {
    String nazwa;
    Logger logger;
    static String[] POZIOMY = {"INFO", "WARN", "ERROR"};
    static String[] TRESCI = {"OK", "spowolnienie", "brak połączenia", "timeout", "nieprawidłowe dane"};

    Modul(String nazwa, Logger logger) {
        this.nazwa = nazwa;
        this.logger = logger;
    }

    @Override
    public void run() {
        var r = new Random();
        for (var i = 0; i < 250; i++) {
            var poziom = POZIOMY[r.nextInt(POZIOMY.length)];
            var tresc = TRESCI[r.nextInt(TRESCI.length)];
            logger.zapisz(nazwa, poziom, tresc);
            try {
                Thread.sleep(r.nextInt(6));
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
