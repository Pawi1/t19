package zad02;

/// b) z metodą synchronized
public class Licznik2 extends Licznik {
    @Override
    public synchronized void zwieksz()
    {
        super.zwieksz();
    }
}
