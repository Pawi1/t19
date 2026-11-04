package zad19;

public class WysylanieMaila implements Runnable {
    String adres;

    WysylanieMaila(String adres) {
        this.adres = adres;
    }

    @Override
    public void run() {
        try {
            Thread.sleep(150);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        IO.println(String.format("Wysłano mail do %s", adres));
    }
}
