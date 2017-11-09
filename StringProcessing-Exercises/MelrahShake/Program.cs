using System;
using System.Text;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            StringBuilder pattern = new StringBuilder(Console.ReadLine());

            while(pattern.Length > 0)
            {
                int i = str.ToString().IndexOf(pattern.ToString());
                int j = str.ToString().LastIndexOf(pattern.ToString());
                if(i != -1 && j != -1 && i!=j)
                {
                    Console.WriteLine("Shaked it.");
                    str.Remove(j, pattern.Length);
                    str.Remove(i, pattern.Length);                   
                    pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(str);
                    return;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(str);
        }
    }
}
