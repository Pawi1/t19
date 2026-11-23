package zad13;

import java.util.ArrayList;
import java.util.HashMap;

public class Program {
    /// HashMap<String, Integer> – klucz: produkt, wartość: liczba sztuk na stanie.
    /// HashMap<String, Double> – klucz: produkt, wartość: cena.
    /// - przyjmij dostawę (dodaje do istniejącego stanu),
    /// - sprzedaj (nie można sprzedać więcej niż jest),
    /// - produkty z małym stanem (< 5) – ArrayList<String>,
    /// - usuń produkty, których stan wynosi 0.
    /// - policz wartość całego magazynu.
    void main() {
        var magazyn = new HashMap<String,Integer>();
        var ceny = new HashMap<String, Double>();
        while (true) {
            IO.println("""
                    1. przyjmij dostawę,
                    2. sprzedaj,
                    3. wypisz produkty z małym stanem (< 5),
                    4. usuń produkty, których stan wynosi 0,
                    5. policz wartość całego magazynu,
                    6. pokaż / zmień cenę produktu.
                    0. koniec
                    """);
            var in = IO.readln("\nPodaj opcje: ");
            switch (in)
            {
                case "1":
                    var c1_key = IO.readln("Wpisz nazwę produktu: ");
                    if (c1_key.isEmpty()) {
                        IO.println("Nie możesz podać pustej nazwy.");
                        break;
                    }
                    try {
                        var c1_ilosc = Integer.parseInt(IO.readln("Podaj liczbę sztuk dostawy: "));
                        if (c1_ilosc <= 0) {
                            IO.println("Dostawa musi być większa od zera.");
                            break;
                        }
                        magazyn.merge(c1_key, c1_ilosc, Integer::sum);
                        if (!ceny.containsKey(c1_key))
                            ceny.put(c1_key, Double.parseDouble(IO.readln("Podaj cenę produktu: ")));
                    } catch (NumberFormatException e) {
                        IO.println("To nie jest liczba.");
                    }
                    break;
                case "2":
                    var c2_key = IO.readln("Wpisz nazwę produktu: ");
                    if (!magazyn.containsKey(c2_key)) {
                        IO.println("Nie ma takiego produktu w magazynie.");
                        break;
                    }
                    try {
                        var c2_ilosc = Integer.parseInt(IO.readln("Podaj liczbę sztuk do sprzedania: "));
                        var c2_stan = magazyn.get(c2_key);
                        if (c2_ilosc <= 0)
                            IO.println("Sprzedaż musi być większa od zera.");
                        else if (c2_ilosc > c2_stan)
                            IO.println(String.format("Nie można sprzedać %d sztuk, dostępne: %d.", c2_ilosc, c2_stan));
                        else
                            magazyn.put(c2_key, c2_stan - c2_ilosc);
                    } catch (NumberFormatException e) {
                        IO.println("To nie jest liczba.");
                    }
                    break;
                case "3":
                    var c3_malyStan = new ArrayList<String>();
                    for (var e : magazyn.entrySet())
                        if (e.getValue() < 5)
                            c3_malyStan.add(e.getKey());
                    if (c3_malyStan.isEmpty())
                        IO.println("Brak produktów z małym stanem.");
                    else
                        c3_malyStan.forEach(p -> IO.println(String.format("%s: %d szt.", p, magazyn.get(p))));
                    break;
                case "4":
                    magazyn.values().removeIf(v -> v == 0);
                    IO.println("Usunięto produkty o stanie 0.");
                    break;
                case "5":
                    var c5_wartosc = 0.0;
                    for (var e : magazyn.entrySet())
                        c5_wartosc += e.getValue() * ceny.getOrDefault(e.getKey(), 0.0);
                    IO.println(String.format("Wartość magazynu: %.2f", c5_wartosc));
                    break;
                case "6":
                    var c6_key = IO.readln("Wpisz nazwę produktu: ");
                    if (!ceny.containsKey(c6_key)) {
                        IO.println("Nie ma takiego produktu w magazynie.");
                        break;
                    }
                    IO.println(String.format("Aktualna cena %s: %.2f", c6_key, ceny.get(c6_key)));
                    var c6_nowa = IO.readln("Nowa cena (Enter = bez zmian): ").strip();
                    if (c6_nowa.isEmpty())
                        break;
                    try {
                        ceny.put(c6_key, Double.parseDouble(c6_nowa));
                        IO.println(String.format("Zmieniono cenę na %.2f", ceny.get(c6_key)));
                    } catch (NumberFormatException e) {
                        IO.println("To nie jest liczba.");
                    }
                    break;
                case "0":
                    return;
            }
        }
    }
}
