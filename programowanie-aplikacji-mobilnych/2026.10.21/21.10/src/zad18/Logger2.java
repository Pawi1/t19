package zad18;

public class Logger2 extends Logger {
    @Override
    synchronized void zapisz(String modul, String poziom, String tresc) {
        logi.add(String.format("[%s] %s: %s", poziom, modul, tresc));
    }
}
