using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 16).ToUpper());
            Console.WriteLine(Convert.ToString(n, 2).ToUpper());
        }
    }
}
