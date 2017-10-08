using System;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');
            int minLenght = firstLine.Length < secondLine.Length ? firstLine.Length : secondLine.Length;
            int count = 0;
            for(int i = 0; i<minLenght; i++)
            {
                if (firstLine[i] == secondLine[i])
                    count++;
                else
                    break;
            }
            int count2 = 0;
            for(int i = 0; i<minLenght; i++)
            {
                if (firstLine[firstLine.Length - 1 - i] == secondLine[secondLine.Length - 1 - i])
                    count2++;
                else
                    break;
            }
            Console.WriteLine(count > count2 ? count : count2);
        }
    }
}
