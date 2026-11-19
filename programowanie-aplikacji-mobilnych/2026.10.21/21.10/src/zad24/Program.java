package zad24;

/// Interfejs ZrodloTekstu: String pobierz().
/// Klasa bazowa: ZwyklyTekst (tekst podany w konstruktorze).
/// Dekoratory:
/// - WielkieLitery,
/// - SzyfrCezara (przesunięcie w konstruktorze),
/// - NumerowanieLinii,
/// - UsunPolskieZnaki (ą->a, ę->e...),
/// - Odwroc.
///
///   ZrodloTekstu t = new NumerowanieLinii(
///                       new WielkieLitery(
///                          new ZwyklyTekst("ala ma kota\nkot ma ale")));
///   // 1: ALA MA KOTA
///   // 2: KOT MA ALE
///
/// Sprawdź i opisz, czy kolejność dekoratorów ma znaczenie
/// (np. NumerowanieLinii + Odwroc vs Odwroc + NumerowanieLinii).
///
/// BONUS: znajdź dekoratory w standardowej bibliotece Javy
/// (pakiet java.io).
public class Program {
    void main() {
        ZrodloTekstu t = new NumerowanieLinii(
                new Odwroc(
                        new ZwyklyTekst("ala ma kota\nkot ma ale")));
        IO.println(t.pobierz());
        t = new Odwroc(
                new NumerowanieLinii(
                        new ZwyklyTekst("ala ma kota\nkot ma ale")));
        IO.println(t.pobierz());
        // Różnica:
        // 1: ela am tok
        // 2: atok am ala
        //
        // ela am tok :2
        // atok am ala :1

        // BONUS:
        // new DataInputStream(new BufferedInputStream(new FileInputStream("a.bin")))
    }
}