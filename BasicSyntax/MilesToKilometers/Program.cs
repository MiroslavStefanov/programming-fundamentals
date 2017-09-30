using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ratio = 1.60934;
            double miles = double.Parse(Console.ReadLine());
            double km = miles * ratio;
            Console.WriteLine($"{km:F2}");
        }
    }
}