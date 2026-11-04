package zad20;

public class ProsteZadanie implements Runnable {
    int numer;

    ProsteZadanie(int numer) {
        this.numer = numer;
    }

    @Override
    public void run() {
        try {
            Thread.sleep(30);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        IO.println(String.format("Zadanie %d wykonane", numer));
    }
}
