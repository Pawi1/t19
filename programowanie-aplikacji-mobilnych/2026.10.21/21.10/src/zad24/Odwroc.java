package zad24;

public class Odwroc extends TekstDekorator{
    public Odwroc(ZrodloTekstu zrodloTekstu) {
        super(zrodloTekstu);
    }
    @Override
    public String pobierz() {
        return new StringBuilder(zrodloTekstu.pobierz()).reverse().toString();
    }
}
