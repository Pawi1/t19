// 3. Drukarka na cały wydział [poziom: normalny]
// Napisz klasę Drukarka z metodą drukuj(String dokument, String uzytkownik), która symuluje drukowanie (np. Thread.sleep(500)) i wypisuje,
// kto aktualnie korzysta z drukarki. Utwórz cztery wątki reprezentujące różnych użytkowników,
// którzy chcą jednocześnie wydrukować dokument na tej samej drukarce. Użyj bloku synchronized (a nie całej metody) tak, aby tylko jeden użytkownik naraz
// mógł korzystać z drukarki, a pozostali czekali w kolejce.

class Drukarka {
    boolean isFree = true;
    public void drukuj(String doc, String user) throws InterruptedException {
        while (true) {
            synchronized (this) {
                if (isFree) {
                    isFree = false;
                    break;
                }
            }
            Thread.sleep(250);
        }
        Thread.sleep(500);
        IO.println("Dokument: " + doc + " Użytkownik: " + user);
        synchronized (this) {
            isFree = true;
        }
    }
}
class Zad3 implements Runnable {
    String doc,user;
    Drukarka printer;
    public Zad3(String doc, String user, Drukarka printer) {
        this.doc = doc;
        this.user = user;
        this.printer = printer;
    }

    @Override
    public void run() {
        try {
            printer.drukuj(doc,user);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
    }
}
void main() throws InterruptedException {
    var printer = new Drukarka();
    var ths = new ArrayList<>(List.of(new Thread(new Zad3("dokument 1","Adam",printer)), new Thread(new Zad3("dokument 2","Basia",printer)), new Thread(new Zad3("dokument 3","Jan",printer)), new Thread(new Zad3("dokument 4","Andrzej",printer))));
    for (var th : ths) {
        th.start();
    }
    for (var th : ths) {
        th.join();
    }
}