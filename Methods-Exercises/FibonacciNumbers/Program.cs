using System;

namespace FibonacciNumbers
{
    class Program
    {
        public static uint Fib(uint n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }
}
