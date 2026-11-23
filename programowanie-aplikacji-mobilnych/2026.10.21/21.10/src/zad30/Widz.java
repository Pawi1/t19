package zad30;

public class Widz implements Subskrybent {
    private final String imie;

    public Widz(String imie) {
        this.imie = imie;
    }

    public String getImie() {
        return imie;
    }

    @Override
    public void powiadomienie(Kanal k, Film f) {
        IO.println(imie + ": nowy film na kanale " + k.getNazwa() + ": " + f.tytul());
    }
}
