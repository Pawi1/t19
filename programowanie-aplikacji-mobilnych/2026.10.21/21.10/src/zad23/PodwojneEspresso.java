package zad23;

public class PodwojneEspresso extends DodatekDekorator {
    public PodwojneEspresso(Napoj napoj) {
        super(napoj);
    }

    @Override
    public String opis() {
        return napoj.opis() + ", podwójne Espresso";
    }

    @Override
    public double cena() {
        return napoj.cena() + 15.5;
    }
}
