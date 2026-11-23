package zad02;

/// c) z blokiem synchronized(this)
public class Licznik3 extends Licznik {
    @Override
    public void zwieksz()
    {
        synchronized (this)
        {
            super.zwieksz();
        }
    }
}
