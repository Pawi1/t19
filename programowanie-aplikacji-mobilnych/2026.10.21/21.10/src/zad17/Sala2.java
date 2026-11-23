package zad17;

/// b) wersja z synchronized - sprawdzenie i zapis w JEDNYM kroku, brak kolizji
public class Sala2 extends Sala {
    @Override
    synchronized boolean rezerwuj(int miejsce, String klient) {
        return super.rezerwuj(miejsce, klient);
    }
}
