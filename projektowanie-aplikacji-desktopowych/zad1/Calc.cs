using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class Calc
    {
        public static double? Calculate(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                        throw new DivideByZeroException();
                    return a / b;
                default:
                    return null;
            }
        }
    }
}
