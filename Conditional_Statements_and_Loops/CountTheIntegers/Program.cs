using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumIntegers = 0;
            while(true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    nNumIntegers++;
                }
                catch(Exception)
                {
                    break;
                }
            }
            Console.WriteLine(nNumIntegers);
        }
    }
}
