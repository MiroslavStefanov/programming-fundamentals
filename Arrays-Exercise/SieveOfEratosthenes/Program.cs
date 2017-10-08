using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[n+1];
            for (int i = 2; i < n+1; i++)
                isPrime[i] = true;
            isPrime[0] = isPrime[1] = false;
            for(int i = 2; i<n+1; i++)
                if(isPrime[i])
                {
                    for (int j = 2 * i; j <= n; j += i)
                        isPrime[j] = false;
                }
            for (int i = 2; i <= n; i++)
                if (isPrime[i])
                    Console.Write(i + " ");
        }
    }
}
