int Horner(int systemLiczbowy,string liczba)
{
	int wynik = liczba[0]-48;
	for (int i = 1;i<liczba.Length;i++)
	{
		int temp = wynik; 
		wynik = systemLiczbowy * temp + liczba[i]-48;
	}
	return wynik;
}
Console.WriteLine("Wynik: "+Horner(4, "3333"));