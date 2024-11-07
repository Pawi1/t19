namespace marc._13;

class Program
{
    static void Main(string[] args)
    { 
        Console.Write("z.1 liczby portugalskie\nPodaj długosc listy: ");
        int[] lista = new int[Convert.ToInt32(Console.ReadLine())];
        for(int i = 0; i< lista.Length;i++)
            {
                Console.Write("Podaj {0} liczbe: ",i+1);
                lista[i] = Convert.ToInt32(Console.ReadLine());
            }
        for(int i = 0; i< lista.Length;i++)
            {
                bool czyPortugalska = true;
                for(int j = 0; j<lista.Length;j++)
                    {
                        if(j == i) continue;
                        if(lista[i] == lista[j] || lista[i]+1 == lista[j] || lista[i]+2 == lista[j]|| lista[i]-1 == lista[j] || lista[i]-2 == lista[j])
                            czyPortugalska = false;
                    }
                if(czyPortugalska)
                {
                    Console.Write(lista[i]+" ");
                }
            }
    }
}
