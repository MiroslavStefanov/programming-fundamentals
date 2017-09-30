using System;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = days * 24ul;
            ulong minutes = hours * 60ul;
            ulong seconds = minutes * 60ul;
            ulong milliseconds = seconds * 1000ul;
            ulong microseconds = milliseconds * 1000ul;
            BigInteger nanoseconds = microseconds * (BigInteger)1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
