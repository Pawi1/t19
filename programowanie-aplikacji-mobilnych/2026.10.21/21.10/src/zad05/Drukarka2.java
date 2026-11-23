package zad05;

/// b) z synchronizacją - dokument drukuje się w całości
public class Drukarka2 extends Drukarka {
    @Override
    public synchronized void drukuj(String nazwaDokumentu, int liczbaLinii) throws InterruptedException {
        super.drukuj(nazwaDokumentu, liczbaLinii);
    }
}
