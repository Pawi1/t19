package zad17;

public class Sala2 extends Sala {
    @Override
    synchronized boolean rezerwuj(int miejsce, String klient) {
        if (miejsca.get(miejsce) != null)
            return false;
        try {
            Thread.sleep(r.nextInt(6));
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        miejsca.put(miejsce, klient);
        return true;
    }
}
