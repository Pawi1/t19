package zad27;

import java.util.ArrayList;

public class Folder extends ElementSystemuPlikow {
    private final ArrayList<ElementSystemuPlikow> zawartosc = new ArrayList<>();

    public Folder(String nazwa) {
        super(nazwa);
    }

    public Folder dodaj(ElementSystemuPlikow element) {
        zawartosc.add(element);
        return this;
    }

    public boolean usun(String nazwa) {
        return zawartosc.removeIf(e -> e.getNazwa().equals(nazwa));
    }

    @Override
    public int rozmiar() {
        var suma = 0;
        for (var e : zawartosc)
            suma += e.rozmiar();
        return suma;
    }

    public ElementSystemuPlikow znajdz(String nazwa) {
        for (var e : zawartosc) {
            if (e.getNazwa().equals(nazwa))
                return e;
            if (e instanceof Folder f) {
                var znaleziony = f.znajdz(nazwa);
                if (znaleziony != null)
                    return znaleziony;
            }
        }
        return null;
    }

    public int policzPliki() {
        var ile = 0;
        for (var e : zawartosc) {
            if (e instanceof Folder f)
                ile += f.policzPliki();
            else
                ile++;
        }
        return ile;
    }

    /// BONUS
    public ArrayList<Plik> znajdzWiekszeNiz(int kb) {
        var wynik = new ArrayList<Plik>();
        for (var e : zawartosc) {
            if (e instanceof Folder f)
                wynik.addAll(f.znajdzWiekszeNiz(kb));
            else if (e.rozmiar() > kb)
                wynik.add((Plik) e);
        }
        return wynik;
    }

    @Override
    public void wypisz(int wciecie) {
        IO.println("  ".repeat(wciecie) + nazwa + "/ (" + rozmiar() + " KB)");
        for (var e : zawartosc)
            e.wypisz(wciecie + 1);
    }
}
