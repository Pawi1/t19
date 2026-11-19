package zad23;

public class Syrop extends DodatekDekorator {
    private final String smak;
    public Syrop(String smak, Napoj napoj) {
        super(napoj);
        this.smak = smak;
    }
    @Override
    public String opis() {
        return napoj.opis() + ", syrop " + smak;
    }
    @Override
    public double cena() {
        return napoj.cena() + 0.5;
    }
}
