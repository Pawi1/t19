package zad24;

public class NumerowanieLinii extends TekstDekorator{
    public NumerowanieLinii(ZrodloTekstu zrodloTekstu) {
        super(zrodloTekstu);
    }

    @Override
    public String pobierz() {
        var ponumerowanyTekst = new StringBuilder();
        var tablica = zrodloTekstu.pobierz().split("\n");
        for (int i = 0; i < tablica.length; i++) {
            ponumerowanyTekst.append(String.format("%d: %s\n",i+1, tablica[i]));
        }
        return ponumerowanyTekst.toString();
    }
}
