using System;

namespace GeometryCalculator
{
    class Program
    {
        public static double TriangleArea(double side, double height)
        {
            return side * height * 0.5;
        }
        public static double RectArea(double width, double height)
        {
            return width * height;
        }
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
            switch(Console.ReadLine())
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{TriangleArea(side, height):F2}");
                    } break;
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{RectArea(side, side):F2}");
                    }
                    break;
                case "rectangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{RectArea(side, height):F2}");
                    }
                    break;
                case "circle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{CircleArea(side):F2}");
                    }
                    break;
            }
        }
    }
}
