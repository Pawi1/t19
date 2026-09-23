public class DigitalToVga implements Vga {

    private DisplayPort digital;
    public DigitalToVga(Hdmi digital) {
        this.digital = digital;
    }
    public DigitalToVga(DisplayPort digital) {
        this.digital = digital;
    }
    @Override
    public char[] getBuffer() {
        return digital.getBitmap().toCharArray();
    }
}
