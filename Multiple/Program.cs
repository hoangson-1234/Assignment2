using System;

namespace Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = a * b;

            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }
    }
}
