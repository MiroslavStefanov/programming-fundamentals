using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int indx = 0, lenght = 0, currLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (i < arr.Length - 1 && arr[i + 1] > arr[i])
                {
                    currLength++;
                    i++;
                }
                if (currLength > lenght)
                {
                    indx = i - currLength;
                    lenght = currLength;
                }
                currLength = 0;
            }
            for (int i = 0; i <= lenght; i++)
                Console.Write(arr[indx + i] + " ");
        }
    }
}
