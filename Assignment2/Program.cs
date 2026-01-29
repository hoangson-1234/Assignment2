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

            double result = calculate(SIGN.PLUS, a, b);
            Console.WriteLine("Result = " + result);
        }

        static double calculate(SIGN sign, double arg1, double arg2)
        {
            switch (sign)
            {
                default:
                    return 0;
            }
        }
    }
}


