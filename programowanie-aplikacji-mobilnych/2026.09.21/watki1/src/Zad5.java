// 5. Równoległe sumowanie tablicy [poziom: docelowy]
// Masz dużą tablicę int[] liczby o rozmiarze np. 1 000 000, wypełnioną losowymi liczbami.
// Podziel tablicę na 4 równe fragmenty i utwórz tablicę Thread[4], gdzie każdy wątek liczy sumę swojego fragmentu i zapisuje wynik
// do wspólnej tablicy long[] czesciowe_sumy pod swoim indeksem (każdy wątek pisze wyłącznie do własnej komórki,
// więc synchronizacja tutaj nie jest potrzebna — zastanów się, dlaczego). Po zakończeniu wszystkich wątków (join())
// zsumuj wartości z czesciowe_sumy i wypisz wynik końcowy. Zmierz czas wykonania (System.currentTimeMillis()) i porównaj
// z wersją jednowątkową, która liczy sumę całej tablicy w pojedynczej pętli.
class Zad5 implements Runnable {
    int[] tab;
    long[] sum;
    int j;

    public Zad5(int[] tab, long[] sum, int j) {
        this.tab = tab;
        this.sum = sum;
        this.j = j;
    }
    @Override
    public void run() {
        for (var i : tab) {
            sum[j] += i;
        }
    }
}

void main() throws InterruptedException {
    var tab = new int[1000000];
    var r = new Random();
    for (int i = 0; i < 1000000; i++) {
        tab[i] = r.nextInt(9999);
    }

    var tab2 = new int[4][];
    tab2[0] = Arrays.copyOfRange(tab, 0, 250000);
    tab2[1] = Arrays.copyOfRange(tab, 250000, 500000);
    tab2[2] = Arrays.copyOfRange(tab, 500000, 750000);
    tab2[3] = Arrays.copyOfRange(tab, 750000, 1000000);
    var sum = new long[4];
    var ths = new ArrayList<Thread>();
    for (int i = 0; i < 4; i++) {
        ths.add(new Thread(new Zad5(tab2[i],sum,i)));
    }
    for (var th : ths) {
        th.start();
    }
    for (var th : ths) {
        th.join();
    }
    IO.println(Arrays.stream(sum).sum());
}