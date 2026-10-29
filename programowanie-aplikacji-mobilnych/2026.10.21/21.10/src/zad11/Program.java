package zad11;

import java.util.HashMap;
import java.util.Map;

public class Program {
    /// Użytkownik wpisuje dowolny tekst. Do HashMap<String, Integer>
    /// policz, ile razy wystąpiło każde słowo (bez rozróżniania wielkości
    /// liter, pomiń znaki interpunkcyjne). Wypisz:
    /// - wszystkie słowa z liczbą wystąpień,
    /// - najczęstsze słowo,
    /// - słowa występujące tylko raz.
    ///
    /// Wskazówka: getOrDefault() lub merge().
    ///
    ///   Tekst: "Ala ma kota, a kot ma Alę"
    ///   ala=1, ma=2, kota=1, a=1, kot=1, alę=1
    void main() {
        var input = IO.readln("Wpisz tekst: ").strip().toLowerCase().replaceAll("[,.?!]","").split(" ");
        var dict = new HashMap<String, Integer>();
        for (var w : input) {
            dict.put(w, dict.get(w) == null ? 1 : dict.get(w) + 1 );
        }
        dict.forEach((k,v)->{
            IO.print(String.format("%s = %d ", k, v));
        });
        var najczestsze = dict.entrySet().stream().max(Map.Entry.comparingByValue()).orElseThrow();
        IO.println(String.format("\nNajczestsze: %s, wystąpienia: %d", najczestsze.getKey(),najczestsze.getValue()));
        IO.println("Słowa występujące tylko raz:");
        dict.forEach((k,v)->{
           if(v.equals(1))
               IO.print(String.format("%s = %d ", k, v));
        });
    }
}
