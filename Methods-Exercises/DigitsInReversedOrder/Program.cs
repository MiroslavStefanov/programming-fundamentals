using System;

namespace DigitsInReversedOrder
{
    class Program
    {
        public static void PrintInReversedOrder(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
                Console.Write(number[i]);
        }
        static void Main(string[] args)
        {
            PrintInReversedOrder(Console.ReadLine());
        }
    }
}
