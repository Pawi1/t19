//1. Wyścig o wspólny licznik [poziom: śmieszny]
//Utwórz klasę Licznik z polem int wartosc oraz metodą increment() (na razie bez synchronized), która zwiększa wartosc o 1.
// Uruchom dwa wątki, z których każdy wywołuje increment() 100 000 razy na tym samym obiekcie Licznik.
// Poczekaj na zakończenie obu wątków (join()) i wypisz końcową wartość — zauważ, że różni się ona od oczekiwanej (200 000).
// Dodaj słowo kluczowe synchronized do metody increment() i uruchom program ponownie — porównaj wyniki.
class Licznik
{
    public Licznik(int wartosc)
    {
        this.wartosc = wartosc;
    }
    int wartosc;
    void increment()
    {
        wartosc++;
    }
}
class ThrZad1 implements Runnable
{
    Licznik licznik;
    public ThrZad1(Licznik licznik) {
        this.licznik = licznik;
    }

    @Override
    public void run() {
        for(int i = 0;i<100000;i++)
        {
            licznik.increment();
        }
    }
}
void main() throws InterruptedException {
    var licznik = new Licznik(0);
    var t1 = new Thread(new ThrZad1(licznik));
    var t2 = new Thread(new ThrZad1(licznik));
    t1.start();
    t2.start();
    t1.join();
    t2.join();
    IO.println(licznik.wartosc);
}