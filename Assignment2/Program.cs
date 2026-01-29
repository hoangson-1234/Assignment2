namespace Assignment2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            int result = a - b;
            Console.WriteLine("Result = " + result);
        }
    }
}

