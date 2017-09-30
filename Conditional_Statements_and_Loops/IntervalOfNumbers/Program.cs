using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nA = int.Parse(Console.ReadLine());
            int nB = int.Parse(Console.ReadLine());

            for(int i = Math.Min(nA, nB); i<= Math.Max(nA, nB); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
