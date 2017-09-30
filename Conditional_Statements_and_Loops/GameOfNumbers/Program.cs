using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int last1 = -1, last2 = -1;
            for(int i = n; i<=m; i++)
                for(int j = n; j<=m; j++)
                    if(i + j == max)
                    {
                        last1 = i;
                        last2 = j;
                    }
            if(last1 == -1)
            {
                Console.WriteLine($"{(m - n + 1) * (m - n + 1)} combinations - neither equals {max}");
            }
            else
            {
                Console.WriteLine($"Number found! {last1} + {last2} = {max}");
            }
        }
    }
}
