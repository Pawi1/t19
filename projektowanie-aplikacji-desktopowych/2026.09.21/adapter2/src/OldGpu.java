public class OldGpu implements Vga{
    private char[] buffer;

    public void setBuffer(char[] buffer) {
        this.buffer = buffer;
    }
    @Override
    public char[] getBuffer() {
        return buffer;
    }
}
