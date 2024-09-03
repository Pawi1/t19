Console.OutputEncoding = System.Text.Encoding.UTF8;
Start:
Console.Clear();
Console.Write("Podaj jednostkę (domyślnie j): ");
string j = Console.ReadLine() ?? ""; if(j=="") j="j";
double a,b,c;
A:
    Console.Write("Podaj długość a: ");
    try {
        a = Convert.ToDouble(Console.ReadLine());
        if(a < 1) throw new Exception(); 
    } catch{
        Console.WriteLine("Podana liczba jest niepoprawna, spróbuj ponownie ...");
        Thread.Sleep(1500); Console.Clear();
        goto A;
    }
B:
    Console.Write("Podaj długość b: ");
    try {
        b = Convert.ToDouble(Console.ReadLine());
        if(b < 1) throw new Exception(); 
    } catch{
        Console.WriteLine("Podana liczba jest niepoprawna, spróbuj ponownie ...");
        Thread.Sleep(1500); Console.Clear();
        Console.WriteLine($"Podaj długość a: {a}");
        goto B;
    }
C:
    Console.Write("Podaj długość c: ");
    try {
        c = Convert.ToDouble(Console.ReadLine());
        if(c < 1) throw new Exception(); 
    } catch{
        Console.WriteLine("Podana liczba jest niepoprawna, spróbuj ponownie ...");
        Thread.Sleep(1500); Console.Clear();
        Console.WriteLine($"Podaj długość a: {a}\nPodaj długość b: {b}");
        goto C;
    }
double p = (a+b+c)/2, w = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
if(a < b+c && b < c+a && c < b+a ){ 
Console.WriteLine($"\nObwód trójkąta abc o bokach {a} {j}, {b} {j}, {c} {j} jest równy {a+b+c} {j}");
Console.WriteLine($"Pole trójkąta abc o bokach {a} {j}, {b} {j}, {c} {j} wynosi: {Math.Round(w,4)} {j}\u00B2"); 
}else {
Console.WriteLine("Z podanych liczb nie da się skonstruować trójkąta, spróbuj ponownie ...");
Thread.Sleep(1500);
goto Start;
}