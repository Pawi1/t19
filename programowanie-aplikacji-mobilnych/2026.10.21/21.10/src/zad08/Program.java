package zad08;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Program {
    /// ArrayList<String> z 15 imionami (wpisane w kodzie). Wypisz:
    /// - imiona posortowane alfabetycznie i odwrotnie,
    /// - imiona dłuższe niż 5 liter (nowa lista),
    /// - imiona zaczynające się na podaną literę,
    /// - najdłuższe imię,
    /// - listę bez duplikatów (zachowaj kolejność).
    ///
    /// Usuń z listy wszystkie imiona żeńskie (kończące się na "a") –
    /// zrób to poprawnie (Iterator lub removeIf), a w komentarzu
    /// wyjaśnij, czemu usuwanie w pętli for-each rzuca wyjątek.
    void main()
    {
        var imiona = new ArrayList<>(List.of("Anna", "Piotr", "Kasia", "Marek", "Ola", "Tomek", "Zofia", "Tomek", "Magda", "Paweł", "Ewa", "Michał", "Karolina", "Adam", "Basia"));
        IO.println("Imiona:");
        imiona.forEach(System.out::println);
        IO.println("\nImiona posortowane:");
        imiona.stream().sorted().forEach(System.out::println);
        IO.println("\nImiona posortowane odwrotnie:");
        imiona.stream().sorted(Comparator.reverseOrder()).forEach(System.out::println);

        IO.println("\nDruga lista imion dłuższych od 5:");
        ArrayList<String> imiona2 = imiona.stream().filter(im -> im.length() > 5).collect(ArrayList::new, ArrayList::add, ArrayList::addAll);
        imiona2.forEach(System.out::println);

        var inp = IO.readln("\nPodaj literke by wypisać imiona na ową litere: ");
        imiona.stream().filter(im -> im.startsWith(inp) || im.startsWith(inp.toUpperCase())).forEach(System.out::println);

        IO.println("\nNajdłuższe imie:");
        imiona.stream().max(Comparator.comparingInt(String::length)).ifPresent(System.out::println);

        IO.println("\nImiona bez duplikatów:");
        imiona.stream().distinct().forEach(System.out::println);

        IO.println("\nImiona ale bez ty kończących się na 'a'");
        imiona.removeIf(im -> im.endsWith("a"));
        imiona.forEach(System.out::println);
        // Pętla zachowuje kopie liczby wersji ArrayList, która zaczyna odbiegać od orginalnego jak usuwamy z niej elementy (każda zmiana nowa wersja) i to powoduje
        // ConcurrentModificationException
    }
}
