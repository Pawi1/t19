package zad19;

public class PobieraniePliku implements Runnable {
    String nazwa;

    PobieraniePliku(String nazwa) {
        this.nazwa = nazwa;
    }

    @Override
    public void run() {
        for (var postep = 25; postep <= 100; postep += 25) {
            try {
                Thread.sleep(50);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
            IO.println(String.format("Pobieranie %s: %d%%", nazwa, postep));
        }
    }
}
