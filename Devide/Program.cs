using System;

namespace CalculatorApp
{
    public class Divide
    {
        public static double Calculator(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            return a / b;
        }
    }
}
