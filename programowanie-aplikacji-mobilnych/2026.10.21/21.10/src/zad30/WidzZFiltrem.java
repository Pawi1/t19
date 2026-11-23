package zad30;

public class WidzZFiltrem implements Subskrybent {
    private final String imie;
    private final String kategoria;

    public WidzZFiltrem(String imie, String kategoria) {
        this.imie = imie;
        this.kategoria = kategoria;
    }

    @Override
    public void powiadomienie(Kanal k, Film f) {
        if (!f.kategoria().equals(kategoria))
            return;
        IO.println(imie + " (tylko " + kategoria + "): nowy film na kanale "
                + k.getNazwa() + ": " + f.tytul());
    }
}
