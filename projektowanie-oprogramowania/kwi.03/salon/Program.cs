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
    public void DodajPracownika(Pracownik pracownicy)
    {
       Pracownicy?.Add(pracownicy);
    }
    public void DodajWyposzarzenie(Sprzet wyposarzenie)
    {
        Wyposarzenie?.Add(wyposarzenie);
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
        var salonUrody = new SalonUrody();
        salonUrody.SetLokal(lokal);
        
        var kosmetyczka = new Kosmetyczka();
        salonUrody.DodajPracownika(kosmetyczka);
        var fryzjerka = new Fryzjerka();
        salonUrody.DodajPracownika(fryzjerka);
        var manikjurzystka = new Manikjurzystka();
        salonUrody.DodajPracownika(manikjurzystka);
        
        var plyn = new Plyn();
        salonUrody.DodajWyposzarzenie(plyn);
        var suszarka = new Suszarka();
        salonUrody.DodajWyposzarzenie(suszarka);
        var grzebien = new Grzebien();
        salonUrody.DodajWyposzarzenie(grzebien);
       
    }
}
