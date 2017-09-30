using System;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            for (int number = 2; number <= upperLimit; number++)
            {
                bool isPrime = true;
                for (int devisor = 2; devisor <= Math.Sqrt(number); devisor++)
                {
                    if (number % devisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }

        }
    }
}
