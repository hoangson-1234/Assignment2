namespace Assignment2
{
    using System;

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

            double result = calculate(SIGN.MULTIPLY, a, b);

            Console.WriteLine("Result = " + result);
        }

        static double calculate(SIGN sign, double arg1, double arg2)
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


