package zad24;

public class ZwyklyTekst implements ZrodloTekstu {
    private final String tekst;
    public ZwyklyTekst(String tekst) {
        this.tekst = tekst;
    }

    @Override
    public String pobierz() {
        return tekst;
    }
}
