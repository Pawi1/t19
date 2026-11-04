package zad20;

import java.util.ArrayList;
import java.util.HashMap;

public class Robotnik implements Runnable {
    String nazwa;
    ArrayList<Runnable> kolejka;
    HashMap<String, Integer> wykonane;

    Robotnik(String nazwa, ArrayList<Runnable> kolejka, HashMap<String, Integer> wykonane) {
        this.nazwa = nazwa;
        this.kolejka = kolejka;
        this.wykonane = wykonane;
    }

    Runnable pobierzZadanie() {
        synchronized (kolejka) {
            if (kolejka.isEmpty())
                return null;
            return kolejka.remove(0);
        }
    }

    @Override
    public void run() {
        Runnable zadanie;
        while ((zadanie = pobierzZadanie()) != null) {
            IO.println(String.format("%s wykonuje zadanie", nazwa));
            zadanie.run();
            synchronized (wykonane) {
                wykonane.put(nazwa, wykonane.getOrDefault(nazwa, 0) + 1);
            }
        }
    }
}
