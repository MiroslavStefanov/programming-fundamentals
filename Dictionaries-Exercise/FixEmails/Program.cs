using System;
using System.Collections.Generic;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            string input, name = "";
            do
            {
                input = Console.ReadLine();
                if (name == "")
                    name = input;
                else
                {
                    string domain = input.Substring(input.Length - 2).ToLower();
                    if (domain != "us" && domain != "uk")
                        emails[name] = input;
                    name = "";
                }
            } while (input != "stop");
            foreach (var mail in emails)
            {
                Console.WriteLine(mail.Key + " -> " + mail.Value);
            }
        }
    }
}
