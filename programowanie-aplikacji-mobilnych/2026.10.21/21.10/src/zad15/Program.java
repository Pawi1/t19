package zad15;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.TreeMap;

public class Program {
    /// Klasa Zadanie: tytul (String), priorytet (int 1–3), zrobione (boolean).
    /// Przechowywanie w ArrayList<Zadanie>. Funkcje:
    /// - dodaj zadanie, oznacz jako zrobione, usuń zrobione,
    /// - wypisz posortowane po priorytecie,
    /// - HashMap<Integer, Integer> – ile zadań jest dla każdego priorytetu.
    ///
    ///   [ ] (1) Oddać projekt
    ///   [x] (2) Kupić kabel USB-C
    ///   [ ] (3) Posprzątać biurko
    void main() {
        var zadania = new ArrayList<Zadanie>();
        while (true) {
            IO.println("""
                    1. dodaj zadanie,
                    2. oznacz jako zrobione,
                    3. usuń zrobione,
                    4. wypisz posortowane po priorytecie,
                    5. wypisz ile zadań jest dla każdego priorytetu.
                    0. koniec
                    """);
            var in = IO.readln("\nPodaj opcje: ");
            switch (in)
            {
                case "1":
                    var c1_tytul = IO.readln("Podaj tytuł zadania: ");
                    if (c1_tytul.isEmpty()) {
                        IO.println("Nie możesz podać pustego tytułu.");
                        break;
                    }
                    try {
                        var c1_priorytet = Integer.parseInt(IO.readln("Podaj priorytet (1-3): "));
                        if (c1_priorytet < 1 || c1_priorytet > 3)
                            IO.println("Priorytet musi być w zakresie 1-3.");
                        else
                            zadania.add(new Zadanie(c1_tytul, c1_priorytet));
                    } catch (NumberFormatException e) {
                        IO.println("To nie jest liczba.");
                    }
                    break;
                case "2":
                    for (var i = 0; i < zadania.size(); i++)
                        IO.println(String.format("%d: %s", i, zadania.get(i)));
                    try {
                        var c2_index = Integer.parseInt(IO.readln("Podaj numer zadania do oznaczenia jako zrobione: "));
                        if (c2_index < 0 || c2_index >= zadania.size())
                            IO.println("Nie ma takiego zadania.");
                        else
                            zadania.get(c2_index).zrobione = true;
                    } catch (NumberFormatException e) {
                        IO.println("To nie jest liczba.");
                    }
                    break;
                case "3":
                    zadania.removeIf(z -> z.zrobione);
                    IO.println("Usunięto zrobione zadania.");
                    break;
                case "4":
                    zadania.stream()
                            .sorted(Comparator.comparingInt(z -> z.priorytet))
                            .forEach(z -> IO.println(z.toString()));
                    break;
                case "5":
                    var c5_mapa = new TreeMap<Integer, Integer>();
                    for (var z : zadania)
                        c5_mapa.put(z.priorytet, c5_mapa.getOrDefault(z.priorytet, 0) + 1);
                    c5_mapa.forEach((priorytet, ile) -> IO.println(String.format("Priorytet %d: %d zadań", priorytet, ile)));
                    break;
                case "0":
                    return;
            }
        }
    }
}
