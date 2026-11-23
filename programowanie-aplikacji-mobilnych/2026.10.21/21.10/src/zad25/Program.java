package zad25;

/// Sklep internetowy korzysta z interfejsu:
///
///   interface Platnosc {
///       boolean zaplac(double kwotaPLN);
///       String status();
///   }
///
/// Firma ma też dwie gotowe klasy, których NIE WOLNO modyfikować.
/// Przepisz je do projektu tak, jak są: StaryTerminal, ForeignPayGateway.
///
/// Napisz adaptery StaryTerminalAdapter i ForeignPayAdapter
/// implementujące Platnosc:
/// - StaryTerminalAdapter – zamiana złotówek na grosze, kody 0/1/2
///   zamienione na czytelny status ("OK", "Odrzucono", "Błąd połączenia"),
/// - ForeignPayAdapter – przeliczenie PLN na EUR po stałym kursie
///   (np. 1 EUR = 4.30 PLN), status "OK" / "Odrzucono".
///
/// Klasa Sklep przyjmuje dowolną Platnosc i realizuje zamówienie –
/// nie może wiedzieć, z którym systemem rozmawia.
///
///   Sklep sklep = new Sklep(new ForeignPayAdapter(new ForeignPayGateway()));
///   sklep.zamow("Słuchawki", 249.99);
public class Program {
    void main() {
        IO.println("--- ForeignPayGateway przez adapter ---");
        var sklepZagraniczny = new Sklep(new ForeignPayAdapter(new ForeignPayGateway()));
        sklepZagraniczny.zamow("Słuchawki", 249.99);
        sklepZagraniczny.zamow("Laptop", 5999.00);

        IO.println("\n--- StaryTerminal przez adapter ---");
        var sklepKrajowy = new Sklep(new StaryTerminalAdapter(new StaryTerminal()));
        sklepKrajowy.zamow("Myszka", 89.90);
        sklepKrajowy.zamow("Kabel USB-C", 24.50);
        sklepKrajowy.zamow("Darmowa naklejka", 0.00);

        IO.println("\n--- ta sama pętla, dwa różne systemy ---");
        var platnosci = new Platnosc[]{
                new ForeignPayAdapter(new ForeignPayGateway()),
                new StaryTerminalAdapter(new StaryTerminal())
        };
        for (var p : platnosci)
            new Sklep(p).zamow("Klawiatura", 349.00);
    }
}
