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
        // var drukarka = new Drukarka(); // brak synchronizacji, przeplata sie
        var drukarka = new Drukarka2();
        var thl = new ArrayList<Thread>();
        thl.add(new Thread(() -> {
            try {
                drukarka.drukuj("Raport.pdf",5);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }));
        thl.add(new Thread(() -> {
            try {
                drukarka.drukuj("Tekst.docx",3);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }));
        thl.add(new Thread(() -> {
            try {
                drukarka.drukuj("Obraz.png",6);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }));
        for (var th : thl) {
            th.start();
        }
        for (var th : thl) {
            th.join();
        }

        /// Wersja c
//        var drukarka = new Drukarka2();
//        var drukarka2 = new Drukarka2();
//        var thl = new ArrayList<Thread>();
//        thl.add(new Thread(() -> {
//            try {
//                drukarka.drukuj("Raport.pdf",5);
//            } catch (InterruptedException e) {
//                throw new RuntimeException(e);
//            }
//        }));
//        thl.add(new Thread(() -> {
//            try {
//                drukarka.drukuj("Tekst.docx",3);
//            } catch (InterruptedException e) {
//                throw new RuntimeException(e);
//            }
//        }));
//        thl.add(new Thread(() -> {
//            try {
//                drukarka2.drukuj("Obraz.png",6);
//            } catch (InterruptedException e) {
//                throw new RuntimeException(e);
//            }
//        }));
//        for (var th : thl) {
//            th.start();
//        }
//        for (var th : thl) {
//            th.join();
//        }
    }
}
