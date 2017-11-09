using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string patternForSentence = "[.!?]";
            var sentences = Regex.Split(text, patternForSentence);
            string patternForWords = @"\b\w+\b";
            var regex = new Regex(patternForWords);
            foreach (var s in sentences)
            {
                foreach(Match m in regex.Matches(s))
                    if(m.ToString() == keyword)
                        Console.WriteLine(s.TrimStart());
            }
        }
    }
}
