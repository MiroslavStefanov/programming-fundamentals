using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string sWord = Console.ReadLine();
            string sEnding = sWord.Substring(sWord.Length - 2);
            if (sEnding[1] == 'y')
            {
                sWord = sWord.Insert(sWord.Length - 1, "ies");
                sWord = sWord.Remove(sWord.Length - 1);
            }   
            else if (sEnding[1] == 'o' || sEnding == "ch" || sEnding[1] == 's' || sEnding == "sh" || sEnding[1] == 'x' || sEnding[1] == 'z')
                sWord = sWord.Insert(sWord.Length, "es");
            else
                sWord = sWord.Insert(sWord.Length, "s");
            Console.WriteLine(sWord);
        }
    }
}
