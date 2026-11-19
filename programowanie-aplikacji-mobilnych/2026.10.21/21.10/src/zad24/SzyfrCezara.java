package zad24;

public class SzyfrCezara extends TekstDekorator {
    private final int przesuniecie;
    public SzyfrCezara(int przesuniecie, ZrodloTekstu zrodloTekstu) {
        super(zrodloTekstu);
        this.przesuniecie = przesuniecie;
    }

    @Override
    public String pobierz() {
        var p = ((przesuniecie % 26) + 26) % 26;
        var sb = new StringBuilder();
        for (var c : zrodloTekstu.pobierz().toCharArray()) {
            if (c >= 'a' && c <= 'z') {
                sb.append((char) ('a' + (c - 'a' + p) % 26));
            } else if (c >= 'A' && c <= 'Z') {
                sb.append((char) ('A' + (c - 'A' + p) % 26));
            } else {
                sb.append(c);
            }
        }
        return sb.toString();
    }
}
