using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long sum = arr.Sum();
            long leftSum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if(leftSum == sum - leftSum - arr[i])
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += arr[i];
            }
            Console.WriteLine("no");
        }
    }
}
