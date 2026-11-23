package zad29;

import java.util.ArrayList;

public class WyswietlaczStatystyk implements Obserwator {
    private final ArrayList<Double> historia = new ArrayList<>();

    @Override
    public void aktualizuj(Pomiar p) {
        historia.add(p.temperatura());
        var min = historia.stream().mapToDouble(Double::doubleValue).min().orElseThrow();
        var max = historia.stream().mapToDouble(Double::doubleValue).max().orElseThrow();
        var srednia = historia.stream().mapToDouble(Double::doubleValue).average().orElseThrow();
        IO.println(String.format("  [statyst.]  min %.1f, max %.1f, średnia %.1f (z %d pomiarów)",
                min, max, srednia, historia.size()));
    }
}
