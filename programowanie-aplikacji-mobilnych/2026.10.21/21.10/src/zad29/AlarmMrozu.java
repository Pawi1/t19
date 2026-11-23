package zad29;

public class AlarmMrozu implements Obserwator {
    @Override
    public void aktualizuj(Pomiar p) {
        if (p.temperatura() < 0)
            IO.println(String.format("  [ALARM]     mróz! %.1f °C", p.temperatura()));
    }
}
