package zad26;

/// Aplikacja stacji meteo oczekuje interfejsu:
///
///   interface CzujnikTemperatury {
///       double odczytCelsjusz();
///       String nazwa();
///   }
///
/// Kupiono czujniki od różnych producentów. Przepisz te klasy do
/// projektu – NIE WOLNO ich zmieniać: AmericanSensor, KelvinProbe,
/// RawAnalogSensor (0 = -40°C, 1023 = 85°C, zależność liniowa).
///
/// Napisz adaptery dla każdego czujnika. Klasa StacjaMeteo przechowuje
/// ArrayList<CzujnikTemperatury>, wypisuje odczyty i średnią:
///
///   Czujnik ogród (US):   21.3 °C
///   Czujnik piwnica (K):  12.8 °C
///   Czujnik dach (RAW):   18.1 °C
///   Średnia: 17.4 °C
///
/// Pytanie: czym różni się adapter obiektowy (kompozycja) od klasowego
/// (dziedziczenie)? Który zastosowałeś i dlaczego?

// ODP: adapter obiektowy trzyma adaptowany obiekt w polu (kompozycja) i deleguje do niego wywołania,
//      adapter klasowy dziedziczy po adaptowanej klasie i implementuje docelowy interfejs.
//      Użyłem obiektowego, bo:
//        * nie muszę nic zmieniać ani zakładać o klasach producentów (mogłyby być final),
//        * jeden adapter może opakować wiele obiektów / podmienić je w trakcie życia,
//        * w Javie nie ma wielokrotnego dziedziczenia, więc klasowy ogranicza do jednej klasy bazowej.
public class Program {
    void main() {
        var stacja = new StacjaMeteo();
        stacja.dodaj(new AmericanSensorAdapter("ogród", new AmericanSensor()));
        stacja.dodaj(new KelvinProbeAdapter("piwnica", new KelvinProbe()));
        stacja.dodaj(new RawAnalogSensorAdapter("dach", new RawAnalogSensor()));
        stacja.wypiszOdczyty();

        IO.println("\n--- drugi pomiar ---");
        stacja.wypiszOdczyty();
    }
}
