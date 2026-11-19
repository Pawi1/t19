package zad21;

public enum Rozmiar {
    MALA(20.00),
    SREDNIA(28.00),
    DUZA(36.00);
    final double cenaBazowa;
    Rozmiar(double cenaBazowa) {
        this.cenaBazowa = cenaBazowa;
    }
}
