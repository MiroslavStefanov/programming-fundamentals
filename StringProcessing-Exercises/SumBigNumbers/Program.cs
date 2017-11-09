using System;
using System.Text;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(Console.ReadLine(), Console.ReadLine()));
        }
        static string Sum(string s0, string s1)
        {
            StringBuilder sb = new StringBuilder();

            int k = 0;
            int i0 = s0.Length - 1, i1 = s1.Length - 1;
            int n0, n1;
            while(i0 >= 0 || i1 >= 0 || k!=0)
            {
                if (i0 >= 0)
                    n0 = int.Parse(s0.Substring(i0, 1));
                else
                    n0 = 0;

                if (i1 >= 0)
                    n1 = int.Parse(s1.Substring(i1, 1));
                else
                    n1 = 0;

                int sum = n0 + n1 + k;
                sb.Insert(0, sum % 10);
                k = sum / 10;

                i0--;
                i1--;
            }

            return sb.ToString();
        }
    }
}
