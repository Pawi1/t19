//2. Wspólne konto bankowe [poziom: normalny]
//Napisz klasę KontoBankowe z polem saldo oraz zsynchronizowanymi metodami wplac(kwota) i wyplac(kwota).
// Metoda wyplac nie powinna pozwolić na spadek salda poniżej zera — jeśli brakuje środków, ma wypisać komunikat i nic nie zmieniać.
// Utwórz trzy wątki reprezentujące trzech klientów, którzy w pętli losowo wpłacają i wypłacają różne kwoty z tego samego konta.
// Uruchom je równolegle i sprawdź, czy saldo końcowe jest zawsze poprawne (zgodne z sumą operacji).
public int sumExpected = 0;
class KontoBankowe
{
    int saldo;
    synchronized void wyplac(int kwota)
    {
        if(saldo - kwota >= 0)
            saldo -= kwota;
        else
            IO.println("Nie masz tyle pieniedzy");
    }
    synchronized void wplac(int kwota)
    {
        saldo += kwota;
    }
}
class ThrZad2 implements Runnable
{
    KontoBankowe konto;
    public ThrZad2(KontoBankowe konto) {
        this.konto = konto;
    }

    @Override
    public void run() {
        var r = new Random();
        for(int i = 0; i < r.nextInt(1000);i++)
        {
            int change = r.nextInt(1000);
            if(r.nextBoolean()) {
                konto.wplac(change);
                sumExpected += change;
            }
            else
            {
                konto.wyplac(change);
                if(sumExpected - change >= 0)
                    sumExpected -= change;
            }
        }
    }
}
void main() throws InterruptedException {
    var konto = new KontoBankowe();
    var ths = new ArrayList<Thread>(List.of(new Thread(new ThrZad2(konto)),new Thread(new ThrZad2(konto)), new Thread(new ThrZad2(konto))));
    for (var th : ths)
        th.start();
    for (var th : ths)
        th.join();
    IO.println(konto.saldo);
    IO.println(sumExpected);
}