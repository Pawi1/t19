package zad19;

public class KompresjaZdjec implements Runnable {
    int liczbaZdjec;

    KompresjaZdjec(int liczbaZdjec) {
        this.liczbaZdjec = liczbaZdjec;
    }

    @Override
    public void run() {
        for (var i = 1; i <= liczbaZdjec; i++) {
            try {
                Thread.sleep(30);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
            IO.println(String.format("Skompresowano zdjęcie %d/%d", i, liczbaZdjec));
        }
    }
}
