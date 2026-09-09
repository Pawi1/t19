//Napisz program, który wczytuje n liczb całkowitych i przechowuje je w ArrayList, a następnie wypisuje ich sumę i średnią.
void zad1(){
    Scanner scr = new Scanner(System.in);
    System.out.print("Wpisz n liczb (format: 1 2 3 ...): ");
    var list = new ArrayList<Integer>();
    for (var el : scr.nextLine().trim().split("\\s+")) {
        list.add(Integer.parseInt(el));
    }
    System.out.println(list);
    var sum = 0;
    for(var i : list) sum+=i;
    System.out.println("Suma: " + sum);
    System.out.println("Średnia: "+ (double)sum/list.size());
}

void main(){
zad1();
}