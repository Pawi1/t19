public class Monitor {
    private Vga input;

    public void setInput(Vga input) {
        this.input = input;
    }

    public Monitor() {
    }

    public void display()
    {
        System.out.println(input.getBuffer());
    }
}
