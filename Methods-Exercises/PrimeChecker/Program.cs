using System;

namespace PrimeChecker
{
    class Program
    {
        public static bool IsPrime(ulong n)
        {
            if (n == 0 || n == 1)
                return false;
            for (ulong i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
    }
}
