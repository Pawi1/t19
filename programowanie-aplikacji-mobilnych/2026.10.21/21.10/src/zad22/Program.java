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
                        .procesor("Ryzen 7")
                        .ram(32)
                        .dysk(1000, TypDysku.SSD)
                        .build();
        IO.println(pc);
        IO.println(wlasny);
        IO.println(Dyrektor.zestawBiurowy());
        // zestawBiurowy i zestawSerwerowy nie podają zasilacza - jest dobierany automatycznie
        IO.println(Dyrektor.zestawSerwerowy());

        // GPU bez odpowiedniego zasilacza -> wyjatek
        try {
            new Komputer.Builder()
                    .procesor("Ryzen 5")
                    .ram(16)
                    .kartaGraficzna("RTX 4060")
                    .zasilacz(450)
                    .dysk(512, TypDysku.SSD)
                    .build();
        } catch (IllegalArgumentException e) {
            IO.println("Odrzucone: " + e.getMessage());
        }

        // RAM niebędący potęgą dwójki -> wyjatek
        try {
            new Komputer.Builder().procesor("i5").ram(12).build();
        } catch (IllegalArgumentException e) {
            IO.println("Odrzucone: " + e.getMessage());
        }
    }
}
