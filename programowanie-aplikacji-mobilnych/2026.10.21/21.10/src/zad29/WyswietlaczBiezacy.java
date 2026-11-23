package zad29;

public class WyswietlaczBiezacy implements Obserwator {
    @Override
    public void aktualizuj(Pomiar p) {
        IO.println(String.format("  [biezacy]   %.1f °C, %.0f%% wilgotności, %.1f hPa",
                p.temperatura(), p.wilgotnosc(), p.cisnienie()));
    }
}
