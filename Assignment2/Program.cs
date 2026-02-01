using System;

namespace Assignment2
{
    enum SIGN
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());

            double plus = Calculate(SIGN.PLUS, a, b);
            double minus = Calculate(SIGN.MINUS, a, b);
            double multiply = Calculate(SIGN.MULTIPLY, a, b);
            double divide = Calculate(SIGN.DIVIDE, a, b);

            Console.WriteLine($"{plus}, {minus}, {multiply}, {divide}");
        }

        static double Calculate(SIGN sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case SIGN.PLUS:
                    return arg1 + arg2;
                case SIGN.MINUS:
                    return arg1 - arg2;
                case SIGN.MULTIPLY:
                    return arg1 * arg2;
                case SIGN.DIVIDE:
                    return arg2 != 0 ? arg1 / arg2 : 0;
                default:
                    return 0;
            }
        }
    }
}

