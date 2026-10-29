package zad07;

import java.util.ArrayList;

public class Program {
    /// ArrayList<Integer> z ocenami (1–6). Napisz metody:
    /// - dodajOcene(int ocena) – odrzuca oceny spoza zakresu,
    /// - srednia(), najwyzsza(), najnizsza(),
    /// - ileRazy(int ocena) – ile razy wystąpiła dana ocena,
    /// - usunNajnizsza() – usuwa jedną najniższą ocenę.
    ///
    /// Uwaga na pułapkę: oceny.remove(1) vs oceny.remove(Integer.valueOf(1)).
    /// Opisz różnicę w komentarzu.

    ArrayList<Integer> oceny = new ArrayList<>();
    void dodajOcene(int ocena)
    {
        if(ocena >= 1 && ocena <= 6)
            oceny.add(ocena);
    }
    double srednia()
    {
        return oceny.stream().mapToInt(Integer::intValue).average().getAsDouble();
    }
    int najnizsza()
    {
        return oceny.stream().min(Integer::compare).get();
    }
    int najwieksza()
    {
        return oceny.stream().max(Integer::compare).get();
    }
    int ileRazy(int ocena)
    {
        return (int) oceny.stream().filter(e -> e.equals(ocena)).count();
    }
    void usunNajnizsza()
    {
        oceny.stream().min(Integer::compare).ifPresent(e -> oceny.remove(e));
        // oceny.remove(1) vs oceny.remove(Integer.valueOf(1))
        // oceny.remove(Integer.valueOf(1)); wywołuje remove(Object o), usuwa pierwszy nadetkany element listy zgadzający się z argumentem
        // oceny.remove(1); wywołuje remove(int index), usuwa element o danym indexie
        // W moim przypadku leci po Object o, bo mam <Integer> w array, które później jest w streamie itd, nie mapuje na int-a (mapToInt) to nie mam primitywu i tego problemu z indexem
    }

    void main() {
        dodajOcene(5);
        dodajOcene(-1); // nie doda
        dodajOcene(6);
        dodajOcene(3);
        dodajOcene(3);
        dodajOcene(7); // nie doda
        IO.println("Lista ocen:");
        oceny.forEach(System.out::println);
        IO.println(String.format("\nŚrednia ocen: %.2f", srednia()));
        IO.println(String.format("Najnisza ocena: %d", najnizsza()));
        IO.println(String.format("Najwyższa ocena: %d", najwieksza()));
        IO.println(String.format("Ile razy występuje ocena '3': %d", ileRazy(3)));
        IO.println("\nUsunięcie najniższej oceny:");
        usunNajnizsza();
        oceny.forEach(System.out::println);
    }
}
