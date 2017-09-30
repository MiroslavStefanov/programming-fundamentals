using System;

namespace ReservedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            a = Convert.ToChar(Console.ReadLine());
            b = Convert.ToChar(Console.ReadLine());
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{2}{1}{0}", a, b, c);
        }
    }
}
