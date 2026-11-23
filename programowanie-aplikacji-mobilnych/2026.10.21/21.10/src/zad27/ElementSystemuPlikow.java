package zad27;

public abstract class ElementSystemuPlikow {
    protected final String nazwa;

    protected ElementSystemuPlikow(String nazwa) {
        this.nazwa = nazwa;
    }

    public String getNazwa() {
        return nazwa;
    }

    public abstract int rozmiar();
    public abstract void wypisz(int wciecie);
}
