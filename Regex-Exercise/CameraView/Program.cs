using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            int m = int.Parse(line[0]), n = int.Parse(line[1]);
            string pattern = @"\|<([^(|<)]*)";
            var regex = new Regex(pattern);
            var ans = new List<string>();
            var matches = regex.Matches(Console.ReadLine());
            foreach (Match cam in matches)
            {
                ans.Add(cam.Groups[1].ToString().Substring(m, Math.Min(n, cam.Groups[1].Length-m)));
            }
            Console.WriteLine(String.Join(", ", ans));
        }
    }
}
