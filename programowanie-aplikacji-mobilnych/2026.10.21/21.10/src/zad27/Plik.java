package zad27;

public class Plik extends ElementSystemuPlikow {
    private final int rozmiarKB;

    public Plik(String nazwa, int rozmiarKB) {
        super(nazwa);
        this.rozmiarKB = rozmiarKB;
    }

    @Override
    public int rozmiar() {
        return rozmiarKB;
    }

    @Override
    public void wypisz(int wciecie) {
        IO.println("  ".repeat(wciecie) + nazwa + " (" + rozmiarKB + " KB)");
    }
}
