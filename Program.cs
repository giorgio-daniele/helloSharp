using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 5, b = 3;

            Console.WriteLine($"Add({a}, {b}) = {Add(a, b)}");
            Console.WriteLine($"Multiply({a}, {b}) = {Multiply(a, b)}");
            Console.WriteLine($"Factorial({a}) = {Factorial(a)}");
            Console.WriteLine($"{a} is prime? {IsPrime(a)}");
            Console.WriteLine($"Current timestamp: {DateTime.Now}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Negative number not allowed.");
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)     return false;
            if (n == 2)     return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

    }
}
