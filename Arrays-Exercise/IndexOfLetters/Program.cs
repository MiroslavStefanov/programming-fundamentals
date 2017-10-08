using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            for (int i = 0; i < 26; i++)
                letters[i] = (char)('a' + i);
            char[] input = Console.ReadLine().ToLower().ToCharArray();
            for(uint i = 0; i<input.Length; i++)
            {
                int indx = Find(input[i], letters);
                if(indx != -1)
                    Console.WriteLine(input[i] + " -> " + indx);
            }
        }
        public static int Find(char c, char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
                if (letters[i] == c)
                    return i;
            return -1;
        }
    }
}
