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
                    var case1inp = IO.readln("\nNazwa produktu: ");
                    if( case1inp.equals("") )
                    zakupy.add();
                    break;
                case "2":
                    var case2inp = IO.readln("\n Podaj nazwe lub numer: ");
                    if(zakupy.remove(case2inp))
                        IO.println("Usuniete\n");
                    else {
                        int index = Integer.parseInt(case2inp);
                        if (index >= 0 && index < zakupy.size()) {
                            zakupy.remove(index);
                            IO.println("Usuniete\n");
                        }
                        else
                            IO.println("Cos poszlo nie tak\n");
                    }
                    break;
                case "3":
                    IO.println();
                    for (int i = 0; i < zakupy.size(); i++) {
                        IO.println(i+": "+zakupy.get(i));
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
