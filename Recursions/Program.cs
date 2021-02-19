using System;

namespace Recursions
{
    /// <summary>
    /// Class for Recursion Practise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine($"Factorial is {ClaulateFactorial(6)}");
           Console.WriteLine($"Fibonacci Sum is {CalculateFibonacci(9)}");
        }

        /// <summary>
        /// Calculating Sum of Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int ClaulateFactorial(int n)
        {
            if(n == 2)
            {
                return 2;
            }
            var x = n * ClaulateFactorial(n - 1);
            return x;
        }

        /// <summary>
        /// Recursion for Fibonacci Calculation
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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
