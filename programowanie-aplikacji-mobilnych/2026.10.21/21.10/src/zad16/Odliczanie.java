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
        for (var i = odIlu; i >= 0; i--)
            IO.println(String.format("%s: %d", nazwa, i));
    }
}
