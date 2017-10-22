using System;
using System.Linq;
using System.IO;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = File.ReadAllText("./tests/input05.txt").Split().Select(int.Parse).ToArray();
            long sum = arr.Sum();
            long leftSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (leftSum == sum - leftSum - arr[i])
                {
                    File.WriteAllText("./tests/output05.txt", i.ToString());
                    return;
                }
                leftSum += arr[i];
            }
            File.WriteAllText("./tests/output05.txt", "no");
        }
    }
}
