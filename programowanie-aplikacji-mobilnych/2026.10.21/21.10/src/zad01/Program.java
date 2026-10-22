package zad01;

import java.util.ArrayList;

public class Program {
    void main()
    {
        /// Wersja 1: 5010, 5000, 6560
        /// Wersja 2: 5000, 5000, 5000
        /// Odp: Bez synchronized jeden wątek odejmuje/dodaje od salda, który w międzyczasie został zmieniony przez inny wątek, przez co nadpisuja sie albo zmieniaja na nieaktualnych danych
        /// Uruchom 4 wątki: 2 wątki wpłacają po 10 zł 1000 razy, 2 wątki wypłacają
        /// po 10 zł 1000 razy. Saldo początkowe: 5000 zł.
        ///
        /// a) Najpierw wersja BEZ synchronizacji. Uruchom program kilka razy
        ///    i zapisz w komentarzu, jakie salda otrzymałeś.
        /// b) Następnie wersja z synchronized. Saldo końcowe musi być przewidywalne.
        ///
        /// Pytanie do odpowiedzi w komentarzu: dlaczego w wersji a) wynik się różni?
        var kb = new KontoBankowe(5000);

        var run1 = new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < 1000; i++) {
                    kb.wplac(10);
                }
            }
        };
        var run2 = new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < 1000; i++) {
                    kb.wyplac(10);
                }
            }
        };
        var lth = new ArrayList<Thread>();
        lth.add(new Thread(run1));
        lth.add(new Thread(run1));
        lth.add(new Thread(run2));
        lth.add(new Thread(run2));
        for(var th : lth)
        {
            th.start();
        }
        IO.println(kb.getSaldo());
    }
}
