using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mult(Console.ReadLine(), int.Parse(Console.ReadLine())));
        }
        static string Mult(string s, int n)
        {
            var sb = new StringBuilder();

            int k = 0;
            for(int i = s.Length - 1; i>=0; i--)
            {
                int p = n * int.Parse(s.Substring(i, 1)) + k;
                sb.Insert(0, p % 10);
                k = p / 10;

                if (i == 0 && k!=0)
                    sb.Insert(0, k);
            }

            return sb.ToString();
        }
    }
}
