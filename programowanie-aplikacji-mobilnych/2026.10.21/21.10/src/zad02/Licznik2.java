package zad02;

public class Licznik2 {
    private int wartosc = 0;
    public synchronized void zwieksz()
    {
        wartosc ++;
    }
    public int getWartosc() {
        return wartosc;
    }
}
