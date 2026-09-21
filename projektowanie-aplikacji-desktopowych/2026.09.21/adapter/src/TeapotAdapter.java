public class TeapotAdapter extends AmericaTeapot {
    private EuroTeapot teapot;

    public TeapotAdapter(EuroTeapot teapot) {
        this.teapot = teapot;
    }

    @Override
    public double getFahrTemp() {
        return teapot.getCelsTemp()*1.8+32;
    }

    @Override
    public void printFahrTemp() {
        System.out.println(getFahrTemp() + "℉");
    }
}
