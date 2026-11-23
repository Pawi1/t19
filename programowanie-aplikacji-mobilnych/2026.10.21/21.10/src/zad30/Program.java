package zad30;

/// Klasa Kanal (nazwa, ArrayList subskrybentów, ArrayList filmów).
/// Klasa Film (tytuł, kategoria).
/// Interfejs Subskrybent: void powiadomienie(Kanal k, Film f).
///
/// Rodzaje subskrybentów:
/// - Widz – wypisuje "Ania: nowy film na kanale X: <tytuł>",
/// - WidzZFiltrem – reaguje tylko na filmy z wybranej kategorii
///   (np. tylko "programowanie"),
/// - Statystyki – HashMap<String, Integer>: ile filmów opublikował
///   każdy kanał.
///
/// Wymagania:
/// - subskrybent może obserwować wiele kanałów,
/// - subskrypcja / anulowanie w dowolnym momencie,
/// - nie można zasubskrybować tego samego kanału dwa razy
///   (sprawdź contains() przed dodaniem do listy),
/// - metoda opublikuj(Film f) dodaje film i powiadamia subskrybentów.
///
/// BONUS: Kanal jest jednocześnie obserwatorem innego kanału
/// (np. kanał "Najlepsze z Javy" automatycznie udostępnia filmy
/// z kategorii "programowanie" z kanału JavaPL). Uważaj na pętle!
public class Program {
    void main() {
        var java = new Kanal("JavaPL");
        var kuchnia = new Kanal("KuchniaTV");

        var ania = new Widz("Ania");
        var kuba = new WidzZFiltrem("Kuba", "programowanie");
        var statystyki = new Statystyki();

        java.subskrybuj(ania);
        java.subskrybuj(kuba);
        java.subskrybuj(statystyki);

        // subskrybent obserwuje wiele kanałów
        kuchnia.subskrybuj(ania);
        kuchnia.subskrybuj(kuba);
        kuchnia.subskrybuj(statystyki);

        // ta sama subskrypcja dwa razy - odrzucona przez contains()
        java.subskrybuj(ania);

        IO.println("--- publikacje ---");
        java.opublikuj(new Film("Wątki w Javie", "programowanie"));
        kuchnia.opublikuj(new Film("Pierogi ruskie", "gotowanie"));
        java.opublikuj(new Film("Kolekcje w Javie", "programowanie"));

        IO.println("\n--- Ania anuluje subskrypcję JavaPL ---");
        java.anuluj(ania);
        java.anuluj(ania);   // już nie ma - komunikat
        java.opublikuj(new Film("Wzorce projektowe", "programowanie"));

        IO.println("\n--- statystyki ---");
        statystyki.wypisz();

        IO.println("\n--- BONUS: kanał jako subskrybent innego kanału ---");
        var najlepsze = new Kanal("Najlepsze z Javy", "programowanie");
        var mirror = new Kanal("Java Mirror", "programowanie");
        najlepsze.subskrybuj(new Widz("Zosia"));
        java.subskrybuj(najlepsze);

        // wzajemna subskrypcja dwóch kanałów udostępniających tę samą kategorię -
        // bez sprawdzenia filmy.contains(f) film odbijałby się w nieskończoność
        najlepsze.subskrybuj(mirror);
        mirror.subskrybuj(najlepsze);

        java.opublikuj(new Film("Rekordy i sealed", "programowanie"));
        java.opublikuj(new Film("Jak zrobić kawę", "gotowanie"));  // nie przejdzie filtru

        IO.println("\nFilmy na kanale Najlepsze z Javy: " + najlepsze.getFilmy().size());
        IO.println("Filmy na kanale Java Mirror:      " + mirror.getFilmy().size());
        IO.println("Filmy na kanale JavaPL:           " + java.getFilmy().size());
    }
}
