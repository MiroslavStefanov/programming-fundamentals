using System;

namespace CubeProperties
{
    class Program
    {
        public static double FaceDiagonal(double side)
        {
            return Math.Sqrt(2.0) * side;
        }
        public static double SpaceDiagonal(double side)
        {
            return Math.Sqrt(3.0) * side;
        }
        public static double Volume(double side)
        {
            return side * side * side;
        }
        public static double SurfaceArea(double side)
        {
            return 6 * side * side;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            switch(Console.ReadLine())
            {
                case "area":
                    Console.WriteLine($"{SurfaceArea(side):F2}"); break;
                case "volume":
                    Console.WriteLine($"{Volume(side):F2}"); break;
                case "face":
                    Console.WriteLine($"{FaceDiagonal(side):F2}"); break;
                case "space":
                    Console.WriteLine($"{SpaceDiagonal(side):F2}"); break;
            }
        }
    }
}
