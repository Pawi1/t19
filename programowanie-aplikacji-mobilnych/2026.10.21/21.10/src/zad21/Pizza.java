package zad21;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Objects;

public final class Pizza {
    static final int MAX_DODATKOW = 6;
    private static final double CENA_DODATKU = 3.00;
    private static final double CENA_PODWOJNEGO_SERA = 4.00;

    private final Ciasto ciasto;
    private final Rozmiar rozmiar;
    private final String sos;
    private final ArrayList<String> dodatki;
    private final boolean czyPodwojnySer;

    public Ciasto getCiasto() {
        return ciasto;
    }

    public Rozmiar getRozmiar() {
        return rozmiar;
    }

    public String getSos() {
        return sos;
    }

    public boolean isCzyPodwojnySer() {
        return czyPodwojnySer;
    }
    public List<String> getDodatki() {
        return Collections.unmodifiableList(dodatki);
    }
    public Pizza(Builder b)
    {
        ciasto = b.ciasto;
        rozmiar = b.rozmiar;
        sos = b.sos;
        dodatki = new ArrayList<>(b.dodatki);
        czyPodwojnySer = b.czyPodwojnySer;
    }
    public double cena()
    {
        return rozmiar.cenaBazowa
                + dodatki.size() * CENA_DODATKU
                + (czyPodwojnySer ? CENA_PODWOJNEGO_SERA : 0);
    }
    public String paragon()
    {
        var sb = new StringBuilder();
        sb.append("--------- PARAGON ---------\n");
        sb.append(String.format("Pizza %s, ciasto %s%n", rozmiar, ciasto));
        sb.append(String.format("  sos: %s%n", sos));
        if (dodatki.isEmpty())
            sb.append("  bez dodatków\n");
        else
            for (var d : dodatki)
                sb.append(String.format("  + %s%n", d));
        if (czyPodwojnySer)
            sb.append("  + podwójny ser\n");
        sb.append(String.format("RAZEM: %.2f zł%n", cena()));
        sb.append("---------------------------");
        return sb.toString();
    }

    @Override
    public String toString() {
        return paragon();
    }

    public static class Builder
    {
        private final Rozmiar rozmiar;
        private final List<String> dodatki = new ArrayList<>();
        private Ciasto ciasto = Ciasto.CIENKIE;
        private String sos = "pomidorowy";
        private boolean czyPodwojnySer = false;
        public Builder(Rozmiar rozmiar)
        {
            this.rozmiar = Objects.requireNonNull(rozmiar);
        }
        public Builder sos(String sos) {
            this.sos = sos;
            return this;
        }
        public Builder ciasto(Ciasto ciasto) {
            this.ciasto = ciasto;
            return this;
        }
        public Builder dodatek(String dodatek) {
            this.dodatki.add(dodatek);
            return this;
        }
        public Builder podwojnySer() {
            this.czyPodwojnySer = true;
            return this;
        }
        public Pizza build()
        {
            if (dodatki.size() > MAX_DODATKOW)
                throw new IllegalArgumentException("Too many dodatki");
            return new Pizza(this);
        }
    }
}
