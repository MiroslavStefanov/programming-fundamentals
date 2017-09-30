using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = Convert.ToBoolean(Console.ReadLine());
            if(b)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
