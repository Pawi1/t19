package zad01;

/// wersja b) z synchronized - saldo końcowe jest przewidywalne
public class KontoBankowe2 extends KontoBankowe {
    public KontoBankowe2(int saldo) {
        super(saldo);
    }

    @Override
    public synchronized void wplac(int kwota) {
        super.wplac(kwota);
    }

    @Override
    public synchronized boolean wyplac(int kwota) {
        return super.wyplac(kwota);
    }

    @Override
    public synchronized int getSaldo() {
        return super.getSaldo();
    }
}
