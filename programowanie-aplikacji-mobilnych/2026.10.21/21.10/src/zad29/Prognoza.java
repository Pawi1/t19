package zad29;

public class Prognoza implements Obserwator {
    private static final double TOLERANCJA = 0.5;

    private double poprzednieCisnienie = Double.NaN;

    @Override
    public void aktualizuj(Pomiar p) {
        if (Double.isNaN(poprzednieCisnienie)) {
            IO.println("  [prognoza]  brak danych do porównania");
        } else {
            var zmiana = p.cisnienie() - poprzednieCisnienie;
            var opis = zmiana > TOLERANCJA ? "poprawa"
                    : zmiana < -TOLERANCJA ? "pogorszenie"
                    : "bez zmian";
            IO.println(String.format("  [prognoza]  %s (%+.1f hPa)", opis, zmiana));
        }
        poprzednieCisnienie = p.cisnienie();
    }
}
