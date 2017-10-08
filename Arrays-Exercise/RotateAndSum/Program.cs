using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sumArr = new int[arr.Length];
            for(int i = 1; i<=k; i++)
            {
                for(int j = 0; j<arr.Length; j++)
                {
                    sumArr[(j + i) % arr.Length] += arr[j];
                }
            }
            Console.WriteLine(String.Join(" ", sumArr));
        }
    }
}
