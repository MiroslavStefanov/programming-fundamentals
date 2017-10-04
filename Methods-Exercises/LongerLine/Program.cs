using System;

namespace LongerLine
{
    class Program
    {
        public static bool IsFirstCloser(double x1, double y1, double x2, double y2)
        {
            return x1 * x1 + y1 * y1 <= x2 * x2 + y2 * y2;
        }
        public static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double sqrLenght1 = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            double sqrLenght2 = (x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3);
            if(sqrLenght1 >= sqrLenght2)
            {
                if(IsFirstCloser(x1, y1, x2, y2))
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                if (IsFirstCloser(x3, y3, x4, y4))
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}
