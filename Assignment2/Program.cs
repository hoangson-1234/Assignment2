namespace Assignment2
{
    using System;

<<<<<<< HEAD
    enum SIGN
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }

=======
>>>>>>> origin/feature/CPL26/nguyenhoanganh/implement_plus
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a: ");
<<<<<<< HEAD
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
=======
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            int result = a + b;
            Console.WriteLine("Result = " + result);
        }
>>>>>>> origin/feature/CPL26/nguyenhoanganh/implement_plus
    }
}
