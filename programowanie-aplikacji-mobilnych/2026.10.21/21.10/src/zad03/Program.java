package zad03;

import java.util.ArrayList;

public class Program {
    static public ArrayList<String> wyniki = new ArrayList<>();
    void main() throws InterruptedException {
        /// Klasa Zolw implementuje Runnable. Każdy żółw ma imię i musi przejść
        /// trasę 20 kroków. Po każdym kroku zasypia na losowy czas 50–300 ms
        /// i wypisuje postęp, np.:
        ///
        ///   Franklin: krok 7/20
        ///   Leonardo: krok 9/20
        ///
        /// Uruchom 5 żółwi jednocześnie. Program główny czeka na wszystkich
        /// (join()), a na końcu wypisuje kolejność dotarcia do mety:
        ///
        ///   1. Leonardo
        ///   2. Franklin
        ///   ...
        ///
        /// Wskazówka: lista wyników jest współdzielona – zadbaj o synchronizację
        /// przy dopisywaniu do niej.
        var thl = new ArrayList<Thread>();
        thl.add(new Thread(new Zolw("Franklin")));
        thl.add(new Thread(new Zolw("Leonardo")));
        thl.add(new Thread(new Zolw("Hans")));
        thl.add(new Thread(new Zolw("Gregory")));
        thl.add(new Thread(new Zolw("Oliver")));
        for (var th : thl) {
            th.start();
        }
        for (var th : thl) {
            th.join();
        }
        IO.println();
        var i = 0;
        for(var s: wyniki){
            IO.println(String.format("%d. %s",++i,s));
        }
    }
}
