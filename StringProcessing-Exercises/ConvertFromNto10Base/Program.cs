using System;
using System.Text;
using System.Numerics;

namespace ConvertFromNto10Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            string ans = Convert(input[1], int.Parse(input[0]));
            Console.WriteLine(ans);
        }
        static string Convert(string num, int b)
        {
            if (b == 10)
                return num;
            BigInteger ans = new BigInteger(0);
            for(int i = 0; i<num.Length; i++)
            {
                ans += int.Parse(num.Substring(i, 1));
                ans *= b;
            }
            ans /= b;
            return ans.ToString();
        }
    }
}
