using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        public static BigInteger Factorial(uint n)
        {
            BigInteger ans = 1;
            for (uint i = 2; i <= n; i++)
                ans *= i;
            return ans;
        }
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}
