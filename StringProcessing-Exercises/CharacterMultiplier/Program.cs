using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mult(Console.ReadLine().Split()));
        }
        static ulong Mult(string[] s)
        {
            ulong ans = 0;
            for (int i = 0; i < Math.Max(s[0].Length, s[1].Length); i++)
            {
                int c1, c2;
                try
                {
                    c1 = s[0][i];
                }
                catch
                {
                    c1 = 1;
                }
                try
                {
                    c2 = s[1][i];
                }
                catch
                {
                    c2 = 1;
                }
                ans += (ulong)(c1 * c2);
            }
            return ans;
        }
    }
}
