package zad26;

public class RawAnalogSensorAdapter implements CzujnikTemperatury {
    private static final double MIN_C = -40.0;
    private static final double MAX_C = 85.0;
    private static final int MAX_RAW = 1023;

    private final String nazwa;
    private final RawAnalogSensor czujnik;

    public RawAnalogSensorAdapter(String nazwa, RawAnalogSensor czujnik) {
        this.nazwa = nazwa;
        this.czujnik = czujnik;
    }

    @Override
    public double odczytCelsjusz() {
        return MIN_C + czujnik.readRaw() * (MAX_C - MIN_C) / MAX_RAW;
    }

    @Override
    public String nazwa() {
        return nazwa + " (RAW)";
    }
}
