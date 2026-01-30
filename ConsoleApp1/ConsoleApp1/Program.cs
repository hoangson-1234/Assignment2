using System;

namespace MultiplicationApp
{
    class Program
    {
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== MULTIPLICATION ===");
            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Result: {a} * {b} = {Multiply(a, b)}");
        }
    }
}