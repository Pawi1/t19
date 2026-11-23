package zad05;

import java.util.ArrayList;

public class Program {
    void main() throws InterruptedException {
        /// Klasa Drukarka ma metodę drukuj(String nazwaDokumentu, int liczbaLinii),
        /// która wypisuje dokument linia po linii (z krótkim sleep między liniami):
        ///
        ///   [Raport.pdf] linia 1/5
        ///   [Raport.pdf] linia 2/5
        ///   ...
        ///
        /// Trzech użytkowników (wątki) drukuje jednocześnie swoje dokumenty
        /// na JEDNEJ drukarce.
        ///
        /// a) Bez synchronizacji – zaobserwuj przeplatanie się linii.
        /// b) Z synchronizacją – każdy dokument musi wydrukować się w całości,
        ///    zanim zacznie się następny.
        /// c) Dodatkowo: druga drukarka (drugi obiekt). Pokaż, że synchronizacja
        ///    na obiekcie blokuje tylko tę jedną drukarkę – na dwóch drukarkach
        ///    dokumenty mogą drukować się równolegle.
        // var drukarka = new Drukarka(); // a) brak synchronizacji, przeplata sie
        var drukarka = new Drukarka2();   // b) z synchronized
        var thl = new ArrayList<Thread>();
        thl.add(watek(drukarka, "Raport.pdf", 5));
        thl.add(watek(drukarka, "Tekst.docx", 3));
        thl.add(watek(drukarka, "Obraz.png", 6));
        uruchom(thl);

        wersjaC();
    }

    /// c) dwie drukarki (dwa monitory) - dokumenty z różnych drukarek
    /// przeplatają się, mimo że każda drukarka jest synchronized
    private void wersjaC() throws InterruptedException {
        IO.println("\n--- wersja c): dwie drukarki ---");
        var drukarka = new Drukarka2();
        var drukarka2 = new Drukarka2();
        var thl = new ArrayList<Thread>();
        thl.add(watek(drukarka, "Raport.pdf", 5));
        thl.add(watek(drukarka, "Tekst.docx", 3));
        thl.add(watek(drukarka2, "Obraz.png", 6));
        uruchom(thl);
    }

    private Thread watek(Drukarka drukarka, String nazwa, int liczbaLinii) {
        return new Thread(() -> {
            try {
                drukarka.drukuj(nazwa, liczbaLinii);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        });
    }

    private void uruchom(ArrayList<Thread> thl) throws InterruptedException {
        for (var th : thl) {
            th.start();
        }
        for (var th : thl) {
            th.join();
        }
    }
}
