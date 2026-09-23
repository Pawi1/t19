// 4. Tablica wątków [poziom: normalny]
// Utwórz tablicę Thread[] watki o rozmiarze 5. W pętli utwórz 5 wątków, z których każdy wypisuje swój numer (0-4) oraz informację, że startuje,
// a następnie usypia się na losowy czas (Thread.sleep z losową wartością, np. 500-2000 ms).
// Uruchom wszystkie wątki z tablicy w jednej pętli, a w kolejnej, osobnej pętli wywołaj join() na każdym z nich — tak, aby program główny poczekał na zakończenie wszystkich wątków, zanim wypisze "Koniec programu".
class Zad4 implements Runnable {
    @Override
    public void run() {
        IO.println(Thread.currentThread().getName() + " Startuje…");
        try {
            Thread.sleep(new Random().nextInt(500,2000));
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        IO.println(Thread.currentThread().getName() + " Skończył…");
    }
}
void main() throws InterruptedException {
    Thread[] ths = {new Thread(new Zad4()),new Thread(new Zad4()),new Thread(new Zad4()),new Thread(new Zad4()),new Thread(new Zad4())};
    for (int i = 0;i<5;i++) {
        ths[i].setName(String.valueOf(i));
        ths[i].start();
    }
    for (var th : ths) {
        th.join();
    }
    IO.println("Koniec programu");
}