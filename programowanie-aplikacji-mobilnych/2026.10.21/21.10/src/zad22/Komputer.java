package zad22;

public class Komputer {
    private final String cpu;
    private final int ram;
    private final String gpu;
    private final Dysk dysk;
    private final int zasilacz;
    private final TypObudowy typObudowy;
    public Komputer(Builder b){
        cpu = b.cpu;
        ram = b.ram;
        gpu = b.gpu;
        dysk = b.dysk;
        zasilacz = b.zasilacz;
        typObudowy = b.typObudowy;
    }
    private static boolean jestPotegaDwojki(int n) {
        return n > 0 && (n & (n - 1)) == 0;
    }
    public String getProcesor() {
        return cpu;
    }

    public int getRam() {
        return ram;
    }

    public String getKartaGraficzna() {
        return gpu;
    }

    public Dysk getDysk() {
        return dysk;
    }
    public int getZasilacz() {
        return zasilacz;
    }

    public TypObudowy getTypObudowy() {
        return typObudowy;
    }

    @Override
    public String toString() {
        return String.format("Komputer - CPU: %s, GPU: %s, RAM: %d, Zasilacz: %dW, Dysk %dGB %s, Obudowa: %s",
                cpu,gpu,ram,zasilacz,dysk.pojemnosc(), dysk.typDysk(),typObudowy);
    }

    public static class Builder{
        private String cpu;
        private int ram;
        private String gpu;
        private Dysk dysk;
        private int zasilacz = 0;   // 0 = nie podano, dobierany automatycznie
        private TypObudowy typObudowy;
        public Builder procesor(String cpu) {
            this.cpu = cpu;
            return this;
        }
        public Builder ram(int ram) {
            if (!jestPotegaDwojki(ram)) {
                throw new IllegalArgumentException("ram must be power of 2");
            }
            this.ram = ram;
            return this;
        }
        public Builder kartaGraficzna(String gpu) {
            this.gpu = gpu;
            return this;
        }
        public Builder dysk(int pojemnosc, TypDysku typDysku) {
            this.dysk = new Dysk(pojemnosc, typDysku);
            return this;
        }
        public Builder zasilacz(int zasilacz) {
            this.zasilacz = zasilacz;
            return this;
        }
        public Builder typObudowy(TypObudowy typObudowy) {
            this.typObudowy = typObudowy;
            return this;
        }
        public Komputer build()
        {
            if (cpu == null || ram == 0)
                throw new IllegalArgumentException("cpu or ram must be set");
            if (zasilacz == 0)
                zasilacz = dobierzZasilacz();
            if (gpu != null && zasilacz < 650)
                throw new IllegalArgumentException("if gpu, zasilacz must be >= 650");
            return new Komputer(this);
        }
        /// brak zasilacza -> dobierany automatycznie
        private int dobierzZasilacz()
        {
            if (gpu != null)
                return ram >= 64 ? 850 : 750;
            return ram >= 64 ? 550 : 350;
        }
    }
}
