using System.Runtime.CompilerServices;

byte w1=30, w2=40, odl=50;
for (short i = 1; i <= odl; i++)
{
    if(w1*w1 + i*i == w2*w2 + (odl-i)*(odl-i)) 
    {
        if(i>odl/2) Console.WriteLine(i);
        else        Console.WriteLine(odl-1);
    }    
}