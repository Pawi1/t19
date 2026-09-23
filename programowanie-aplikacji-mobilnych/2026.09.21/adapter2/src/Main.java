void main()
{
    var newGpu = new ModernGpu();
    var oldGpu = new OldGpu();
    var monitor = new Monitor();

    monitor.setInput(new DigitalToVga(newGpu));
    newGpu.setBitmap("Jakis ciag znakow");

    monitor.display();

    monitor.setInput(oldGpu);
    oldGpu.setBuffer(new char[] {'H','e','l','l','o'});

    monitor.display();
}