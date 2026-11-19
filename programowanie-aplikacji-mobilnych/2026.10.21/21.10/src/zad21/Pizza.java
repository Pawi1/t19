package zad21;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Objects;

final class Pizza {
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
        public Builder pdwojnySer() {
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
