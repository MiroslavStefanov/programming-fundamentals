using System;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = 2.0 * (width + height);
            Console.WriteLine(result);
            result = width * height;
            Console.WriteLine(result);
            result = Math.Sqrt(width * width + height * height);
            Console.WriteLine(result);
        }
    }
}
