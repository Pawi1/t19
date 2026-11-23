package zad23;

public class BitaSmietana extends DodatekDekorator {

    public BitaSmietana(Napoj napoj) {
        super(napoj);
    }

    @Override
    public String opis() {
        return napoj.opis() + ", bita śmietana";
    }

    @Override
    public double cena() {
        return napoj.cena() + 2.00;
    }
}
