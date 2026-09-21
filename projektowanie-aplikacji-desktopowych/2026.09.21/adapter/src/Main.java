void main() {
    var euTeapot = new EuroTeapot(36.7);
    var importedTeapot = new TeapotAdapter(euTeapot);

    var americanTeapots = new ArrayList<ITeapot>();
    americanTeapots.add(new AmericaTeapot(50));
    americanTeapots.add(new AmericaTeapot(100));
    americanTeapots.add(importedTeapot);

    for(var teapots : americanTeapots)
    {
        teapots.printFahrTemp();
    }
}
