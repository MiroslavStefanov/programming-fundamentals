using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(n);
        }
    }
}
