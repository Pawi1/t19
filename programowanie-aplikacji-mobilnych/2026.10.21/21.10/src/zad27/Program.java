package zad27;

/// Klasa abstrakcyjna (lub interfejs) ElementSystemuPlikow:
/// nazwa, rozmiar(), wypisz(int wciecie).
/// - Plik – liść, ma stały rozmiar,
/// - Folder – kompozyt, przechowuje ArrayList<ElementSystemuPlikow>,
///   rozmiar() = suma rozmiarów zawartości (rekurencyjnie).
///
/// Metody Folderu: dodaj(), usun(), znajdz(String nazwa) – szuka
/// rekurencyjnie, policzPliki().
///
/// Zbuduj strukturę i wypisz drzewo:
///
///   Dokumenty/ (1520 KB)
///     szkola/ (820 KB)
///       plan.pdf (120 KB)
///       zadania.docx (700 KB)
///     zdjecia/ (700 KB)
///       wakacje.jpg (700 KB)
///
/// BONUS: znajdzWiekszeNiz(int kb) – lista wszystkich plików
/// większych niż podany rozmiar.
public class Program {
    void main() {
        var szkola = new Folder("szkola")
                .dodaj(new Plik("plan.pdf", 120))
                .dodaj(new Plik("zadania.docx", 700));
        var zdjecia = new Folder("zdjecia")
                .dodaj(new Plik("wakacje.jpg", 700));
        var dokumenty = new Folder("Dokumenty")
                .dodaj(szkola)
                .dodaj(zdjecia);

        dokumenty.wypisz(0);

        IO.println("\nRozmiar Dokumenty: " + dokumenty.rozmiar() + " KB");
        IO.println("Liczba plików: " + dokumenty.policzPliki());

        var szukany = dokumenty.znajdz("wakacje.jpg");
        IO.println("znajdz(\"wakacje.jpg\") -> " + szukany.getNazwa() + " (" + szukany.rozmiar() + " KB)");
        IO.println("znajdz(\"brak.txt\") -> " + dokumenty.znajdz("brak.txt"));

        IO.println("\nBONUS - pliki większe niż 500 KB:");
        for (var p : dokumenty.znajdzWiekszeNiz(500))
            IO.println("  " + p.getNazwa() + " (" + p.rozmiar() + " KB)");

        IO.println("\nusun(\"zdjecia\") -> " + dokumenty.usun("zdjecia"));
        dokumenty.wypisz(0);
    }
}
