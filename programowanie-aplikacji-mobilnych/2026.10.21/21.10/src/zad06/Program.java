package zad06;

import java.util.ArrayList;

public class Program {
    void main()
    {
        /// ArrayList<String> z listą zakupów. Menu w konsoli:
        /// 1 – dodaj produkt, 2 – usuń produkt (po nazwie lub numerze),
        /// 3 – wypisz listę z numerami, 4 – wyczyść listę, 0 – koniec.
        /// - nie można dodać pustej nazwy ani duplikatu (sprawdź contains()),
        /// - przy usuwaniu nieistniejącego produktu wypisz komunikat.
        ///
        ///   1. mleko
        ///   2. chleb
        ///   3. masło

        var zakupy = new ArrayList<String>();
        while(true)
        {
            IO.println(
                    "Menu\n" +
                    "1 - dodaj produkt\n" +
                    "2 - usuń produkt (po nazwie lub numerze)\n" +
                    "3 - wypisz listę z numerami\n" +
                    "4 - wyczyść listę\n" +
                    "0 - koniec\n");
            var inp = IO.readln("Podaj cyfre: ");
            switch (inp)
            {
                case "1":
                    var case1inp = IO.readln("\nNazwa produktu: ").trim();
                    if( case1inp.isEmpty() )
                        IO.println("Nazwa nie może być pusta");
                    else if( zakupy.contains(case1inp) )
                        IO.println("Produkt już istnieje");
                    else
                        zakupy.add(case1inp);
                    break;
                case "2":
                    var case2inp = IO.readln("\n Podaj nazwe lub numer: ");
                    if(zakupy.remove(case2inp))
                        IO.println("Usuniete\n");
                    else {
                        try {
                            // numery na liście są od 1, w ArrayList indeksy od 0
                            var numer = Integer.parseInt(case2inp);
                            if (numer >= 1 && numer <= zakupy.size()) {
                                zakupy.remove(numer - 1);
                                IO.println("Usuniete\n");
                            }
                            else
                                IO.println("Nie ma produktu o numerze " + numer + "\n");
                        } catch (NumberFormatException e) {
                            IO.println("Nie ma takiego produktu na liście\n");
                        }
                    }
                    break;
                case "3":
                    IO.println();
                    for (int i = 0; i < zakupy.size(); i++) {
                        IO.println((i+1)+". "+zakupy.get(i));
                    }
                    IO.println();
                    break;
                case "4":
                    zakupy.clear();
                    IO.println("Wyczyszczono\n");
                    break;
                case "0":
                    return;
                default:
                    IO.println("Źle wpisałeś, spróbuj ponownie");
                    break;
            }
        }
    }
}
