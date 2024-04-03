using System.Xml.Serialization;

namespace salon;
class Lokal 
{
    public string? Adres { get;set; }
    public string? NumerTelefonu { get; set;}
    public double Stawka { get; set; }
}
abstract class Pracownik {}
class Kosmetyczka : Pracownik {}
class Fryzjerka : Pracownik {}
class Manikjurzystka : Pracownik {}

abstract class Sprzet {}
class Grzebien : Sprzet {}
class Suszarka : Sprzet {}
class Plyn : Sprzet {}
class SalonUrody
{
    Lokal? Lokal;
    List<Pracownik>? Pracownicy;
    List<Sprzet>? Wyposarzenie;
    public void SetLokal(Lokal lokal)
    {
        Lokal = lokal;
    }
    public void DodajPracownika( List<Pracownik> pracownicy)
    {
        Pracownicy = pracownicy;
    }
    public void DodajWyposzarzenie(List<Sprzet> wyposarzenie)
    {
        Wyposarzenie = wyposarzenie;
    }
}
class Program
{
    static void Main()
    {
        Lokal lokal = new()
        {
            Adres = "Ulica",
            NumerTelefonu = "*48 123-123-213",
            Stawka = 2138.40
        };
        Kosmetyczka kosmetyczka = new ();
        Fryzjerka fryzjerka = new();
        Manikjurzystka manikjurzystka = new();
        List<Pracownik> pracownicy = new()
        {
            kosmetyczka,
            fryzjerka,
            manikjurzystka
        };
        List<Sprzet> wyposarzenie = new()
        {
            new Plyn(),
            new Suszarka(),
            new Grzebien()
        };
        SalonUrody salonUrody = new();
        salonUrody.SetLokal(lokal);
        salonUrody.DodajWyposzarzenie(wyposarzenie);
        salonUrody.DodajPracownika(pracownicy);
    }
}
