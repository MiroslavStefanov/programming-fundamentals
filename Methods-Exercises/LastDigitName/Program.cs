using System;

namespace LastDigitName
{
    class Program
    {
        public static void PrintLastDigit(long n)
        {
            string name = "";
            switch(Math.Abs(n)%10)
            {
                case 0:
                    name = "zero"; break;
                case 1:
                    name = "one"; break;
                case 2:
                    name = "two"; break;
                case 3:
                    name = "three"; break;
                case 4:
                    name = "four"; break;
                case 5:
                    name = "five"; break;
                case 6:
                    name = "six"; break;
                case 7:
                    name = "seven"; break;
                case 8:
                    name = "eight"; break;
                case 9:
                    name = "nine"; break;
            }
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            PrintLastDigit(n);
        }
    }
}
