/*
1. Napisz program, który wczytuje dwie liczby całkowite i wypisuje ich sumę, różnicę, iloczyn oraz iloraz.*/
void zad1(){
    var sc = new Scanner(System.in);
    int a,b;
    System.out.print("Podaj wartosci (rozdziel spacja):");
    a = sc.nextInt();
    b = sc.nextInt();
    System.out.printf("\nWyniki:\n\tsuma: %d\n\troznica: %d\n\tiloczyn: %d\n\tiloraz: %.3f",a+b,a-b,a*b, (float) a / b);
}
/*
2. Napisz program obliczający pole i obwód prostokąta na podstawie wczytanych boków.*/
void zad2(){
    var sc = new Scanner(System.in);
    int a,b;
    System.out.print("Podaj boki (rozdziel spacja):");
    a = sc.nextInt();
    b = sc.nextInt();
    System.out.printf("\nWyniki:\n\tpole: %d\n\tobwod: %d",a*b,2*a+2*b);
}
/*
3. Napisz program zamieniający temperaturę podaną w stopniach Celsjusza na Fahrenheity.
*/
void zad3(){
    Function<Double,Double> convert = c-> c * 9.0/5.0+32;
    var sc = new Scanner(System.in);
    System.out.print("Podaj Cº: ");
    System.out.printf("Fº: %.2f",convert.apply(sc.nextDouble()));
}
/*
4. Napisz program obliczający największy wspólny dzielnik dwóch liczb za pomocą algorytmu Euklidesa.
*/
int nwd(int a, int b)
{
    while (a != b)
    {
        if (a>b)
           a -= b;
        else
            b -= a;
    }
    return b;
}
/*
5. Napisz program obliczający najmniejszą wspólną wielokrotność dwóch liczb.
*/
int nww(int a, int b)
{   //nwd*nww=a*b
    return (a*b)/nwd(a,b);
}
/*
6. Napisz program obliczający sumę cyfr podanej liczby całkowitej.
*/
int zad6(int a)
{
    int sum = 0;
    while (a>0)
    {
        sum += a%10;
        a /= 10;
    }
    return sum;
}
/*
7. Napisz program sprawdzający, czy podana liczba jest palindromem (czytana tak samo od przodu i od tyłu).
*/
boolean zad7(int a)
{
    int rev = 0;
    int temp = a;
    while (temp > 0)
    {
        int dig = temp % 10;
        rev = rev * 10 + dig;
        temp /= 10;
    }

    return rev == a;
}
/*
8. Napisz program sprawdzający, czy podana liczba jest liczbą pierwszą.
*/
boolean zad8(int a)
{
    if (a<2) return false;
    for(int i = 2; i*i <= a;i++)
        if(a % i == 0) return false;
    return true;
}
/*
9. Napisz program wypisujący wszystkie liczby pierwsze z podanego zakresu.
*/
void zad9()
{
    var sc = new Scanner(System.in);
    int a,b;
    var arrayList = new ArrayList<Integer>();
    System.out.print("Podaj zakres:");
    a = sc.nextInt();
    b = sc.nextInt();
    if(a>b)
    {
        int t = a; a = b; b = t;
    }
    for (;a<=b;a++)
        if(zad8(a))
            arrayList.add(a);
    System.out.println(arrayList);
}
/*
10. Napisz program obliczający silnię podanej liczby.
11. Napisz program generujący n początkowych wyrazów ciągu Fibonacciego.
12. Napisz program zamieniający wszystkie litery w podanym tekście na wielkie oraz na małe.
13. Napisz program zliczający liczbę samogłosek i spółgłosek w podanym tekście.
14. Napisz program sprawdzający, czy podany tekst jest palindromem (bez uwzględniania wielkości liter).
15. Napisz program odwracający kolejność słów w podanym zdaniu.
*/
void main() {
    zad9();
}
