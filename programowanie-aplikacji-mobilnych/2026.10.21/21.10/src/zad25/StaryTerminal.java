package zad25;

class StaryTerminal {
    public int wykonajTransakcje(long kwotaWGroszach, String waluta) {
        if (kwotaWGroszach <= 0) return 1;
        if (Math.random() < 0.1) return 2;
        System.out.println("Terminal: obciążono " + kwotaWGroszach + " gr " + waluta);
        return 0;
    }
}
