package zad01;

public class KontoBankowe {
    private int saldo;
    public KontoBankowe(int saldo) {
        this.saldo = saldo;
    }
    public synchronized void wplac(int kwota)
    {
        // de iure powinno sprawdzac czy wplacamy liczbe dodatnia
        if(kwota > 0)
            saldo += kwota;
    }
    public synchronized boolean wyplac(int kwota)
    {
        if(saldo - kwota < 0 )
            return false;
        saldo -= kwota;
        return true;
    }

    public int getSaldo() {
        return saldo;
    }
}
