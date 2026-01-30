using System;

namespace SubtractionApp
    {
        class Program
        {
            public static int Subtract(int x, int y)
            {
                return x - y;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("=== SUBTRACTION ===");
                Console.Write("Enter number a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter number b: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"Result: {a} - {b} = {Subtract(a, b)}");
            }
        }
    }