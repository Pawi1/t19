package zad23;

public class Mleko extends DodatekDekorator {
    public Mleko(Napoj napoj) {
        super(napoj);
    }

    @Override
    public String opis() {
        return napoj.opis() + ", mleko";
    }

    @Override
    public double cena() {
        return napoj.cena() + 2.00;
    }

}
