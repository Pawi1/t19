using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class algorytm
    {
        static public bool CzyZaprzyjazniona(int number1, int number2)
        {
            return (SumaDzielnikiWlasciwe(number1) == number2 && SumaDzielnikiWlasciwe(number2) == number1);
        }
        static int SumaDzielnikiWlasciwe(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
