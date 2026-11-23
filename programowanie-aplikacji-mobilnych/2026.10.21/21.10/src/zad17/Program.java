package zad17;

import java.util.ArrayList;

public class Program {
    /// Sala ma 30 miejsc (numery 1–30). Rezerwacje przechowuje
    /// HashMap<Integer, String> – numer miejsca -> imię klienta.
    ///
    /// Klasa Klient implements Runnable – imię i lista ulubionych miejsc
    /// (ArrayList<Integer>, 3 losowe numery). Klient próbuje zarezerwować
    /// kolejno swoje miejsca, aż mu się uda (jedno miejsce na klienta).
    /// Jeśli żadne z ulubionych nie jest wolne – rezygnuje.
    ///
    /// - ArrayList<Thread> z 20 klientami uruchomionymi jednocześnie,
    /// - metoda rezerwuj(int miejsce, String klient) sprawdza i zapisuje
    ///   w JEDNYM kroku (synchronized),
    /// - przed sprawdzeniem krótki sleep, żeby łatwiej było trafić na kolizję.
    ///
    /// a) Sala (bez synchronized) – zgłoszonych sukcesów bywa więcej
    ///    niż faktycznie zajętych miejsc (ktoś kogoś nadpisał),
    /// b) Sala2 (z synchronized) – te liczby są zawsze równe.
    void main() throws InterruptedException {
        uruchom("bez synchronized", new Sala());
        uruchom("z synchronized", new Sala2());
    }

    private void uruchom(String nazwa, Sala sala) throws InterruptedException {
        IO.println(String.format("\n--- %s ---", nazwa));
        var zarezerwowani = new ArrayList<String>();
        var zrezygnowali = new ArrayList<String>();
        var watki = new ArrayList<Thread>();

        for (var i = 1; i <= 20; i++) {
            var klient = new Klient("Klient-" + i, sala, zarezerwowani, zrezygnowali);
            var w = new Thread(klient);
            watki.add(w);
            w.start();
        }
        for (var w : watki)
            w.join();

        sala.wypiszPlan();
        IO.println("Zrezygnowali: " + String.join(", ", zrezygnowali));
        IO.println(String.format("Zgłoszonych sukcesów: %d, faktycznie zajętych miejsc: %d",
                zarezerwowani.size(), sala.miejsca.size()));
    }
}
