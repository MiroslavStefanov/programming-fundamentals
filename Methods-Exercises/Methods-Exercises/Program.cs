using System;

namespace Methods_Exercises
{
    class Program
    {
        public static void Greetings(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            Greetings(Console.ReadLine());
        }
    }
}
