package zad18;

import java.util.ArrayList;

public class Logger {
    ArrayList<String> logi = new ArrayList<>();

    void zapisz(String modul, String poziom, String tresc) {
        logi.add(String.format("[%s] %s: %s", poziom, modul, tresc));
    }
}
