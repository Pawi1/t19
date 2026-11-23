package zad29;

import java.util.ArrayList;

public class StacjaPogodowa implements Obserwowany {
    private final ArrayList<Obserwator> obserwatorzy = new ArrayList<>();
    private Pomiar biezacy;

    @Override
    public void dodajObserwatora(Obserwator o) {
        if (!obserwatorzy.contains(o))
            obserwatorzy.add(o);
    }

    @Override
    public void usunObserwatora(Obserwator o) {
        obserwatorzy.remove(o);
    }

    @Override
    public void powiadom() {
        for (var o : obserwatorzy)
            o.aktualizuj(biezacy);
    }

    public void nowyPomiar(double temperatura, double wilgotnosc, double cisnienie) {
        biezacy = new Pomiar(temperatura, wilgotnosc, cisnienie);
        powiadom();
    }

    public Pomiar getBiezacy() {
        return biezacy;
    }
}
