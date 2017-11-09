using System;
using System.Text;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert(Console.ReadLine()));
        }
        static string Convert(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
                sb.AppendFormat("\\u{0:x4}", (uint)c);
            return sb.ToString();
        }
    }
}
