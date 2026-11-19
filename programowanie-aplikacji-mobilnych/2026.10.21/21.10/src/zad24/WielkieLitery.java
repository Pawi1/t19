package zad24;

public class WielkieLitery extends TekstDekorator {
    public WielkieLitery(ZrodloTekstu zrodloTekstu) {
        super(zrodloTekstu);
    }

    @Override
    public String pobierz() {
        return zrodloTekstu.pobierz().toUpperCase();
    }
}
