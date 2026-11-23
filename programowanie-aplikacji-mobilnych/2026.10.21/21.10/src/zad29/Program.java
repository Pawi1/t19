package zad29;

/// Interfejsy:
///
///   interface Obserwator { void aktualizuj(Pomiar p); }
///   interface Obserwowany {
///       void dodajObserwatora(Obserwator o);
///       void usunObserwatora(Obserwator o);
///       void powiadom();
///   }
///
/// StacjaPogodowa (Obserwowany) przechowuje bieżący Pomiar
/// (temperatura, wilgotność, ciśnienie) i ArrayList obserwatorów.
/// Metoda nowyPomiar(...) zapisuje dane i powiadamia obserwatorów.
///
/// Obserwatorzy:
/// - WyswietlaczBiezacy – wypisuje aktualny pomiar,
/// - WyswietlaczStatystyk – pamięta historię, wypisuje min/max/średnią,
/// - AlarmMrozu – reaguje tylko, gdy temperatura < 0,
/// - Prognoza – na podstawie zmian ciśnienia: "poprawa", "pogorszenie",
///   "bez zmian".
///
/// Symuluj 10 pomiarów (losowych lub z tablicy). W połowie symulacji
/// odłącz jeden wyświetlacz i pokaż, że przestaje dostawać dane.
public class Program {
    void main() {
        var stacja = new StacjaPogodowa();
        var biezacy = new WyswietlaczBiezacy();

        stacja.dodajObserwatora(biezacy);
        stacja.dodajObserwatora(new WyswietlaczStatystyk());
        stacja.dodajObserwatora(new AlarmMrozu());
        stacja.dodajObserwatora(new Prognoza());

        // temperatura, wilgotność, ciśnienie
        double[][] pomiary = {
                {5.2, 70, 1012.0},
                {4.1, 72, 1013.5},
                {1.8, 78, 1013.8},
                {-0.5, 81, 1010.2},
                {-2.3, 85, 1006.4},
                {0.4, 83, 1007.1},
                {2.6, 76, 1011.9},
                {6.8, 65, 1016.3},
                {8.1, 60, 1016.1},
                {9.4, 58, 1018.7},
        };

        for (var i = 0; i < pomiary.length; i++) {
            if (i == 5) {
                stacja.usunObserwatora(biezacy);
                IO.println("\n>>> odłączam WyswietlaczBiezacy - od teraz nie dostaje danych\n");
            }
            IO.println("Pomiar " + (i + 1) + ":");
            stacja.nowyPomiar(pomiary[i][0], pomiary[i][1], pomiary[i][2]);
        }
    }
}
