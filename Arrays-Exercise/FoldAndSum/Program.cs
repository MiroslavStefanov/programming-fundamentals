using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] ans = new int[2*k];
            for(int i = 0; i<2*k; i++)
            {
                if (i < k)
                    ans[i] = arr[k - 1 - i] + arr[k + i];
                else
                    ans[i] = arr[4 * k - 1 - (i - k)] + arr[k + i];
            }
            Console.WriteLine(String.Join(" ", ans));
        }
    }
}
