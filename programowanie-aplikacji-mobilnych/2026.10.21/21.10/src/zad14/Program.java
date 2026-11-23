package zad14;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Random;

public class Program {
    /// HashMap<String, String> – klucz: słowo polskie, wartość: tłumaczenie.
    /// Tryb nauki: program losuje słowo, użytkownik wpisuje tłumaczenie.
    /// - błędne odpowiedzi trafiają do ArrayList<String> "do powtórki",
    /// - po rundzie program pyta tylko o słowa z powtórki,
    /// - na końcu wynik: dobre/złe odpowiedzi w procentach.
    void main() {
        var slownik = new HashMap<String, String>();
        slownik.put("kot", "cat");
        slownik.put("pies", "dog");
        slownik.put("dom", "house");
        slownik.put("woda", "water");
        slownik.put("chleb", "bread");
        slownik.put("drzewo", "tree");
        slownik.put("książka", "book");
        slownik.put("stół", "table");
        slownik.put("okno", "window");
        slownik.put("samochód", "car");
        slownik.put("słońce", "sun");
        slownik.put("niebo", "sky");
        slownik.put("noc", "night");
        slownik.put("dzień", "day");
        slownik.put("miasto", "city");

        var r = new Random();
        var dobre = 0;
        var zle = 0;
        var bledneSlowa = new HashSet<String>();   // słowa, w których pomylił się choć raz
        var doPowtorki = new ArrayList<>(slownik.keySet());

        while (!doPowtorki.isEmpty()) {
            var nastepnaRunda = new ArrayList<String>();
            while (!doPowtorki.isEmpty()) {
                var slowo = doPowtorki.remove(r.nextInt(doPowtorki.size()));
                var odp = IO.readln(String.format("Jak przetłumaczyć '%s'? ", slowo));
                if (odp.equalsIgnoreCase(slownik.get(slowo))) {
                    IO.println("Dobrze");
                    dobre++;
                } else {
                    IO.println(String.format("Źle, poprawna odpowiedź: %s", slownik.get(slowo)));
                    zle++;
                    bledneSlowa.add(slowo);
                    nastepnaRunda.add(slowo);
                }
            }
            if (!nastepnaRunda.isEmpty())
                IO.println("\n-- Powtórka --");
            doPowtorki = nastepnaRunda;
        }

        // wynik liczony po słowach: ile z 15 fiszek umiał od pierwszego razu
        var slow = slownik.size();
        var odRazu = slow - bledneSlowa.size();
        IO.println(String.format("\nWynik: %d/%d słów od pierwszego razu (%.2f%%), %d/%d z błędem (%.2f%%)",
                odRazu, slow, 100.0 * odRazu / slow,
                bledneSlowa.size(), slow, 100.0 * bledneSlowa.size() / slow));
        // dla porównania wszystkie próby (razem z powtórkami)
        var razem = dobre + zle;
        IO.println(String.format("Wszystkie próby: dobre %d/%d (%.2f%%), złe %d/%d (%.2f%%)",
                dobre, razem, 100.0 * dobre / razem,
                zle, razem, 100.0 * zle / razem));
    }
}
