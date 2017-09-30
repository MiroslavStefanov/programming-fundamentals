using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            const double eps = 0.000001d;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(a-b) < eps);
        }
    }
}
