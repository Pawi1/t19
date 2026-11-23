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
        // przykład z treści zadania
        IO.println(new NumerowanieLinii(
                new WielkieLitery(
                        new ZwyklyTekst("ala ma kota\nkot ma ale"))).pobierz());

        IO.println("\nUsunPolskieZnaki:");
        IO.println(new UsunPolskieZnaki(
                new ZwyklyTekst("Zażółć gęślą jaźń, ćma")).pobierz());

        IO.println("\nSzyfrCezara(3) i odszyfrowanie przez SzyfrCezara(-3):");
        var zaszyfrowany = new SzyfrCezara(3, new ZwyklyTekst("ala ma kota"));
        IO.println(zaszyfrowany.pobierz());
        IO.println(new SzyfrCezara(-3, zaszyfrowany).pobierz());

        IO.println("\nKolejność dekoratorów:");
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