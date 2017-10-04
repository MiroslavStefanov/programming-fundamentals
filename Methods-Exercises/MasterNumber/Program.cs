using System;

namespace MasterNumber
{
    class Program
    {
        public static uint Reverse(uint n)
        {
            uint ans = 0;
            while(n > 0)
            {
                ans *= 10;
                ans += n % 10;
                n /= 10;
            }
            return ans;
        }
        public static bool IsPalindrome(uint n)
        {
            return n == Reverse(n);
        }
        public static uint SumOfDigits(uint n)
        {
            uint ans = 0;
            while(n > 0)
            {
                ans += n % 10;
                n /= 10;
            }
            return ans;
        }
        public static bool ContainsEvenDigit(uint n)
        {
            while(n > 0)
            {
                if (n % 10 % 2 == 0)
                    return true;
                n /= 10;
            }
            return false;
        }
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            
            for(uint i = 1; i<=n; i++)
                if(IsPalindrome(i) && SumOfDigits(i) % 7 == 0 && ContainsEvenDigit(i))
                    Console.WriteLine(i);
        }
    }
}
