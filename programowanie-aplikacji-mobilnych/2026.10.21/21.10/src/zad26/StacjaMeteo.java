package zad26;

import java.util.ArrayList;

public class StacjaMeteo {
    private final ArrayList<CzujnikTemperatury> czujniki = new ArrayList<>();

    public void dodaj(CzujnikTemperatury czujnik) {
        czujniki.add(czujnik);
    }

    public void wypiszOdczyty() {
        var suma = 0.0;
        for (var c : czujniki) {
            var odczyt = c.odczytCelsjusz();
            suma += odczyt;
            IO.println(String.format("Czujnik %-14s %4.1f °C", c.nazwa() + ":", odczyt));
        }
        IO.println(String.format("Średnia: %.1f °C", suma / czujniki.size()));
    }
}
