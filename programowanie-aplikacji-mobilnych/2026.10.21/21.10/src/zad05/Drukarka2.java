package zad05;

public class Drukarka2 {
    public synchronized void drukuj(String nazwaDokumentu, int liczbaLinii) throws InterruptedException {
        for (int i = 1; i <= liczbaLinii; i++) {
            IO.println(String.format("[%s] linia %d/%d",nazwaDokumentu,i,liczbaLinii));
            Thread.sleep(100);
        }
    }
}
