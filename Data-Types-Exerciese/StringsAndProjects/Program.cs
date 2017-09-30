using System;

namespace StringsAndProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloString = "Hello";
            string worldString = "World";
            Object concatenatedStringObject = helloString + " " + worldString;
            string concatenatedString = (string)concatenatedStringObject;
            Console.WriteLine(concatenatedString);
        }
    }
}
