package zad02;

public class Licznik3 {
    private int wartosc = 0;
    public void zwieksz()
    {
        synchronized (this)
        {
            wartosc ++;
        }
    }
    public int getWartosc() {
        return wartosc;
    }
}
