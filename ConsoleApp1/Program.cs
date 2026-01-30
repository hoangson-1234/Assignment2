using System;

namespace CalculatorPlus
{
    class Program
    {
        public static int Calculator(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculator PLUS ===");

            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a + b = {Calculator(a, b)}");
        }
    }
}