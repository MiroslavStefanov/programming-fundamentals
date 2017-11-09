using System;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            short numDays = short.Parse(Console.ReadLine());
            int numRunners = int.Parse(Console.ReadLine());
            byte numLaps = byte.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            short trackCapacity = short.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long totalLaps = (long)Math.Min(numRunners, numDays * trackCapacity) * numLaps;
            decimal totalMoney = ((decimal)totalLaps * trackLength) / 1000m * moneyPerKm;
            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
