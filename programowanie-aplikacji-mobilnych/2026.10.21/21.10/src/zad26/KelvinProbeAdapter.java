package zad26;

public class KelvinProbeAdapter implements CzujnikTemperatury {
    private final String nazwa;
    private final KelvinProbe czujnik;

    public KelvinProbeAdapter(String nazwa, KelvinProbe czujnik) {
        this.nazwa = nazwa;
        this.czujnik = czujnik;
    }

    @Override
    public double odczytCelsjusz() {
        return czujnik.readKelvin() - 273.15;
    }

    @Override
    public String nazwa() {
        return nazwa + " (K)";
    }
}
