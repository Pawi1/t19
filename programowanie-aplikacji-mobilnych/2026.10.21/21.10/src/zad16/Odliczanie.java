package zad16;

public class Odliczanie implements Runnable {
    String nazwa;
    int odIlu;

    Odliczanie(String nazwa, int odIlu) {
        this.nazwa = nazwa;
        this.odIlu = odIlu;
    }

    @Override
    public void run() {
        for (var i = odIlu; i >= 0; i--) {
            IO.println(String.format("%s: %d", nazwa, i));
            try {
                // bez sleepa wątki są tak krótkie, że wykonują się praktycznie
                // po kolei i nie widać przeplatania
                Thread.sleep(100);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }
}
