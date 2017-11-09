using System;
using System.Collections.Generic;
using System.IO;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            string input, name = "";
            string[] s = File.ReadAllLines("tests/input01.txt");
            uint i = 0;
            do
            {
                input = s[i];
                if (name == "")
                    name = input;
                else
                {
                    string domain = input.Substring(input.Length - 2).ToLower();
                    if (domain != "us" && domain != "uk")
                        emails[name] = input;
                    name = "";
                }
                i++;
            } while (input != "stop");
            foreach (var mail in emails)
            {
                File.AppendAllText("tests/output01.txt", mail.Key + " -> " + mail.Value + Environment.NewLine);
            }
        }
    }
}
