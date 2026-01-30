using System;

namespace DivisionApp
{
    class Program
    {
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
                return 0;
            }
            return x / y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== DIVISION ===");

            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());

            double result = Divide(a, b);
            Console.WriteLine($"Result: {a} / {b} = {result}");
        }
    }
}
