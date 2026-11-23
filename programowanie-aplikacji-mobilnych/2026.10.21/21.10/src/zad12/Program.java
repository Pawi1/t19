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
        var dziennik = new HashMap<String, ArrayList<Integer>>();
        while (true) {
            IO.println("""
                    1. dodaj ucznia
                    2. dodaj ocenę konkretnemu uczniowi
                    3. wypisz każdego ucznia z ocenami i średnią
                    4. znajdź ucznia z najwyższą średnią
                    5. wypisz uczniów zagrożonych (średnia < 2.0)
                    0. koniec
                    """);
            var in = IO.readln("\nPodaj opcje: ");
            switch (in)
            {
                case "1":
                    var c1_key = IO.readln("Wpisz imie i nazwisko ucznia: ").strip();
                    if (c1_key.isEmpty()) {
                        IO.println("Nie możesz pustego imienia.");
                        break;
                    }
                    if (dziennik.containsKey(c1_key))
                        IO.println("Taki uczeń już jest w dzienniku");
                    else {
                        dziennik.put(c1_key, new ArrayList<>());
                        IO.println("Dodano ucznia " + c1_key);
                    }
                    break;
                case "2":
                    var c2_key = IO.readln("Wpisz imie i nazwisko ucznia: ").strip();
                    var c2_list = dziennik.get(c2_key);
                    if (c2_list == null) {
                        IO.println("Nie ma takiego ucznia w dzienniku");
                        break;
                    }
                    try {
                        var c2_ocena = Integer.parseInt(IO.readln("Podaj ocene (1-6): "));
                        if (c2_ocena < 1 || c2_ocena > 6)
                            IO.println("Ocena musi być z zakresu 1-6");
                        else {
                            c2_list.add(c2_ocena);
                            IO.println("Dodano ocene " + c2_ocena + " dla " + c2_key);
                        }
                    } catch (NumberFormatException e) {
                        IO.println("To nie jest liczba");
                    }
                    break;
                case "3":
                    dziennik.forEach((k, v) -> {
                        var avg = v.stream().mapToInt(Integer::intValue).average().orElse(0.0);
                        IO.println(String.format("%s: %s śr. %.2f%s", k, v, avg,
                                !v.isEmpty() && avg < 2.0 ? "  ZAGROŻONY" : ""));
                    });
                    break;
                case "4":
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
                case "5":
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
