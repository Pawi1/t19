package zad28;

import java.util.ArrayList;

public class Dzial implements JednostkaOrganizacyjna {
    private final String nazwa;
    private final Pracownik kierownik;
    private final ArrayList<JednostkaOrganizacyjna> podjednostki = new ArrayList<>();

    public Dzial(String nazwa, Pracownik kierownik) {
        this.nazwa = nazwa;
        this.kierownik = kierownik;
    }

    public Dzial dodaj(JednostkaOrganizacyjna jednostka) {
        podjednostki.add(jednostka);
        return this;
    }

    @Override
    public String nazwa() {
        return nazwa;
    }

    @Override
    public double kosztPensji() {
        var suma = kierownik.kosztPensji();
        for (var j : podjednostki)
            suma += j.kosztPensji();
        return suma;
    }

    @Override
    public int liczbaOsob() {
        var ile = kierownik.liczbaOsob();
        for (var j : podjednostki)
            ile += j.liczbaOsob();
        return ile;
    }

    @Override
    public void podwyzka(double procent) {
        kierownik.podwyzka(procent);
        for (var j : podjednostki)
            j.podwyzka(procent);
    }

    /// BONUS
    public Pracownik najlepiejOplacany() {
        var najlepszy = kierownik;
        for (var j : podjednostki) {
            var kandydat = j instanceof Dzial d ? d.najlepiejOplacany() : (Pracownik) j;
            if (kandydat.kosztPensji() > najlepszy.kosztPensji())
                najlepszy = kandydat;
        }
        return najlepszy;
    }

    static String osoby(int n) {
        if (n == 1) return "osoba";
        var reszta = n % 10;
        if (reszta >= 2 && reszta <= 4 && n % 100 / 10 != 1) return "osoby";
        return "osób";
    }

    @Override
    public void wypiszStrukture(int poziom) {
        IO.println(String.format(Pracownik.PL, "%s%s (%d %s, %,.0f zł)",
                "  ".repeat(poziom), nazwa, liczbaOsob(), osoby(liczbaOsob()), kosztPensji()));
        kierownik.wypiszStrukture(poziom + 1);
        for (var j : podjednostki)
            j.wypiszStrukture(poziom + 1);
    }
}
