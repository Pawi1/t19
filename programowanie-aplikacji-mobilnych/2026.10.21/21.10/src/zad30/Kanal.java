package zad30;

import java.util.ArrayList;

/// BONUS: Kanal implements Subskrybent - kanał może obserwować inny kanał
/// i automatycznie udostępniać jego filmy z wybranej kategorii.
public class Kanal implements Subskrybent {
    private final String nazwa;
    private final String kategoriaUdostepniania;
    private final ArrayList<Subskrybent> subskrybenci = new ArrayList<>();
    private final ArrayList<Film> filmy = new ArrayList<>();

    public Kanal(String nazwa) {
        this(nazwa, null);
    }

    public Kanal(String nazwa, String kategoriaUdostepniania) {
        this.nazwa = nazwa;
        this.kategoriaUdostepniania = kategoriaUdostepniania;
    }

    public String getNazwa() {
        return nazwa;
    }

    public ArrayList<Film> getFilmy() {
        return new ArrayList<>(filmy);
    }

    public void subskrybuj(Subskrybent s) {
        if (subskrybenci.contains(s)) {
            IO.println("(" + nazwa + ": ten subskrybent już jest na liście)");
            return;
        }
        subskrybenci.add(s);
    }

    public void anuluj(Subskrybent s) {
        if (!subskrybenci.remove(s))
            IO.println("(" + nazwa + ": tego subskrybenta nie ma na liście)");
    }

    public void opublikuj(Film f) {
        filmy.add(f);
        for (var s : subskrybenci)
            s.powiadomienie(this, f);
    }

    @Override
    public void powiadomienie(Kanal k, Film f) {
        if (kategoriaUdostepniania == null || !f.kategoria().equals(kategoriaUdostepniania))
            return;
        if (filmy.contains(f))
            return;
        IO.println(nazwa + ": udostępniam film z kanału " + k.getNazwa() + ": " + f.tytul());
        opublikuj(f);
    }
}
