package zad10;

import java.util.HashMap;
import java.util.Map;

public class Program {
    /// HashMap<String, String> – klucz: imię i nazwisko, wartość: numer telefonu.
    /// Operacje: dodaj kontakt, usuń, znajdź numer po nazwie,
    /// znajdź nazwę po numerze (przejście po entrySet()), edytuj numer,
    /// wypisz wszystkie kontakty alfabetycznie.
    /// - numer musi mieć 9 cyfr,
    /// - dodanie istniejącej nazwy pyta, czy nadpisać.
    void main() {
        var kontakty = new HashMap<String,String>();
        while (true)
        {
            IO.println("\n1. Dodaj kontakt\n2. Usuń kontakt\n3. Znajdz numer po nazwie\n4. Znajdz nazwe po numerze\n5. Edytuj numer\n6. Wypisz kontakty alfabetycznie\n0. Wyjdź");
            var op = IO.readln("\nPodaj operacje: ");
            switch (op)
            {
                case "1":
                    var c1_key = IO.readln("Podaj imie i nazwisko: ");
                    var c1_value = IO.readln("Podaj numer telefonu: ").strip().replaceAll("[- ]","");
                    if(c1_value.length() != 9)
                    {
                        IO.println("Zła długość");
                    }
                    if(kontakty.get(c1_key) != null)
                    {
                        var c1_o = IO.readln("Znaleziono kontakt o takiej nazwie, nadpisać? (t/n): ");
                        if (c1_o.equals("n"))
                            break;
                    }
                    kontakty.put(c1_key,c1_value);
                    IO.println(String.format("Dodano kontakt:\n\timie i nazwisko: %s\n\tnumer: %s",c1_key,c1_value));
                    break;
                case "2":
                    var c2_key = IO.readln("Podaj kontakt po usunięcia (imie i nazwisko): ");
                    if(kontakty.remove(c2_key) == null)
                        IO.println("Nie znaleziono kontaktu");
                    else if(kontakty.remove(c2_key).equals(c2_key))
                        IO.println("Usunięto pomyślnie");
                    break;
                case "3":
                    var c3_key = IO.readln("Podaj kontakt do znalezienia (imie i nazwisko): ");
                    var c3_value = kontakty.get(c3_key);
                    if(c3_value != null)
                        IO.println("Znaleziono: "+c3_value);
                    else
                        IO.println("Nie znaleziono kontaktu");
                    break;
                case "4":
                    var c4_value = IO.readln("Podaj kontakt do znalezienia (nr. telefonu): ");
                    // po entrySet
//                    kontakty.entrySet().forEach(e -> {
//                        if(e.getValue().equals(c4_value))
//                            IO.println("Znaleziono imie i nazwisko: "+e.getKey());
//                    });
                    kontakty.forEach((key, value) -> {
                        if (value.equals(c4_value))
                            IO.println("Znaleziono imie i nazwisko: " + key);
                    });
                    break;
                case "5":
                    var c5_key = IO.readln("Podaj imie i nazwisko kontaktu do zmiany: ");
                    var c5_value = kontakty.get(c5_key);
                    if (c5_value == null) {
                        IO.println("Nie znaleziono kontaktu");
                        break;
                    }
                    var c5_valueNew = IO.readln("Nowy numer telefonu: ").strip().replaceAll("[- ]","");
                    if(c5_valueNew.length() != 9)
                    {
                        IO.println("Zła długość");
                    }
                    kontakty.put(c5_key,c5_valueNew);
                    IO.println(String.format("Zmieniono kontakt:\n\timie i nazwisko: %s\n\tnumer: %s",c5_key,c5_valueNew));
                    break;
                case "6":
                    kontakty.entrySet().stream().sorted(Map.Entry.comparingByKey()).forEach(e->{
                    IO.println(String.format("kontakt:\n\timie i nazwisko: %s\n\tnumer: %s",e.getKey(),e.getValue()));
                    });
                    break;
                case "0":
                    return;
                default:
                    break;
            }
        }
    }
}
