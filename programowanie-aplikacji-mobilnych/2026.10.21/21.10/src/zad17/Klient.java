package zad17;

import java.util.ArrayList;
import java.util.Random;

public class Klient implements Runnable {
    String imie;
    ArrayList<Integer> ulubione;
    Sala sala;
    ArrayList<String> zarezerwowani;
    ArrayList<String> zrezygnowali;

    Klient(String imie, Sala sala, ArrayList<String> zarezerwowani, ArrayList<String> zrezygnowali) {
        this.imie = imie;
        this.sala = sala;
        this.zarezerwowani = zarezerwowani;
        this.zrezygnowali = zrezygnowali;
        var r = new Random();
        this.ulubione = new ArrayList<>();
        for (var i = 0; i < 3; i++)
            this.ulubione.add(r.nextInt(1, 31));
    }

    @Override
    public void run() {
        for (var miejsce : ulubione) {
            if (sala.rezerwuj(miejsce, imie)) {
                synchronized (zarezerwowani) {
                    zarezerwowani.add(imie);
                }
                return;
            }
        }
        synchronized (zrezygnowali) {
            zrezygnowali.add(imie);
        }
    }
}
