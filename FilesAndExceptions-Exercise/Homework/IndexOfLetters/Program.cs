using System;
using System.IO;
using System.Collections.Generic;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, byte> dict = new Dictionary<char, byte>();
            for(char i = 'a'; i<='z'; i++)
                dict.Add(i, (byte)(i - 'a'));
            string word = File.ReadAllText("./tests/input02.txt");
            string ans = "";
            for (int i = 0; i < word.Length; i++)
            {
                ans += (word[i] + " -> " + dict[word[i]] + Environment.NewLine);
            }
            File.WriteAllText("./tests/output02.txt", ans);
        }
    }
}
