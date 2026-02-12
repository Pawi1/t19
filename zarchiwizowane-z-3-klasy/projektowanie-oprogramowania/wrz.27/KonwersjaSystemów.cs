int bTd(string binar)
{
    char[] stringArray = binar.ToCharArray();Array.Reverse(stringArray);string revBin = new string(stringArray); // odwrócenie stringa
    int dec=0;
	for (int i = 0; i < binar.Length; i++)
	{
        dec += Convert.ToInt32(Convert.ToString(revBin[i])) * Convert.ToInt32(Math.Pow(2,i));
	}
	return dec;
}
string bin = "100001011001";
Console.WriteLine("BIN: "+bin); 
Console.WriteLine("DEC: "+bTd(bin));
Console.WriteLine();

void dTb(int dec)
{
	//string bin = "";
	//while (dec > 0)
	//{
	//	bin = dec % 2 + bin;
	//	dec = dec / 2;
	//}

	//return bin;
	if (dec == 0) return;
	dTb(dec/2);
	Console.Write(dec%2);
}
int dec = 4004;
Console.WriteLine("DEC: " + dec);
Console.Write("BIN: ");dTb(dec);