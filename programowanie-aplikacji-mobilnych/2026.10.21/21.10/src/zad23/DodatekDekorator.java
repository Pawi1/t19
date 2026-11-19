package zad23;

public abstract class DodatekDekorator implements Napoj{
    protected final Napoj napoj;

    protected DodatekDekorator(Napoj napoj) {
        this.napoj = napoj;
    }
}
