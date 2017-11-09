using System;
using System.Text.RegularExpressions;
using System.Text;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {           
            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"^([A-Za-z]+)[\|<\\](?:.*[\|<\\])*([A-Za-z]+)$";
            Match key = Regex.Match(keys, pattern);           
            StringBuilder ans = new StringBuilder();
            int indxS = -1, indxE = -1;
            do
            {
                indxS = text.IndexOf(key.Groups[1].ToString(), indxS + 1);
                indxE = text.IndexOf(key.Groups[2].ToString(), indxE + 1);
                if (indxS == -1 || indxE == -1)
                    break;
                int s = indxS + key.Groups[1].Length;
                ans.Append(text.Substring(s, indxE - s));
            } while (true);
            if(ans.Length > 0)
                Console.WriteLine(ans);
            else
                Console.WriteLine("Empty result");
        }
    }
}
