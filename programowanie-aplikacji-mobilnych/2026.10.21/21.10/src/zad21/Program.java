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
        //* Odpowiedz do wyższego: bez new List<> przy kolejnym zamówieniu zmieni sie lista dodatków tego wcześniejszego, podobnie przy getterze dałoby sie zmienić liste dodatków pizzy
        IO.println(
                String.format("Pizza 1 cena: %.2f",
                new Pizza.Builder(Rozmiar.MALA)
                .ciasto(Ciasto.GRUBE)
                .sos("cząstkowy")
                .dodatek("szynka")
                .dodatek("pieczarki")
                .pdwojnySer()
                .build()
                .cena())
        );
        IO.println(
                String.format("Pizza 2 cena: %.2f",
                        new Pizza.Builder(Rozmiar.SREDNIA)
                                .ciasto(Ciasto.CIENKIE)
                                .sos("pomidorowy")
                                .dodatek("pieczarki")
                                .build()
                                .cena())
        );
        IO.println(
                String.format("Pizza 3 cena: %.2f",
                        new Pizza.Builder(Rozmiar.DUZA)
                                .ciasto(Ciasto.CIENKIE)
                                .sos("pomidorowy")
                                .build()
                                .cena())
        );
    }
}
