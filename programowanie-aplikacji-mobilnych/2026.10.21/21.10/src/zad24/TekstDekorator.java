package zad24;

public abstract class TekstDekorator implements ZrodloTekstu {
    protected final ZrodloTekstu zrodloTekstu;
    public TekstDekorator(ZrodloTekstu zrodloTekstu) {
        this.zrodloTekstu = zrodloTekstu;
    }

    @Override
    public String pobierz() {
        return "";
    }
}
