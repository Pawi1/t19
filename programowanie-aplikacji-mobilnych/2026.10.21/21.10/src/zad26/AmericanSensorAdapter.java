package zad26;

public class AmericanSensorAdapter implements CzujnikTemperatury {
    private final String nazwa;
    private final AmericanSensor czujnik;

    public AmericanSensorAdapter(String nazwa, AmericanSensor czujnik) {
        this.nazwa = nazwa;
        this.czujnik = czujnik;
    }

    @Override
    public double odczytCelsjusz() {
        return (czujnik.getFahrenheit() - 32) * 5 / 9;
    }

    @Override
    public String nazwa() {
        return nazwa + " (US)";
    }
}
