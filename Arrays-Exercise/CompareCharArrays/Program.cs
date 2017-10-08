using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFirstSmaller = true;
            char[] first = Console.ReadLine().Split(' ').Select(x => x[0]).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(x => x[0]).ToArray();
            int l1 = first.Length;
            int l2 = second.Length;
            for(int i = 0; i<l1; i++)
            {
                if (i == l2)
                {
                    isFirstSmaller = false;
                    break;
                }
                if(first[i] > second[i])
                {
                    isFirstSmaller = false;
                    break;
                }
            }
            if(isFirstSmaller)
                Console.WriteLine(String.Join("", first));
            Console.WriteLine(String.Join("", second));
            if(!isFirstSmaller)
                Console.WriteLine(String.Join("", first));
        }
    }
}
