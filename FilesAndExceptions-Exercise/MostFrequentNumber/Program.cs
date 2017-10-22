using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] arr = File.ReadAllText(@"./tests/input03.txt").Split(' ').Select(ushort.Parse).ToArray();
            Dictionary<ushort, uint> counter = new Dictionary<ushort, uint>();
            for (uint i = 0; i < arr.Length; i++)
            {
                if (counter.ContainsKey(arr[i]))
                    counter[arr[i]]++;
                else
                    counter.Add(arr[i], 1);
            }
            ushort ans = 0;
            uint times = 0;
            foreach (var elem in counter)
            {
                if (elem.Value > times)
                {
                    times = elem.Value;
                    ans = elem.Key;
                }
            }
            File.WriteAllText(@"./tests/output03.txt", ans.ToString());
        }
    }
}
