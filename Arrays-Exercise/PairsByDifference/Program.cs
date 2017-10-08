using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int dif = int.Parse(Console.ReadLine());
            uint ans = 0;
            for (uint i = 0; i < arr.Length - 1; i++)
                for (uint j = i + 1; j < arr.Length; j++)
                    if (Math.Abs(arr[j] - arr[i]) == dif)
                        ans++;
            Console.WriteLine(ans);
        }
    }
}
