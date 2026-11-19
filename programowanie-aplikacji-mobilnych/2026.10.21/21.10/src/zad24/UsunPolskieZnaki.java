package zad24;

public class UsunPolskieZnaki extends TekstDekorator {
    public UsunPolskieZnaki(ZrodloTekstu zrodloTekstu) {
        super(zrodloTekstu);
    }
    @Override
    public String pobierz() {
        var z = "ąćęłńóśźżĄĆĘŁŃÓŚŹŻ";
        var na = "acelnoszzACELNOSZZ";
        var sb = new StringBuilder();
        for (var c :  zrodloTekstu.pobierz().toCharArray()) {
            var i = z.indexOf(c);
            sb.append(i >= 0 ? na.charAt(i) : c);
        }
        return sb.toString();
    }
}
