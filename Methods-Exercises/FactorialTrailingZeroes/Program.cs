using System;
using System.Numerics;

namespace FactorialTrailingZeroes
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
        public static uint CountTrailingZeroes(BigInteger n)
        {
            uint ans = 0;
            while (n % 10 == 0)
            {
                ans++;
                n /= 10;
            }   
            return ans;
        }
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(CountTrailingZeroes(Factorial(n)));
        }
    }
}
