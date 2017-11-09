using System;
using System.Text;
using System.Numerics;

namespace ConvertFrom10toNbase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            string ans = Convert(BigInteger.Parse(input[1]), int.Parse(input[0]));
            Console.WriteLine(ans);
        }
        static string Convert(BigInteger num, int b)
        {
            StringBuilder s = new StringBuilder();
            while (num > 0)
            {
                s.Append(num % b);
                num /= b;
            }
            var c = s.ToString().ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
    }
}
