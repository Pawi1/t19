package zad21;

class Program {
    /// Klasa Pizza ma pola: rozmiar (enum: MALA, SREDNIA, DUZA),
    /// ciasto (enum: CIENKIE, GRUBE), sos, ArrayList<String> dodatków,
    /// czyPodwojnySer.
    /// Obiekt Pizza ma być niemutowalny (pola final, brak setterów).
    ///
    /// Utwórz statyczną klasę wewnętrzną Pizza.Builder z metodami
    /// łańcuchowymi:
    ///
    ///   Pizza p = new Pizza.Builder(Rozmiar.DUZA)
    ///                 .ciasto(Ciasto.CIENKIE)
    ///                 .sos("pomidorowy")
    ///                 .dodatek("szynka")
    ///                 .dodatek("pieczarki")
    ///                 .podwojnySer()
    ///                 .build();
    ///
    /// Wymagania:
    /// - rozmiar jest obowiązkowy (konstruktor Buildera),
    /// - maksymalnie 6 dodatków – build() rzuca wyjątek przy przekroczeniu,
    /// - metoda cena() w Pizza – cena bazowa wg rozmiaru + dodatki.
    ///
    /// Uwaga – pułapka: final przy polu z listą nie wystarczy!
    /// W konstruktorze Pizzy skopiuj listę dodatków z Buildera
    /// (new ArrayList<>(...)), a getter niech nie zwraca oryginalnej listy.
    /// Sprawdź, co się stanie bez kopiowania, jeśli po build() dodasz
    /// kolejny dodatek do tego samego Buildera.
    /// Na koniec złóż 3 różne zamówienia i wypisz paragon.
    void main()
    {
        //* Odpowiedz do wyższego: bez new ArrayList<> przy kolejnym zamówieniu zmieni sie lista dodatków tego wcześniejszego, podobnie przy getterze dałoby sie zmienić liste dodatków pizzy
        var pizza1 = new Pizza.Builder(Rozmiar.MALA)
                .ciasto(Ciasto.GRUBE)
                .sos("cząstkowy")
                .dodatek("szynka")
                .dodatek("pieczarki")
                .podwojnySer()
                .build();
        var pizza2 = new Pizza.Builder(Rozmiar.SREDNIA)
                .ciasto(Ciasto.CIENKIE)
                .sos("pomidorowy")
                .dodatek("pieczarki")
                .build();
        var pizza3 = new Pizza.Builder(Rozmiar.DUZA)
                .ciasto(Ciasto.CIENKIE)
                .sos("pomidorowy")
                .build();
        IO.println(pizza1.paragon());
        IO.println(pizza2.paragon());
        IO.println(pizza3.paragon());

        // --- demonstracja pułapki ---
        // ten sam Builder używany dwa razy: po build() dodajemy jeszcze jeden dodatek
        IO.println("\n--- pułapka: ten sam Builder po build() ---");
        var builder = new Pizza.Builder(Rozmiar.DUZA).dodatek("szynka");
        var pierwsza = builder.build();
        builder.dodatek("ananas");
        var druga = builder.build();
        IO.println("pierwsza.getDodatki(): " + pierwsza.getDodatki() + ", cena " + pierwsza.cena());
        IO.println("druga.getDodatki():    " + druga.getDodatki() + ", cena " + druga.cena());
        // Dzięki kopii (new ArrayList<>(b.dodatki)) pierwsza pizza NIE dostała ananasa.
        // Bez kopiowania obie pizze trzymałyby tę samą listę i pierwsza też miałaby
        // ananasa (i wyższą cenę) - mimo że jej pole jest final.

        // getter zwraca listę niemodyfikowalną, więc nie da się dodać dodatku z zewnątrz
        try {
            pierwsza.getDodatki().add("oliwki");
        } catch (UnsupportedOperationException e) {
            IO.println("getDodatki() jest niemodyfikowalna: " + e.getClass().getSimpleName());
        }

        // maksymalnie 6 dodatków
        try {
            var zaDuzo = new Pizza.Builder(Rozmiar.DUZA);
            for (var i = 1; i <= 7; i++)
                zaDuzo.dodatek("dodatek" + i);
            zaDuzo.build();
        } catch (IllegalArgumentException e) {
            IO.println("7 dodatków odrzucone: " + e.getMessage());
        }
    }
}
