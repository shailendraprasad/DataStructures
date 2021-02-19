using System;

namespace Recursions
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine($"Factorial is {ClaulateFactorial(6)}");
           Console.WriteLine($"Fibonacci Sum is {CalculateFibonacci(9)}");
        }

        static int ClaulateFactorial(int n)
        {
            if(n == 2)
            {
                return 2;
            }
            var x = n * ClaulateFactorial(n - 1);
            return x;
        }

        static int CalculateFibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
            }
        }
    }
}
