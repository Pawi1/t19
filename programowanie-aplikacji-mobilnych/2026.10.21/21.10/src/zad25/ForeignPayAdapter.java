package zad25;

public class ForeignPayAdapter implements Platnosc {
    private static final double KURS_EUR = 4.30;

    private final ForeignPayGateway gateway;
    private String status = "brak transakcji";

    public ForeignPayAdapter(ForeignPayGateway gateway) {
        this.gateway = gateway;
    }

    @Override
    public boolean zaplac(double kwotaPLN) {
        var eur = Math.round(kwotaPLN / KURS_EUR * 100) / 100.0;
        var ok = gateway.pay(eur);
        status = ok ? "OK" : "Odrzucono";
        return ok;
    }

    @Override
    public String status() {
        return status;
    }
}
