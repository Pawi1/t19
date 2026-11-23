package zad01;

/// wersja a) BEZ synchronizacji
public class KontoBankowe {
    private int saldo;
    public KontoBankowe(int saldo) {
        this.saldo = saldo;
    }
    public void wplac(int kwota)
    {
        // de iure powinno sprawdzac czy wplacamy liczbe dodatnia
        if(kwota > 0)
            saldo += kwota;
    }
    public boolean wyplac(int kwota)
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
