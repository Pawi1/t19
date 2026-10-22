package zad04;

public class PulaBiletow {
    private int bilety = 100;

    public synchronized boolean sprzedaz(int ilosc) {
        if (bilety-ilosc < 0)
            return false;
        bilety -= ilosc;
        return true;
    }

    public int getBilety() {
        return bilety;
    }
}
