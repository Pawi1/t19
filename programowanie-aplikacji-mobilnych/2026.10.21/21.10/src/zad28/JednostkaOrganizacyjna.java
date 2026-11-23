package zad28;

public interface JednostkaOrganizacyjna {
    String nazwa();
    double kosztPensji();
    int liczbaOsob();
    void podwyzka(double procent);
    void wypiszStrukture(int poziom);
}
