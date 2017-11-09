using System;
using System.Linq;
using System.IO;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = File.ReadAllText("tests/input03.txt").Split(' ').Select(int.Parse).ToArray();
            int indx = 0, lenght = 0, currLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (i < arr.Length - 1 && arr[i + 1] == arr[i])
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
                File.AppendAllText("tests/output03.txt", arr[indx + i] + " ");
        }
    }
}
