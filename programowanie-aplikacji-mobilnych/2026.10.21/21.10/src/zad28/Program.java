package zad28;

/// Interfejs JednostkaOrganizacyjna:
///
///   interface JednostkaOrganizacyjna {
///       String nazwa();
///       double kosztPensji();
///       int liczbaOsob();
///       void podwyzka(double procent);
///       void wypiszStrukture(int poziom);
///   }
///
/// - Pracownik – liść (imię, stanowisko, pensja),
/// - Dzial – kompozyt: nazwa, kierownik (obiekt Pracownik – liczy się
///   do osób i kosztów działu) oraz ArrayList<JednostkaOrganizacyjna>
///   podjednostek (pracownicy i inne działy).
///
/// Zbuduj firmę – korzeniem jest dział "Firma XYZ", w nim:
/// IT (z poddziałami Backend i Frontend), Sprzedaż, HR.
///
/// Funkcje:
/// - łączny koszt pensji całej firmy i dowolnego działu,
/// - liczba osób w dziale (z poddziałami),
/// - podwyzka(procent) wywołana na dziale – działa rekurencyjnie
///   na wszystkich pracowników w środku,
/// - BONUS: najlepiej opłacany pracownik w dziale.
public class Program {
    void main() {
        var backend = new Dzial("Backend", new Pracownik("Jan Kowalski", "senior dev", 12000))
                .dodaj(new Pracownik("Ewa Lis", "dev", 9000))
                .dodaj(new Pracownik("Piotr Nowak", "junior dev", 6000));

        var frontend = new Dzial("Frontend", new Pracownik("Anna Zub", "lead frontend", 11000))
                .dodaj(new Pracownik("Marek Dąb", "dev", 8500));

        var it = new Dzial("IT", new Pracownik("Tomasz Wilk", "CTO", 18000))
                .dodaj(backend)
                .dodaj(frontend);

        var sprzedaz = new Dzial("Sprzedaż", new Pracownik("Kasia Sosna", "kierownik sprzedaży", 10000))
                .dodaj(new Pracownik("Olaf Bąk", "handlowiec", 7000))
                .dodaj(new Pracownik("Zofia Rak", "handlowiec", 7200));

        var hr = new Dzial("HR", new Pracownik("Iwona Mak", "kierownik HR", 9500))
                .dodaj(new Pracownik("Bartek Sum", "rekruter", 6500));

        var firma = new Dzial("Firma XYZ", new Pracownik("Adam Król", "prezes", 25000))
                .dodaj(it)
                .dodaj(sprzedaz)
                .dodaj(hr);

        firma.wypiszStrukture(0);

        IO.println(String.format(Pracownik.PL, "\nKoszt pensji całej firmy: %,.0f zł (%d %s)",
                firma.kosztPensji(), firma.liczbaOsob(), Dzial.osoby(firma.liczbaOsob())));
        IO.println(String.format(Pracownik.PL, "Koszt pensji działu IT:   %,.0f zł (%d %s)",
                it.kosztPensji(), it.liczbaOsob(), Dzial.osoby(it.liczbaOsob())));
        IO.println(String.format(Pracownik.PL, "Koszt pensji Backendu:    %,.0f zł (%d %s)",
                backend.kosztPensji(), backend.liczbaOsob(), Dzial.osoby(backend.liczbaOsob())));

        IO.println("\nBONUS - najlepiej opłacany w firmie: " + firma.najlepiejOplacany().nazwa());
        IO.println("BONUS - najlepiej opłacany w IT:     " + it.najlepiejOplacany().nazwa());

        IO.println("\npodwyzka(10) na dziale IT - działa rekurencyjnie:");
        it.podwyzka(10);
        it.wypiszStrukture(0);
        IO.println(String.format(Pracownik.PL, "\nKoszt pensji całej firmy po podwyżce w IT: %,.0f zł",
                firma.kosztPensji()));
    }
}
