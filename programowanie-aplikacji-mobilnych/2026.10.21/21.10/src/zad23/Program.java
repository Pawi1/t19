package zad23;

import java.util.List;

/// Interfejs Napoj: String opis(), double cena().
/// Klasy bazowe: Espresso, Americano, Herbata.
/// Klasa abstrakcyjna DodatekDekorator implements Napoj – przechowuje
/// opakowany Napoj.
/// Dekoratory: Mleko, Syrop (smak w konstruktorze), BitaSmietana,
/// PodwojneEspresso.
///
///   Napoj n = new BitaSmietana(new Syrop("karmelowy", new Mleko(new Espresso())));
///   System.out.println(n.opis() + " = " + n.cena());
///   // Espresso, mleko, syrop karmelowy, bita śmietana = 14.50
///
/// Wymagania:
/// - dodatki można nakładać wielokrotnie (np. podwójne mleko),
/// - wypisz menu kilku napojów z cenami.
///
/// Pytanie: ile klas trzeba by napisać BEZ dekoratora, żeby obsłużyć
/// wszystkie kombinacje 3 napojów i 4 dodatków?

// ODP: 3 * 2^4 = 48 kombinacji
//      3 napoje mnożymy przez (reguła mnożenia) 4 dodatki które mogą wystąpić lub nie (wariacje z powtórzeniami)
public class Program {
    void main() {
        Napoj n = new BitaSmietana(new Syrop("karmelowy", new Mleko(new Espresso())));
        IO.println(String.format("%s = %.2f", n.opis(), n.cena()));

        var menu = List.of(
                new Espresso(),
                new Mleko(new Mleko(new Americano())),
                new PodwojneEspresso(new Mleko(new Espresso())),
                new Syrop("malinowy", new Herbata()),
                new BitaSmietana(new Syrop("karmelowy", new Mleko(new Espresso())))
        );

        IO.println("\nMenu:");
        for (Napoj x : menu) {
            IO.println(String.format("%s - %.2f zł", x.opis(), x.cena()));
        }
    }
}
