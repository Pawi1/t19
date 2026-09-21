public class AmericaTeapot implements ITeapot {
    private double fahrTemp;

    public AmericaTeapot() {
    }

    public AmericaTeapot(double fahrTemp) {
        this.fahrTemp = fahrTemp;
    }
    @Override
    public double getFahrTemp() {
        return fahrTemp;
    }

    @Override
    public void printFahrTemp() {
        System.out.println(fahrTemp + "℉");
    }
}
