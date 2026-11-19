package zad22;

/// Klasa Komputer: procesor, ram (GB), dysk (GB i typ SSD/HDD),
/// karta graficzna (opcjonalna), zasilacz (W), obudowa.
///
/// KomputerBuilder z metodami łańcuchowymi i walidacją w build():
/// - procesor i RAM obowiązkowe,
/// - RAM musi być potęgą dwójki (8, 16, 32...),
/// - jeśli jest karta graficzna, zasilacz min. 650 W,
/// - brak zasilacza -> dobierany automatycznie.
///
/// Dodaj klasę Dyrektor (Director) z gotowymi zestawami:
/// - zestawBiurowy(),
/// - zestawGamingowy(),
/// - zestawSerwerowy().
///
///   Komputer pc = Dyrektor.zestawGamingowy();
///   Komputer wlasny = new KomputerBuilder()
///                        .procesor("Ryzen 7")
///                        .ram(32)
///                        .dysk(1000, TypDysku.SSD)
///                        .build();
///
/// Pytanie: kiedy Builder jest lepszy od konstruktora z 8 parametrami?

// ODP: jak jest:
//               * dużo parametrów opcjonalnych
//               * dużo parametrów tego samego typu
//               * powtarzające się parametry
// Dodatkowo łatwiej walidować elementy oraz jest to czytelniejsze
public class Program {
    void main() {
        Komputer pc = Dyrektor.zestawGamingowy();
        Komputer wlasny = new Komputer.Builder()
                        .cpu("Ryzen 7")
                        .ram(32)
                        .dysk(1000, TypDysku.SSD)
                        .build();
        IO.println(pc);
        IO.println(wlasny);
    }
}
