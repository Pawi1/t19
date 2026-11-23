package zad28;

import java.util.Locale;

public class Pracownik implements JednostkaOrganizacyjna {
    static final Locale PL = Locale.of("pl", "PL");

    private final String imie;
    private final String stanowisko;
    private double pensja;

    public Pracownik(String imie, String stanowisko, double pensja) {
        this.imie = imie;
        this.stanowisko = stanowisko;
        this.pensja = pensja;
    }

    @Override
    public String nazwa() {
        return imie;
    }

    public String getStanowisko() {
        return stanowisko;
    }

    @Override
    public double kosztPensji() {
        return pensja;
    }

    @Override
    public int liczbaOsob() {
        return 1;
    }

    @Override
    public void podwyzka(double procent) {
        pensja += pensja * procent / 100;
    }

    @Override
    public void wypiszStrukture(int poziom) {
        IO.println(String.format(PL, "%s%s – %s – %,.0f zł", "  ".repeat(poziom), imie, stanowisko, pensja));
    }
}
