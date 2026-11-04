package zad15;

public class Zadanie {
    String tytul;
    int priorytet;
    boolean zrobione;

    Zadanie(String tytul, int priorytet) {
        this.tytul = tytul;
        this.priorytet = priorytet;
        this.zrobione = false;
    }

    @Override
    public String toString() {
        return String.format("[%s] (%d) %s", zrobione ? "x" : " ", priorytet, tytul);
    }
}
