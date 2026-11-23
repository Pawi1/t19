package zad25;

public class Sklep {
    private final Platnosc platnosc;

    public Sklep(Platnosc platnosc) {
        this.platnosc = platnosc;
    }

    public void zamow(String produkt, double cenaPLN) {
        IO.println(String.format("Zamówienie: %s za %.2f zł", produkt, cenaPLN));
        if (platnosc.zaplac(cenaPLN))
            IO.println("  -> zrealizowane, status: " + platnosc.status());
        else
            IO.println("  -> nieudane, status: " + platnosc.status());
    }
}
