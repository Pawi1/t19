class KontoUcznia
{
    public string Login {get;set;}
    private int _punkty;
    public int Punkty => _punkty;

    public bool DodajPunkty(int ile)
    {
        if (ile <= 0) return false;
        _punkty += ile;
        return true;
    }
}
