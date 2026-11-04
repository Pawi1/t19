package zad12;

import java.util.ArrayList;
import java.util.HashMap;
public class Program {
    /// HashMap<String, ArrayList<Integer>> – klucz: uczeń, wartość: jego oceny.
    /// - dodaj ucznia, dodaj ocenę konkretnemu uczniowi,
    /// - wypisz każdego ucznia z ocenami i średnią,
    /// - znajdź ucznia z najwyższą średnią,
    /// - wypisz uczniów zagrożonych (średnia < 2.0).
    ///
    ///   Kowalski: [5, 4, 6] śr. 5.00
    ///   Nowak:    [2, 1, 2] śr. 1.67  ZAGROŻONY
    void main() {
        HashMap<String, ArrayList<Integer>> dziennik = new HashMap<>();
        while (true) {
            IO.println("""
                    1. dodaj ucznia, dodaj ocenę konkretnemu uczniowi,
                    2. wypisz każdego ucznia z ocenami i średnią,
                    3. znajdź ucznia z najwyższą średnią,
                    4. wypisz uczniów zagrożonych (średnia < 2.0).
                    0. koniec
                    """);
            var in = IO.readln("\nPodaj opcje: ");
            switch (in)
            {
                case "1":
                    var c1_key = IO.readln("Wpisz imie i nazwisko ucznia: ");
                    if (c1_key.isEmpty()) {
                        IO.println("Nie możesz pustego imienia.");
                        break;
                    }
                    var c1_value = IO.readln("Podaj nową ocene ucznia (wpisz n, jak nie chcesz dodawac nowej oceny): ");
                    var c1_list = dziennik.get(c1_key) == null ? new ArrayList<Integer>(): dziennik.get(c1_key);
                    if (!c1_value.equals("n"))
                        c1_list.add(Integer.parseInt(c1_value));
                    dziennik.put(c1_key, c1_list);
                    break;
                case "2":
                    dziennik.forEach((k, v) -> {
                        IO.print(String.format("Uczeń %s:\n\tOceny: %s ",k,v.toString()));
                        IO.println(String.format("\n\tŚrednia: %.2f",v.stream().mapToInt(Integer::intValue).average().orElse(0.0)));
                    });
                    break;
                case "3":
                    var best = "";
                    double bestAvg = -1;
                    for (var e : dziennik.entrySet()) {
                        double avg = e.getValue().stream().mapToInt(Integer::intValue).average().orElse(0.0);
                        if (avg > bestAvg) {
                            bestAvg = avg;
                            best = e.getKey();
                        }
                    }
                    if (best.isEmpty())
                        IO.println("Brak uczniów");
                    else
                        IO.println(String.format("Najwyższa średnia: %s (%.2f)", best, bestAvg));
                    break;
                case "4":
                    dziennik.forEach((k, v) -> {
                        double avg = v.stream().mapToInt(Integer::intValue).average().orElse(0.0);
                        if (!v.isEmpty() && avg < 2.0)
                            IO.println(String.format("%s: %s śr. %.2f ZAGROŻONY", k, v, avg));
                    });
                    break;
                case  "0":
                    return;
            }
        }
    }
}
