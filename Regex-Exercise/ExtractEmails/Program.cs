using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\w.-]+\@[A-Za-z-]+)(\.[A-Za-z-]+)+";
            string input = Console.ReadLine();
            foreach (Match email in Regex.Matches(input, pattern))
            {
                string e = email.ToString();
                if(!(e.StartsWith("-") || e.StartsWith("_") || e.StartsWith(".") || e.EndsWith("-") || e.EndsWith(".") || e.EndsWith("!")))
                    Console.WriteLine(email);
            }
        }
    }
}
