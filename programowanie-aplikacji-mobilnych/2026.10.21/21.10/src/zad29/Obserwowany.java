package zad29;

public interface Obserwowany {
    void dodajObserwatora(Obserwator o);
    void usunObserwatora(Obserwator o);
    void powiadom();
}
