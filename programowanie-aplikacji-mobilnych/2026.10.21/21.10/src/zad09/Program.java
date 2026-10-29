package zad09;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.stream.Collectors;

public class Program {
/// Wylosuj 50 liczb z zakresu 1–100 do ArrayList<Integer>. Utwórz:
/// - listę parzystych i listę nieparzystych,
/// - sumę, średnią, medianę (posortuj kopię listy!),
/// - listę liczb większych od średniej,
/// - listę bez powtórzeń.
///
/// Na koniec przepisz wylosowane liczby do zwykłej tablicy int[]
/// i z powrotem – porównaj, co jest wygodniejsze.
    void main()
    {
        var liczby = new ArrayList<Integer>();
        var r = new Random();
        for (int i = 0; i < 50; i++) {
            liczby.add(r.nextInt(1,100));
        }
        IO.println("Lista losowych liczb: ");
        liczby.forEach(x -> IO.print(x+" "));
        var liczby_parz = liczby.stream().filter(e -> e%2==0).collect(Collectors.toCollection(ArrayList::new));
        var liczby_nieparz = liczby.stream().filter(e -> e%2!=0).collect(Collectors.toCollection(ArrayList::new));
        IO.println("\nLista parzyste liczby: ");
        liczby_parz.forEach(x -> IO.print(x+" "));
        IO.println("\nLista nie parzyste liczby: ");
        liczby_nieparz.forEach(x -> IO.print(x+" "));
        var suma = liczby.stream().mapToInt(Integer::intValue).sum();
        IO.println(String.format("\nSuma liczb: %d",suma));
        var srednia =  liczby.stream().mapToInt(Integer::intValue).average().orElse(-1);
        IO.println(String.format("Średnia liczb: %.2f", srednia));
        var liczby_kopia = liczby.stream().sorted().collect(Collectors.toCollection(ArrayList::new));
        var mediana = liczby_kopia.get(liczby_kopia.size()/2);
        IO.println(String.format("Mediana: %d", mediana));
        IO.println("Posortowana lista: ");
        liczby_kopia.forEach(e -> IO.print(e + " "));
        var liczby_ponadSred = liczby.stream().filter(e -> e > srednia).collect(Collectors.toCollection(ArrayList::new));
        IO.println("\nLiczby ponad średnią:");
        liczby_ponadSred.forEach(e -> IO.print(e + " "));
        var liczby_bezPow = liczby.stream().distinct().collect(Collectors.toCollection(ArrayList::new));
        IO.println("\nLiczby bez powtórzeń:");
        liczby_bezPow.forEach(e -> IO.print(e + " "));
        var liczby_tab = liczby.stream().mapToInt(Integer::intValue).toArray();
        IO.println(String.format("\nUtworzono tablice: %s",liczby_tab.getClass()));
        for(var i : liczby_tab)
            IO.print(i +" ");
        var liczby_arr = Arrays.stream(liczby_tab).boxed().collect(Collectors.toCollection(ArrayList::new));
        IO.println(String.format("\nUtworzono ArrayList: %s",liczby_arr.getClass()));
        liczby_arr.forEach(e -> IO.print(e + " "));
        // > porównaj, co jest wygodniejsze
        // wygodniejsze w użyciu jest ArrayList bo jest listą, ma dodatkowe metody których int[] nie ma (np forEach() albo stream())
        // konwersja z Array -> int[] też jest wygodniejsza od int[] -> Array
    }
}
