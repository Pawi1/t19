package zad25;

public class StaryTerminalAdapter implements Platnosc {
    private final StaryTerminal terminal;
    private String status = "brak transakcji";

    public StaryTerminalAdapter(StaryTerminal terminal) {
        this.terminal = terminal;
    }

    @Override
    public boolean zaplac(double kwotaPLN) {
        var grosze = Math.round(kwotaPLN * 100);
        var kod = terminal.wykonajTransakcje(grosze, "PLN");
        status = switch (kod) {
            case 0 -> "OK";
            case 1 -> "Odrzucono";
            case 2 -> "Błąd połączenia";
            default -> "Nieznany kod: " + kod;
        };
        return kod == 0;
    }

    @Override
    public String status() {
        return status;
    }
}
