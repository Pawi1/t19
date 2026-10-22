package zad04;

import java.util.ArrayList;
import java.util.Random;

public class Program {
    void main() throws InterruptedException {
        /// Na koncert jest 100 biletów. Klasa PulaBiletow przechowuje liczbę
        /// dostępnych biletów. Kilka kas (wątków, np. 4) sprzedaje bilety
        /// w pętli: każda transakcja to losowo 1–4 bilety.
        ///
        /// Wymagania:
        /// - Nie wolno sprzedać więcej biletów niż jest w puli.
        /// - Jeśli klient chce 4, a zostały 2 – transakcja jest odrzucana
        ///   (kasa wypisuje komunikat) i kasa próbuje dalej.
        /// - Gdy bilety się skończą, wszystkie kasy kończą pracę.
        /// - Na koniec każda kasa wypisuje, ile biletów sprzedała,
        ///   a program sprawdza, czy suma = 100.
        ///
        /// Przykład wyjścia:
        ///   Kasa 2: sprzedano 3 (zostało 41)
        ///   Kasa 1: odrzucono 4 (zostało 2)
        ///   ...
        ///   Kasa 1: 27, Kasa 2: 24, Kasa 3: 25, Kasa 4: 24, RAZEM: 100
        var pula = new PulaBiletow();
        var sprzedane = new int[4];
        var kasa = new Runnable(){
            @Override
            public void run()
            {
                var numer = Integer.parseInt(Thread.currentThread().getName());
                var r = new Random();
                var calkowitaIlosc = 0;
                while (pula.getBilety() > 0)
                {
                    var ilosc = r.nextInt(1,4);
                    var wynik = pula.sprzedaz(ilosc);
                    if(wynik)
                        calkowitaIlosc += ilosc;
                    IO.println(String.format("Kasa %d: %s %d (zostało %d)",numer, wynik?"sprzedano":"odrzucono",ilosc,pula.getBilety()));
                }
                sprzedane[numer-1] = calkowitaIlosc;
            }
        };
        var thl = new ArrayList<Thread>();
        for (int i = 1; i <= 4; i++) {
            var th = new Thread(kasa);
            th.setName(String.valueOf(i));
            thl.add(th);
        }
        for (var th: thl)
        {
            th.start();
        }
        for (var th: thl)
        {
            th.join();
        }
        IO.println(String.format("\nKasa 1: %d, Kasa 2: %d, Kasa 3: %d, Kasa 4: %d, RAZEM: %d",sprzedane[0],sprzedane[1],sprzedane[2],sprzedane[3], (sprzedane[0]+sprzedane[1]+sprzedane[2]+sprzedane[3])));
    }
}
