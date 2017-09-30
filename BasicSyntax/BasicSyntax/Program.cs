using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg1, arg2, arg3, arg4;
            arg1 = int.Parse(Console.ReadLine());
            arg2 = int.Parse(Console.ReadLine());
            arg3 = int.Parse(Console.ReadLine());
            arg4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{arg1:D4} {arg2:D4} {arg3:D4} {arg4:D4}");
        }
    }
}